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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButt
            // 
            this.StartButt.Location = new System.Drawing.Point(12, 229);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(134, 29);
            this.StartButt.TabIndex = 0;
            this.StartButt.Text = "Start Export";
            this.StartButt.UseVisualStyleBackColor = true;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // StartDTPicker
            // 
            this.StartDTPicker.Location = new System.Drawing.Point(12, 50);
            this.StartDTPicker.Name = "StartDTPicker";
            this.StartDTPicker.Size = new System.Drawing.Size(185, 27);
            this.StartDTPicker.TabIndex = 1;
            // 
            // EndDTPicker
            // 
            this.EndDTPicker.Location = new System.Drawing.Point(12, 83);
            this.EndDTPicker.Name = "EndDTPicker";
            this.EndDTPicker.Size = new System.Drawing.Size(185, 27);
            this.EndDTPicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "EventLog Exporter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Time";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(203, 50);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(105, 27);
            this.StartTimePicker.TabIndex = 6;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(203, 83);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(105, 27);
            this.EndTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log Entries Found:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(147, 154);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(17, 20);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(147, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(34, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Idle";
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(12, 116);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(156, 24);
            this.chkSecurity.TabIndex = 13;
            this.chkSecurity.Text = "Read Security Logs";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 306);
            this.Controls.Add(this.chkSecurity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDTPicker);
            this.Controls.Add(this.StartDTPicker);
            this.Controls.Add(this.StartButt);
            this.Name = "MainDialog";
            this.Text = "Windows Event Log Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButt;
        private DateTimePicker StartDTPicker;
        private DateTimePicker EndDTPicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Label label4;
        private Label lblCount;
        private Label label5;
        private Label label6;
        private Label lblStatus;
        private CheckBox chkSecurity;
    }
}