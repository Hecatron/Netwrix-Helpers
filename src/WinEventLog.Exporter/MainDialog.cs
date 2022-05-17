using WinEventLog.Exporter.EventLogProcessor;

namespace WinEventLog.Exporter {

    /// <summary> Main Dialoge. </summary>
    public partial class MainDialog : Form {

        /// <summary> Default constructor. </summary>
        public MainDialog() {
            InitializeComponent();

            lblHostName.Text = Environment.MachineName.ToString();
            var dtnow = DateTime.Now;
            StartDTPicker.Value = dtnow;
            EndDTPicker.Value = dtnow;
            StartTimePicker.Value = new DateTime(dtnow.Year, dtnow.Month, dtnow.Day, 0, 0, 0);
            EndTimePicker.Value = new DateTime(dtnow.Year, dtnow.Month, dtnow.Day, 23, 59, 59);
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
            if (chkApplication.Checked) {
                var opts = GetProcessorOpts("Application", "user");
                var proc = new Processor(opts);
                UpdateStatus("Reading Application event logs");
                proc.Read();
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: Application Logs");
                proc.ExportLogs();
            }
            if (chkSystem.Checked) {
                var opts = GetProcessorOpts("System", "system");
                var proc = new Processor(opts);
                UpdateStatus("Reading System event logs");
                proc.Read();
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: System Logs");
                proc.ExportLogs();
            }
            if (chkSecurity.Checked) {
                // Requires Privilege escalation to Admin
                var opts = GetProcessorOpts("Security", "security");
                var proc = new Processor(opts);
                UpdateStatus("Reading Security event logs");
                proc.Read();
                UpdateStatus("Records Found:" + proc.Count + " Beginning Export: Security Logs");
                proc.ExportLogs();
            }

            UpdateStatus("Done");
        }

        /// <summary> Updates the status. </summary>
        /// <param name="status_str"> The status string. </param>
        private void UpdateStatus(string status_str) {
            lblStatus.Text = status_str;
            Application.DoEvents();
        }

        /// <summary> Gets the search options. </summary>
        /// <returns> The search options. </returns>
        private ProcessorOpts GetProcessorOpts(string logsource, string nntsource) {
            var opts = new ProcessorOpts();

            var sdp = StartDTPicker.Value;
            var stp = StartTimePicker.Value;
            var startdt = new DateTime(sdp.Year, sdp.Month, sdp.Day, stp.Hour, stp.Minute, stp.Second);

            var edp = EndDTPicker.Value;
            var etp = EndTimePicker.Value;
            var enddt = new DateTime(edp.Year, edp.Month, edp.Day, etp.Hour, etp.Minute, etp.Second);

            opts.StartDateTime = startdt;
            opts.EndDateTime = enddt;
            opts.HostName = lblHostName.Text;
            opts.LogSource = logsource;
            opts.NNTSource = nntsource;
            opts.ExportFilePath = Path.Combine(tbDirPath.Text, logsource + ".log");
            return opts;
        }
    }
}
