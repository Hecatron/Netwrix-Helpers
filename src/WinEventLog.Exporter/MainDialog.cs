using System.Net;
using WinEventLog.Exporter.LogExporter;

namespace WinEventLog.Exporter {

    /// <summary> Main Dialoge. </summary>
    public partial class MainDialog : Form {

        private long RecordCount { get; set; }

        /// <summary> Default constructor. </summary>
        public MainDialog() {
            InitializeComponent();

            lblHostName.Text = Environment.MachineName.ToString();
            var dtnow = DateTime.Now;
            StartDTPicker.Value = dtnow;
            EndDTPicker.Value = dtnow;
            StartTimePicker.Value = new DateTime(dtnow.Year, dtnow.Month, dtnow.Day, 0, 0, 0);
            EndTimePicker.Value = new DateTime(dtnow.Year, dtnow.Month, dtnow.Day, 23, 59, 59);
            GetIPs();
            RecordCount = 0;
        }

        /// <summary> Get the local IP Address's </summary>
        private void GetIPs() {
            var hostname = Environment.MachineName.ToString();
            var ipEntry = Dns.GetHostEntry(hostname);
            var addr = ipEntry.AddressList;

            // Only list IP4 address's
            var result = from item in addr
                         where item.IsIPv6LinkLocal == false
                         select item;

            cbIPs.Items.Clear();
            foreach (var item in result) {
                cbIPs.Items.Add(item.ToString());
            }
            if (cbIPs.Items.Count > 0)
                cbIPs.SelectedIndex = 0;
        }

        /// <summary> Pick a Destination. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void btDestination_Click(object sender, EventArgs e) {
            var destdirDialog = new FolderBrowserDialog();
            var result = destdirDialog.ShowDialog();
            if (result == DialogResult.OK) {
                tbDirPath.Text = destdirDialog.SelectedPath;
            }
        }

        /// <summary> Start processing. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void StartButt_Click(object sender, EventArgs e) {
            RecordCount = 0;
            if (chkApplication.Checked) {
                var opts = GetExporterOpts("Application.log");
                var proc = new ExporterAppLog(opts);
                UpdateStatus("Reading Application event logs");
                proc.Read();
                RecordCount += proc.Count;
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: Application Logs");
                proc.ExportLogs();
            }
            if (chkSystem.Checked) {
                var opts = GetExporterOpts("System.log");
                var proc = new ExporterSysLog(opts);
                UpdateStatus("Reading System event logs");
                proc.Read();
                RecordCount += proc.Count;
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: System Logs");
                proc.ExportLogs();
            }
            if (chkSecurity.Checked) {
                // Requires Privilege escalation to Admin
                var opts = GetExporterOpts("Security.log");
                var proc = new ExporterSecurityLog(opts);
                UpdateStatus("Reading Security event logs");
                proc.Read();
                RecordCount += proc.Count;
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: Security Logs");
                proc.ExportLogs();
            }

            UpdateStatus("Done");
        }

        /// <summary> Updates the status. </summary>
        /// <param name="status_str"> The status string. </param>
        private void UpdateStatus(string status_str) {
            lblStatus.Text = status_str;
            lblCount.Text = RecordCount.ToString();
            Application.DoEvents();
        }

        /// <summary> Gets the search options. </summary>
        /// <returns> The search options. </returns>
        private ExporterOpts GetExporterOpts(string filename) {
            var opts = new ExporterOpts();

            var sdp = StartDTPicker.Value;
            var stp = StartTimePicker.Value;
            var startdt = new DateTime(sdp.Year, sdp.Month, sdp.Day, stp.Hour, stp.Minute, stp.Second);

            var edp = EndDTPicker.Value;
            var etp = EndTimePicker.Value;
            var enddt = new DateTime(edp.Year, edp.Month, edp.Day, etp.Hour, etp.Minute, etp.Second);

            opts.StartDateTime = startdt;
            opts.EndDateTime = enddt;
            opts.HostName = lblHostName.Text;

            var selectedip = cbIPs.SelectedItem.ToString();
            if (selectedip != null)
                opts.IPAddress = selectedip;
            else
                opts.IPAddress = "X.X.X.X";

            opts.ExportFilePath = Path.Combine(tbDirPath.Text, filename);
            return opts;
        }
    }
}
