using System.Diagnostics;
using System.Text;
//using System.Diagnostics.Eventing.Reader;

namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Event Log Reader. </summary>
    public class Processor {

        /// <summary> Search Options. </summary>
        private ProcessorOpts _Opts;

        /// <summary> Event log entries. </summary>
        private List<EventLogEntry> _LogEntries;

        /// <summary> Number of log entries found. </summary>
        public long Count;

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Search Options. </param>
        public Processor(ProcessorOpts opts) {
            _Opts = opts;
            _LogEntries = new List<EventLogEntry>();
        }

        /// <summary> Read the log entries from the log source. </summary>
        public void Read() {
            EventLog log = new EventLog(_Opts.LogSource);
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

                // TODO

                var log = _LogEntries[0];
                var logst = ExportLogString(log);
                writetext.WriteLine(logst);

                //foreach (EventLogEntry entry in _LogEntries) {
                //    var logstr = ExportLogString(entry);
                //    writetext.WriteLine(logstr);
                //}
            }
        }

        /// <summary> Generate a line from a single log entry. </summary>
        /// <param name="entry"> The event log entry. </param>
        /// <returns> The string needed for the export. </returns>
        private string ExportLogString(EventLogEntry entry) {
            // TODO IP address

            var sb = new StringBuilder();
            sb.Append(entry.TimeWritten.ToString("yyyy/MM/dd HH:mm:ss "));
            sb.Append("TODO_IP ");
            sb.Append(_Opts.LogSource);
            sb.Append(' ');

            switch (entry.EntryType) {
                case EventLogEntryType.Information:
                    sb.Append("notice ");
                    break;
                case EventLogEntryType.Warning:
                    sb.Append("warning ");
                    break;
                case EventLogEntryType.Error:
                    sb.Append("error ");
                    break;
                case EventLogEntryType.FailureAudit:
                    sb.Append("warning ");
                    break;
                case EventLogEntryType.SuccessAudit:
                    sb.Append("warning ");
                    break;
                default:
                    sb.Append("notice ");
                    break;
            }

            sb.Append("Location: ");
            sb.Append(_Opts.HostName);
            sb.Append(" - ");

            // TODO Add this in
            //_Opts.NNTSource

            // TODO

            var sb_str = sb.ToString();
            return sb_str;
        }

        // Example of reading in a windows exported log file
        //private void Test1() {
        //    using (var reader = new EventLogReader(@"D:\Temp\14\test1.evtx", PathType.FilePath)) {
        //        EventRecord record;
        //        while ((record = reader.ReadEvent()) != null) {
        //            using (record) {
        //                var test1 = record.FormatDescription();
        //                Console.WriteLine("{0} {1}: {2}", record.TimeCreated, record.LevelDisplayName, record.FormatDescription());
        //            }
        //        }
        //    }
        //}

    }
}
