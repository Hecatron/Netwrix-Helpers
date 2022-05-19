using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace WinEventLog.Exporter.LogExporter {

    /// <summary> Log Exporter for the System Logs. </summary>
    public class ExporterSysLog : ExporterBase {

        /// <summary> Constructor. </summary>
        /// <param name="opts"> Search Options. </param>
        public ExporterSysLog(ExporterOpts opts) : base(opts) {
            LogSource = "System";
        }

        /// <summary> Generate a line from a single log entry. </summary>
        /// <param name="entry"> The event log entry. </param>
        /// <returns> The string needed for the export. </returns>
        protected override string ProcessLogEntry(EventLogEntry entry) {
            var sb = new StringBuilder();
            sb.Append(entry.TimeWritten.ToString("yyyy/MM/dd HH:mm:ss "));
            sb.Append(_Opts.IPAddress);
            sb.Append(' ');
            sb.Append("system ");

            string nnt_entrytype;

            switch (entry.EntryType) {
                case EventLogEntryType.Information:
                    nnt_entrytype = "notice ";
                    break;
                case EventLogEntryType.Warning:
                    nnt_entrytype = "warning ";
                    break;
                case EventLogEntryType.Error:
                    nnt_entrytype = "error ";
                    break;
                case EventLogEntryType.FailureAudit:
                    nnt_entrytype = "error ";
                    break;
                case EventLogEntryType.SuccessAudit:
                    nnt_entrytype = "notice ";
                    break;
                default:
                    nnt_entrytype = "notice ";
                    break;
            }

            sb.Append(nnt_entrytype);
            sb.Append("Location: ");
            sb.Append(_Opts.HostName);
            sb.Append(" - ");
            sb.Append(LogSource);
            sb.Append(" ");
            sb.Append(entry.InstanceId);
            sb.Append(": ");
            sb.Append(entry.Source);
            sb.Append(": ");

            var msg = entry.Message;
            if (entry.InstanceId == 4624) {
                var index1 = msg.IndexOf("It is generated on the computer that was accessed.");
                if (index1 > 0)
                    msg = msg.Substring(0, index1 - 1);
            }
            sb.Append(msg);

            if (entry.EntryType == EventLogEntryType.SuccessAudit)
                sb.Append(" (Audit Success)");
            if (entry.EntryType == EventLogEntryType.FailureAudit)
                sb.Append(" (Audit Failure)");

            var sb_str = sb.ToString();
            sb_str = Regex.Replace(sb_str, @"[\t,\n,\r]+", " ");
            return sb_str;
        }
    }
}
