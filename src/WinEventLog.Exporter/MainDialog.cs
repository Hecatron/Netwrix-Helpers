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
                tbFilePath.Text = destdirDialog.SelectedPath;
            }
        }

        /// <summary> Start processing. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void StartButt_Click(object sender, EventArgs e) {
            var searchopts = GetSearchOpts();
            var reader = new EventLogProcessor.Exporter(searchopts);

            lblStatus.Text = "Reading event logs";
            Application.DoEvents();
            reader.Read();

            lblCount.Text = reader.Count.ToString();
            lblStatus.Text = "Exporting to File";
            Application.DoEvents();
            reader.ExportLogs();

            lblStatus.Text = "Idle";
        }

        /// <summary> Gets the search options. </summary>
        /// <returns> The search options. </returns>
        private ExporterOpts GetSearchOpts() {
            var sdp = StartDTPicker.Value;
            var stp = StartTimePicker.Value;
            var startdt = new DateTime(sdp.Year, sdp.Month, sdp.Day, stp.Hour, stp.Minute, stp.Second);

            var edp = EndDTPicker.Value;
            var etp = EndTimePicker.Value;
            var enddt = new DateTime(edp.Year, edp.Month, edp.Day, etp.Hour, etp.Minute, etp.Second);

            var ret = new ExporterOpts(startdt, enddt, chkApplication.Checked, chkSystem.Checked, chkSecurity.Checked,
                tbFilePath.Text, lblHostName.Text);
            return ret;
        }

    }
}
