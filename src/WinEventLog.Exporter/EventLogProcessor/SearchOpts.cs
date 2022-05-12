namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Search Options for searching the event log. </summary>
    public class SearchOpts {

        /// <summary> Gets or sets the start date time. </summary>
        /// <value> The start date time. </value>
        public DateTime StartDateTime { get; set; }

        /// <summary> Gets or sets the end date time. </summary>
        /// <value> The end date time. </value>
        public DateTime EndDateTime { get; set; }

        /// <summary> If to try and read admin level event logs such as the Security logs. </summary>
        /// <value> True if read privileged, false if not. </value>
        public bool ReadPrivileged { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="start_datetime"> The start time. </param>
        /// <param name="end_datetime">   The end time. </param>
        public SearchOpts(DateTime start_datetime, DateTime end_datetime, bool read_privileged) {
            StartDateTime = start_datetime;
            EndDateTime = end_datetime;
            ReadPrivileged = read_privileged;
        }

    }
}
