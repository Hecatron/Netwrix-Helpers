using System.Diagnostics;
using System.Text;
//using System.Diagnostics.Eventing.Reader;

namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Event Log Reader. </summary>
    public class Exporter {

        /// <summary> Search Options. </summary>
        private ExporterOpts _Opts;

        /// <summary> Application Event log entries. </summary>
        private List<EventLogEntry> _AppLogs;

        /// <summary> System Event log entries. </summary>
        private List<EventLogEntry> _SystemLogs;

        /// <summary> Security Event log entries. </summary>
        private List<EventLogEntry> _SecurityLogs;

        /// <summary> Number of log entries found. </summary>
        public long Count;

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Search Options. </param>
        public Exporter(ExporterOpts opts) {
            _Opts = opts;
            _AppLogs = new List<EventLogEntry>();
            _SystemLogs = new List<EventLogEntry>();
            _SecurityLogs = new List<EventLogEntry>();
        }

        /// <summary> Read the logs from each of the sources. </summary>
        public void Read() {

            // Read in non admin event logs
            if (_Opts.ReadApplicationLogs)
                _AppLogs = GetLogs("Application");
            if (_Opts.ReadSystemLogs)
                _SystemLogs = GetLogs("System");

            // This needs admin priviledges
            if (_Opts.ReadSecurityLogs)
                _SecurityLogs = GetLogs("Security");

            Count = _AppLogs.Count + _SystemLogs.Count + _SecurityLogs.Count;
        }

        /// <summary> Gets the logs from a specific source. </summary>
        /// <param name="srcname"> The event source to pull from. </param>
        private List<EventLogEntry> GetLogs(string srcname) {
            var ret = new List<EventLogEntry>();
            EventLog log = new EventLog(srcname);
            var entries = log.Entries.Cast<EventLogEntry>()
                .Where(x => x.TimeGenerated >= _Opts.StartDateTime)
                .Where(x => x.TimeGenerated <= _Opts.EndDateTime)
                .ToList();
            ret.AddRange(entries);

            // Sort by datetime
            var sorted = from item in ret
                orderby item.TimeGenerated
                select item;
            ret = sorted.ToList();
            return ret;
        }

        /// <summary> Export logs to a file. </summary>
        public void ExportLogs() {
            if (_Opts.ReadApplicationLogs)
                ExportLog(_Opts.HostName + "-Application.log", "user", _AppLogs);
            if (_Opts.ReadSystemLogs)
                ExportLog(_Opts.HostName + "-System.log", "system", _SystemLogs);
            if (_Opts.ReadSecurityLogs)
                ExportLog(_Opts.HostName = "-Security.log", "security", _SecurityLogs);
        }

        /// <summary> Export logs to a file. </summary>
        public void ExportLog(string filename, string sourcename, List<EventLogEntry> logentries) {
            var filepath = Path.Combine(_Opts.ExportSaveDir, filename);
            using (StreamWriter writetext = new StreamWriter(filepath)) {

                // TODO

                var log = _AppLogs[0];
                var logstr = ExportLogString(sourcename, log);
                writetext.WriteLine(logstr);

                //foreach (EventLogEntry log in logentries) {
                //    var logstr = ExportLogString(log);
                //    writetext.WriteLine(logstr);
                //}
            }
        }

        private string ExportLogString(string sourcename, EventLogEntry entry) {
            // TODO IP address

            var sb = new StringBuilder();
            sb.Append(entry.TimeWritten.ToString("yyyy/MM/dd HH:mm:ss "));
            sb.Append("TODO_IP ");
            sb.Append(sourcename);
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
