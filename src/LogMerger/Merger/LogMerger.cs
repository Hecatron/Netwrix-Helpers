namespace LogMerger.Merger {

    /// <summary> A log file merger. </summary>
    public class LogMerger {

        /// <summary> Options for merging. </summary>
        /// <value> Options for merging. </value>
        private LogMergerOpts _opts { get; set; }

        /// <summary> List of source log files to be read. </summary>
        /// <value> The source logfiles. </value>
        private List<LogFile> _logfiles { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Merger options. </param>
        public LogMerger(LogMergerOpts opts) {
            _opts = opts;
            _logfiles = new List<LogFile>();
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


            // TODO
        }
    }
}
