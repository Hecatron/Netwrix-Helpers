namespace LogMerger {
    partial class MainDialog {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbSourceDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSrcDirBrowse = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDestFileBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSourceDir
            // 
            this.tbSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourceDir.Location = new System.Drawing.Point(263, 52);
            this.tbSourceDir.Name = "tbSourceDir";
            this.tbSourceDir.Size = new System.Drawing.Size(474, 47);
            this.tbSourceDir.TabIndex = 0;
            this.tbSourceDir.Text = "C:\\D\\Temp\\14\\src1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory:";
            // 
            // btSrcDirBrowse
            // 
            this.btSrcDirBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSrcDirBrowse.Location = new System.Drawing.Point(754, 52);
            this.btSrcDirBrowse.Name = "btSrcDirBrowse";
            this.btSrcDirBrowse.Size = new System.Drawing.Size(91, 47);
            this.btSrcDirBrowse.TabIndex = 2;
            this.btSrcDirBrowse.Text = "...";
            this.btSrcDirBrowse.UseVisualStyleBackColor = true;
            this.btSrcDirBrowse.Click += new System.EventHandler(this.btSrcDirBrowse_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStart.Location = new System.Drawing.Point(12, 204);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(188, 58);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestination.Location = new System.Drawing.Point(263, 105);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(474, 47);
            this.tbDestination.TabIndex = 4;
            this.tbDestination.Text = "C:\\D\\Temp\\14\\dest1\\dest.log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination:";
            // 
            // btDestFileBrowse
            // 
            this.btDestFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDestFileBrowse.Location = new System.Drawing.Point(754, 105);
            this.btDestFileBrowse.Name = "btDestFileBrowse";
            this.btDestFileBrowse.Size = new System.Drawing.Size(91, 47);
            this.btDestFileBrowse.TabIndex = 6;
            this.btDestFileBrowse.Text = "...";
            this.btDestFileBrowse.UseVisualStyleBackColor = true;
            this.btDestFileBrowse.Click += new System.EventHandler(this.btDestFileBrowse_Click);
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 290);
            this.Controls.Add(this.btDestFileBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSrcDirBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSourceDir);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainDialog";
            this.Text = "Log Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSourceDir;
        private Label label1;
        private Button btSrcDirBrowse;
        private Button btStart;
        private TextBox tbDestination;
        private Label label2;
        private Button btDestFileBrowse;
    }
}