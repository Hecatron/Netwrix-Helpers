namespace WinEventLog.Exporter {
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
            this.StartButt = new System.Windows.Forms.Button();
            this.StartDTPicker = new System.Windows.Forms.DateTimePicker();
            this.EndDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.chkApplication = new System.Windows.Forms.CheckBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIPs = new System.Windows.Forms.ComboBox();
            this.btDestination = new System.Windows.Forms.Button();
            this.tbDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHostName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButt
            // 
            this.StartButt.Location = new System.Drawing.Point(13, 201);
            this.StartButt.Margin = new System.Windows.Forms.Padding(6);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(285, 59);
            this.StartButt.TabIndex = 0;
            this.StartButt.Text = "Start Export";
            this.StartButt.UseVisualStyleBackColor = true;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // StartDTPicker
            // 
            this.StartDTPicker.Location = new System.Drawing.Point(13, 53);
            this.StartDTPicker.Margin = new System.Windows.Forms.Padding(6);
            this.StartDTPicker.Name = "StartDTPicker";
            this.StartDTPicker.Size = new System.Drawing.Size(389, 47);
            this.StartDTPicker.TabIndex = 1;
            this.StartDTPicker.Value = new System.DateTime(2022, 5, 7, 1, 0, 0, 0);
            // 
            // EndDTPicker
            // 
            this.EndDTPicker.Location = new System.Drawing.Point(13, 121);
            this.EndDTPicker.Margin = new System.Windows.Forms.Padding(6);
            this.EndDTPicker.Name = "EndDTPicker";
            this.EndDTPicker.Size = new System.Drawing.Size(389, 47);
            this.EndDTPicker.TabIndex = 2;
            this.EndDTPicker.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Time";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(419, 121);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(219, 47);
            this.EndTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log Entries Found:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(302, 131);
            this.lblCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(34, 41);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(136, 90);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 41);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Idle";
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Checked = true;
            this.chkSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecurity.Location = new System.Drawing.Point(13, 275);
            this.chkSecurity.Margin = new System.Windows.Forms.Padding(6);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(306, 45);
            this.chkSecurity.TabIndex = 13;
            this.chkSecurity.Text = "Read Security Logs";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // chkApplication
            // 
            this.chkApplication.AutoSize = true;
            this.chkApplication.Checked = true;
            this.chkApplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplication.Location = new System.Drawing.Point(13, 189);
            this.chkApplication.Margin = new System.Windows.Forms.Padding(6);
            this.chkApplication.Name = "chkApplication";
            this.chkApplication.Size = new System.Drawing.Size(351, 45);
            this.chkApplication.TabIndex = 14;
            this.chkApplication.Text = "Read Application Logs";
            this.chkApplication.UseVisualStyleBackColor = true;
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Checked = true;
            this.chkSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSystem.Location = new System.Drawing.Point(13, 232);
            this.chkSystem.Margin = new System.Windows.Forms.Padding(6);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(296, 45);
            this.chkSystem.TabIndex = 15;
            this.chkSystem.Text = "Read System Logs";
            this.chkSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbIPs);
            this.groupBox1.Controls.Add(this.btDestination);
            this.groupBox1.Controls.Add(this.tbDirPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StartDTPicker);
            this.groupBox1.Controls.Add(this.chkSystem);
            this.groupBox1.Controls.Add(this.EndDTPicker);
            this.groupBox1.Controls.Add(this.chkApplication);
            this.groupBox1.Controls.Add(this.chkSecurity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1257, 473);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 41);
            this.label7.TabIndex = 21;
            this.label7.Text = "IP Address";
            // 
            // cbIPs
            // 
            this.cbIPs.FormattingEnabled = true;
            this.cbIPs.Location = new System.Drawing.Point(212, 338);
            this.cbIPs.Name = "cbIPs";
            this.cbIPs.Size = new System.Drawing.Size(490, 49);
            this.cbIPs.TabIndex = 20;
            // 
            // btDestination
            // 
            this.btDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDestination.Location = new System.Drawing.Point(1129, 394);
            this.btDestination.Margin = new System.Windows.Forms.Padding(6);
            this.btDestination.Name = "btDestination";
            this.btDestination.Size = new System.Drawing.Size(115, 59);
            this.btDestination.TabIndex = 18;
            this.btDestination.Text = "...";
            this.btDestination.UseVisualStyleBackColor = true;
            this.btDestination.Click += new System.EventHandler(this.btDestination_Click);
            // 
            // tbDirPath
            // 
            this.tbDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirPath.Location = new System.Drawing.Point(212, 396);
            this.tbDirPath.Margin = new System.Windows.Forms.Padding(6);
            this.tbDirPath.Name = "tbDirPath";
            this.tbDirPath.Size = new System.Drawing.Size(900, 47);
            this.tbDirPath.TabIndex = 18;
            this.tbDirPath.Text = "D:\\transfer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Directory:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblHostName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.StartButt);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 524);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1245, 337);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(215, 47);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(167, 41);
            this.lblHostName.TabIndex = 18;
            this.lblHostName.Text = "Host Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "Host Name:";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(419, 52);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(219, 47);
            this.StartTimePicker.TabIndex = 22;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 968);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainDialog";
            this.Text = "Windows Event Log Exporter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButt;
        private DateTimePicker StartDTPicker;
        private DateTimePicker EndDTPicker;
        private Label label2;
        private Label label3;
        private DateTimePicker EndTimePicker;
        private Label label4;
        private Label lblCount;
        private Label label5;
        private Label lblStatus;
        private CheckBox chkSecurity;
        private CheckBox chkApplication;
        private CheckBox chkSystem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btDestination;
        private TextBox tbDirPath;
        private Label label1;
        private Label lblHostName;
        private Label label6;
        private Label label7;
        private ComboBox cbIPs;
        private DateTimePicker StartTimePicker;
    }
}