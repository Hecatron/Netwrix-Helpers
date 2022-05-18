namespace LogMerger.Merger {

    /// <summary> A representation of a log file being read in. </summary>
    public class LogFile {

        /// <summary> The full pathname of the file. </summary>
        /// <value> The full pathname of the file. </value>
        public string FilePath { get; set; }

        /// <summary> Stream reader for the file. </summary>
        /// <value> The stream reader. </value>
        private StreamReader _Reader { get; set; }

        /// <summary> Current log line in the source file. </summary>
        /// <value> Current log line in the source file. </value>
        public string CurrentLine { get; set; }

        /// <summary> Current dttm of the log entry line. </summary>
        /// <value> The current dttm. </value>
        public DateTime CurrentDttm { get; set; }

        /// <summary> If the end of the file has been reached. </summary>
        /// <value> True if end of file, false if not. </value>
        public bool EndOfFile { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="filePath"> Full pathname of the file. </param>
        public LogFile(string filePath) {
            FilePath = filePath;
            _Reader = new StreamReader(filePath);
            CurrentLine = "";
            EndOfFile = false;
        }

        /// <summary> Reads the next line. </summary>
        public void ReadLine() {
            if (EndOfFile)
                return;
            var line = _Reader.ReadLine();
            if (line != null && line != "") {
                CurrentLine = line;
                ParseLine();
            } else {
                EndOfFile = true;
                CurrentLine = "";
            }
        }

        /// <summary> Resets the streamreader. </summary>
        public void Reset() {
            _Reader = new StreamReader(FilePath);
            EndOfFile = false;
        }

        /// <summary> Parse the read in line. </summary>
        private void ParseLine() {
            // Read the initial dttm for sorting
            var dttmformat = "yyyy/MM/dd HH:mm:ss";
            var dttmstr = CurrentLine.Substring(0, dttmformat.Length);
            CurrentDttm = DateTime.ParseExact(dttmstr, dttmformat, null);
        }
    }
}
