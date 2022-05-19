using System.Diagnostics;

namespace WinEventLog.Exporter.LogExporter {

    /// <summary> Base class for log exporters. </summary>
    public abstract class ExporterBase {

        /// <summary> Search Options. </summary>
        protected ExporterOpts _Opts;

        /// <summary> Event log entries. </summary>
        protected List<EventLogEntry> _LogEntries;

        /// <summary> Number of log entries found. </summary>
        public long Count;

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Search Options. </param>
        public ExporterBase(ExporterOpts opts) {
            _Opts = opts;
            _LogEntries = new List<EventLogEntry>();
        }

        /// <summary> Process a single log entry into a string. </summary>
        /// <param name="entry"> The log entry. </param>
        /// <returns> String representation of the log entry. </returns>
        protected abstract string ProcessLogEntry(EventLogEntry entry);

        /// <summary> The Windows level log source. </summary>
        /// <value> The windows log source. </value>
        protected string LogSource { get; set; } = "";

        /// <summary> Read the log entries from the log source. </summary>
        public void Read() {
            EventLog log = new EventLog(LogSource);
            var entries = log.Entries.Cast<EventLogEntry>()
                .Where(x => x.TimeGenerated >= _Opts.StartDateTime)
                .Where(x => x.TimeGenerated <= _Opts.EndDateTime)
                .ToList();
            _LogEntries.AddRange(entries);

            // Sort by datetime
            var sorted = from item in _LogEntries
                         orderby item.TimeGenerated
                         select item;
            _LogEntries = sorted.ToList();
            Count = _LogEntries.Count;
        }

        /// <summary> Export logs to a file. </summary>
        public void ExportLogs() {
            using (StreamWriter writetext = new StreamWriter(_Opts.ExportFilePath)) {
                foreach (EventLogEntry entry in _LogEntries) {
                    var logstr = ProcessLogEntry(entry);
                    // Exclude lines with this
                    if (logstr.Contains("ekrn.exe"))
                        continue;
                    writetext.WriteLine(logstr);
                }
            }
        }

    }
}
