using LogMerger.Merger;

namespace LogMerger {
    public partial class MainDialog : Form {

        /// <summary> Default constructor. </summary>
        public MainDialog() {
            InitializeComponent();
        }

        /// <summary> Pick a source directory. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void btSrcDirBrowse_Click(object sender, EventArgs e) {
            var srcdirDialog = new FolderBrowserDialog();
            var result = srcdirDialog.ShowDialog();
            if (result == DialogResult.OK) {
                tbSourceDir.Text = srcdirDialog.SelectedPath;
            }
        }

        /// <summary> Pick a destination directory. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void btDestFileBrowse_Click(object sender, EventArgs e) {
            var destdirDialog = new SaveFileDialog();
            var result = destdirDialog.ShowDialog();
            if (result == DialogResult.OK) {
                tbDestination.Text = destdirDialog.FileName;
            }
        }

        /// <summary> Start the merging of logs. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        private void btStart_Click(object sender, EventArgs e) {
            var opts = new LogMergerOpts(tbSourceDir.Text, tbDestination.Text);
            var merger = new Merger.LogMerger(opts);
            merger.Start();
        }
    }
}