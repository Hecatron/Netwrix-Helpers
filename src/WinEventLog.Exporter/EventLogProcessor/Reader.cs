using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace WinEventLog.Exporter.EventLogProcessor {

    /// <summary> Event Log Reader. </summary>
    public class Reader {

        /// <summary> Search Options. </summary>
        private SearchOpts _Opts;

        /// <summary> Event log entries found. </summary>
        private List<EventLogEntry> _Logs;

        /// <summary> Number of log entries found. </summary>
        public long Count;

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Search Options. </param>
        public Reader(SearchOpts opts) {
            _Opts = opts;
            _Logs = new List<EventLogEntry>();
        }

        /// <summary> Read the logs from each of the sources. </summary>
        public void Read() {

            Test1();

            // Read in non admin event logs
            GetLogs("Application");
            GetLogs("System");

            // This needs admin priviledges
            if (_Opts.ReadPrivileged)
                GetLogs("Security");

            // Sort by datetime
            var sorted = from item in _Logs
                    orderby item.TimeGenerated
                    select item;
            _Logs = sorted.ToList();

            Count = _Logs.Count;
        }

        /// <summary> Gets the logs from a specific source. </summary>
        /// <param name="srcname"> The event source to pull from. </param>
        private void GetLogs(string srcname) {
            EventLog log = new EventLog(srcname);
            var entries = log.Entries.Cast<EventLogEntry>()
                .Where(x => x.TimeGenerated >= _Opts.StartDateTime)
                .Where(x => x.TimeGenerated <= _Opts.EndDateTime)
                .ToList();
            _Logs.AddRange(entries);
        }

        private void Test1() {
            using (var reader = new EventLogReader(@"D:\Temp\14\test1.evtx", PathType.FilePath)) {


                EventRecord record;
                while ((record = reader.ReadEvent()) != null) {
                    using (record) {
                        var test1 = record.FormatDescription();
                        

                        Console.WriteLine("{0} {1}: {2}", record.TimeCreated, record.LevelDisplayName, record.FormatDescription());
                    }
                }
            }
        }


        /// <summary> Export logs to a file. </summary>
        public void ExportLogs() {
            // TODO
            //Console.WriteLine("Number of logs: " + _Logs.Count);
            //foreach (EventLogEntry log in _Logs) {
            //    Console.WriteLine("Log: " + log.TimeGenerated);
            //}
        }
    }
}
