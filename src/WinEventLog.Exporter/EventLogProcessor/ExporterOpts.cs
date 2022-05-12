namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Search Options for searching the event log. </summary>
    public class ExporterOpts {

        /// <summary> Gets or sets the start date time. </summary>
        /// <value> The start date time. </value>
        public DateTime StartDateTime { get; set; }

        /// <summary> Gets or sets the end date time. </summary>
        /// <value> The end date time. </value>
        public DateTime EndDateTime { get; set; }

        /// <summary> If to try and read admin level event logs such as the Security logs. </summary>
        /// <value> True if read privileged, false if not. </value>
        public bool ReadApplicationLogs { get; set; }

        /// <summary> If to try and read admin level event logs such as the Security logs. </summary>
        /// <value> True if read privileged, false if not. </value>
        public bool ReadSystemLogs { get; set; }

        /// <summary> If to try and read admin level event logs such as the Security logs. </summary>
        /// <value> True if read privileged, false if not. </value>
        public bool ReadSecurityLogs { get; set; }

        /// <summary> Path to save the exported file. </summary>
        /// <value> The full pathname of the save file. </value>
        public string ExportSaveDir { get; set; }

        /// <summary> HostName used for the logs. </summary>
        /// <value> HostName used for the logs. </value>
        public string HostName { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="start_datetime"> The start time. </param>
        /// <param name="end_datetime">   The end time. </param>
        public ExporterOpts(DateTime start_datetime, DateTime end_datetime, 
            bool read_app_logs, bool read_system_logs, bool read_security_logs, string export_save_dir,
            string hostname) {
            StartDateTime = start_datetime;
            EndDateTime = end_datetime;
            ReadApplicationLogs = read_app_logs;
            ReadSystemLogs = read_system_logs;
            ReadSecurityLogs = read_security_logs;
            ExportSaveDir = export_save_dir;
            HostName = hostname;
        }

    }
}
