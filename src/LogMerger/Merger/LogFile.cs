using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMerger.Merger {

    /// <summary> A representation of a log file being read in. </summary>
    public class LogFile {

        /// <summary> The full pathname of the file. </summary>
        /// <value> The full pathname of the file. </value>
        public string FilePath { get; set; }

        /// <summary> Constructor. </summary>
        /// <param name="filePath"> Full pathname of the file. </param>
        public LogFile(string filePath) {
            FilePath = filePath;
        }
    }
}
