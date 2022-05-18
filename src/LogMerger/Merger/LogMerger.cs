namespace LogMerger.Merger {

    /// <summary> A log file merger. </summary>
    public class LogMerger {

        /// <summary> Options for merging. </summary>
        /// <value> Options for merging. </value>
        private LogMergerOpts _opts { get; set; }

        /// <summary> List of source log files to be read. </summary>
        /// <value> The source logfiles. </value>
        private List<LogFile> _logfiles { get; set; }

        /// <summary> StreamWriter for writing to the destination. </summary>
        /// <value> The stream writer. </value>
        private StreamWriter _writer { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Merger options. </param>
        public LogMerger(LogMergerOpts opts) {
            _opts = opts;
            _logfiles = new List<LogFile>();
            _writer = new StreamWriter(_opts.DestFilePath);
        }

        /// <summary> Starts the merge. </summary>
        public void Start() {
            // Get a list of all the log files from the source dir
            _opts.GetLogPaths();

            // Parse into a list of LogFile class's
            _logfiles.Clear();
            foreach (var file in _opts.SourceFiles) {
                _logfiles.Add(new LogFile(file));
            }

            // Do an initial read line on all log sources
            foreach (var item in _logfiles) {
                item.ReadLine();
            }

            while(LogsAvailable()) {

                // TODO
                foreach (var file in _logfiles) {
                    while(file.EndOfFile == false) {
                        file.ReadLine();
                        if (file.EndOfFile == false) {
                            _writer.WriteLine(file.CurrentLine);
                        }
                    }
                }

            }
            _writer.Close();
        }

        /// <summary> Determine if all the source files have finished reading. </summary>
        /// <returns> True if log data still available. </returns>
        private bool LogsAvailable() {
            var ret = false;
            foreach (var item in _logfiles) {
                // If at least one of the source files hasn't finished reading
                // Then make sure to carry on
                if (item.EndOfFile == false) {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
    }
}
