namespace WinEventLog.Exporter.LogExporter {

    /// <summary> Log Exporter options. </summary>
    public class ExporterOpts {

        /// <summary> Gets or sets the start date time. </summary>
        /// <value> The start date time. </value>
        public DateTime StartDateTime { get; set; }

        /// <summary> Gets or sets the end date time. </summary>
        /// <value> The end date time. </value>
        public DateTime EndDateTime { get; set; }

        /// <summary> Path to save the exported file. </summary>
        /// <value> The full pathname of the save file. </value>
        public string ExportFilePath { get; set; } = "";

        /// <summary> HostName used for the logs. </summary>
        /// <value> HostName used for the logs. </value>
        public string HostName { get; set; } = "";

        /// <summary> IP Address used for the logs. </summary>
        /// <value> The IP address. </value>
        public string IPAddress { get; set; } = "";

    }
}
