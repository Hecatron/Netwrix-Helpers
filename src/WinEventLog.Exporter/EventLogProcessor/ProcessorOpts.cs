namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Search Options for searching the event log. </summary>
    public class ProcessorOpts {

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

        /// <summary> Log Source such as Application, System, Security used to pull from Windows. </summary>
        /// <value> The log source. </value>
        public string LogSource { get; set; } = "";

        /// <summary> The type of log used during export to a file. </summary>
        /// <value> The nnt source log type. </value>
        public string NNTSource { get; set; } = "";

        /// <summary> Default constructor. </summary>
        public ProcessorOpts() {}
    }
}
