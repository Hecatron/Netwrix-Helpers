namespace LogMerger.Merger {

    /// <summary> Options for the log merger. </summary>
    public class LogMergerOpts {

        /// <summary> Source directory to look for log files. </summary>
        /// <value> The source Dir. </value>
        public string SourceDir { get; set; }

        /// <summary> Destination file path for the merged log. </summary>
        /// <value> The full pathname of the destination file. </value>
        public string DestFilePath { get; set; }

        /// <summary> List of source log files. </summary>
        /// <value> The source files to read in. </value>
        public IEnumerable<string> SourceFiles { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="destFilePath"> Destination File Path. </param>
        public LogMergerOpts(string sourceDir, string destFilePath) {
            SourceDir = sourceDir;
            DestFilePath = destFilePath;
            SourceFiles = new List<string>();
        }

        /// <summary> Gets all the log file paths in the source directory. </summary>
        /// <returns> The log paths. </returns>
        public IEnumerable<string> GetLogPaths() {
            SourceFiles = Directory.EnumerateFiles(SourceDir, "*.log");
            return SourceFiles;
        }
    }
}
