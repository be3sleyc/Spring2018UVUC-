namespace CBMyGradeApp
{
    partial class StudyLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.grpBoxWrite = new System.Windows.Forms.GroupBox();
            this.btnAddStudyEntry = new System.Windows.Forms.Button();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.lstBoxCourses = new System.Windows.Forms.ListBox();
            this.grpBoxRead = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.lstBoxStudyEntries = new System.Windows.Forms.ListBox();
            this.grpBoxWrite.SuspendLayout();
            this.grpBoxRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duration (in minutes):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Today\'s Study Log Entries:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Note:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select a Course:";
            // 
            // lblToday
            // 
            this.lblToday.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToday.Location = new System.Drawing.Point(16, 43);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(121, 28);
            this.lblToday.TabIndex = 1;
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBoxWrite
            // 
            this.grpBoxWrite.Controls.Add(this.btnAddStudyEntry);
            this.grpBoxWrite.Controls.Add(this.txtBoxNotes);
            this.grpBoxWrite.Controls.Add(this.txtBoxDuration);
            this.grpBoxWrite.Controls.Add(this.lstBoxCourses);
            this.grpBoxWrite.Controls.Add(this.lblToday);
            this.grpBoxWrite.Controls.Add(this.label1);
            this.grpBoxWrite.Controls.Add(this.label4);
            this.grpBoxWrite.Controls.Add(this.label2);
            this.grpBoxWrite.Controls.Add(this.label5);
            this.grpBoxWrite.Location = new System.Drawing.Point(5, 3);
            this.grpBoxWrite.Name = "grpBoxWrite";
            this.grpBoxWrite.Size = new System.Drawing.Size(409, 243);
            this.grpBoxWrite.TabIndex = 2;
            this.grpBoxWrite.TabStop = false;
            // 
            // btnAddStudyEntry
            // 
            this.btnAddStudyEntry.AutoSize = true;
            this.btnAddStudyEntry.Location = new System.Drawing.Point(268, 176);
            this.btnAddStudyEntry.Name = "btnAddStudyEntry";
            this.btnAddStudyEntry.Size = new System.Drawing.Size(135, 29);
            this.btnAddStudyEntry.TabIndex = 5;
            this.btnAddStudyEntry.Text = "Add Study Entry";
            this.btnAddStudyEntry.UseVisualStyleBackColor = true;
            this.btnAddStudyEntry.Click += new System.EventHandler(this.btnAddStudyEntry_Click);
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(16, 176);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(215, 61);
            this.txtBoxNotes.TabIndex = 4;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Location = new System.Drawing.Point(16, 111);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(121, 27);
            this.txtBoxDuration.TabIndex = 3;
            // 
            // lstBoxCourses
            // 
            this.lstBoxCourses.FormattingEnabled = true;
            this.lstBoxCourses.ItemHeight = 19;
            this.lstBoxCourses.Items.AddRange(new object[] {
            "IT1510",
            "IT1600",
            "INFO1120",
            "INFO1200"});
            this.lstBoxCourses.Location = new System.Drawing.Point(252, 43);
            this.lstBoxCourses.Name = "lstBoxCourses";
            this.lstBoxCourses.Size = new System.Drawing.Size(151, 99);
            this.lstBoxCourses.TabIndex = 2;
            // 
            // grpBoxRead
            // 
            this.grpBoxRead.Controls.Add(this.btnClose);
            this.grpBoxRead.Controls.Add(this.btnSaveLog);
            this.grpBoxRead.Controls.Add(this.lstBoxStudyEntries);
            this.grpBoxRead.Controls.Add(this.label3);
            this.grpBoxRead.Location = new System.Drawing.Point(5, 252);
            this.grpBoxRead.Name = "grpBoxRead";
            this.grpBoxRead.Size = new System.Drawing.Size(409, 232);
            this.grpBoxRead.TabIndex = 3;
            this.grpBoxRead.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(252, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.AutoSize = true;
            this.btnSaveLog.Location = new System.Drawing.Point(71, 187);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(131, 29);
            this.btnSaveLog.TabIndex = 2;
            this.btnSaveLog.Text = "Save Log to File";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // lstBoxStudyEntries
            // 
            this.lstBoxStudyEntries.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxStudyEntries.FormattingEnabled = true;
            this.lstBoxStudyEntries.HorizontalScrollbar = true;
            this.lstBoxStudyEntries.ItemHeight = 18;
            this.lstBoxStudyEntries.Location = new System.Drawing.Point(7, 46);
            this.lstBoxStudyEntries.Name = "lstBoxStudyEntries";
            this.lstBoxStudyEntries.Size = new System.Drawing.Size(396, 130);
            this.lstBoxStudyEntries.TabIndex = 1;
            // 
            // StudyLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 496);
            this.Controls.Add(this.grpBoxRead);
            this.Controls.Add(this.grpBoxWrite);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudyLogForm";
            this.Text = "My Study Log";
            this.Load += new System.EventHandler(this.StudyLogForm_Load);
            this.grpBoxWrite.ResumeLayout(false);
            this.grpBoxWrite.PerformLayout();
            this.grpBoxRead.ResumeLayout(false);
            this.grpBoxRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.GroupBox grpBoxWrite;
        private System.Windows.Forms.Button btnAddStudyEntry;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.TextBox txtBoxDuration;
        private System.Windows.Forms.ListBox lstBoxCourses;
        private System.Windows.Forms.GroupBox grpBoxRead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.ListBox lstBoxStudyEntries;
    }
}