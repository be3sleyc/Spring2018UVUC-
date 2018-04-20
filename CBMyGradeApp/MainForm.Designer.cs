namespace CBMyGradeApp
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStudentProfile = new System.Windows.Forms.Button();
            this.btnScoringMethods = new System.Windows.Forms.Button();
            this.btnLetterGrade = new System.Windows.Forms.Button();
            this.btnQuizTimer = new System.Windows.Forms.Button();
            this.btnStudyLog = new System.Windows.Forms.Button();
            this.btnGradingMethods = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnGPAForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Christian\'s Grades";
            // 
            // btnWelcome
            // 
            this.btnWelcome.AutoSize = true;
            this.btnWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcome.Location = new System.Drawing.Point(225, 7);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(83, 29);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(348, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStudentProfile
            // 
            this.btnStudentProfile.AutoSize = true;
            this.btnStudentProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentProfile.Location = new System.Drawing.Point(33, 51);
            this.btnStudentProfile.Name = "btnStudentProfile";
            this.btnStudentProfile.Size = new System.Drawing.Size(123, 29);
            this.btnStudentProfile.TabIndex = 1;
            this.btnStudentProfile.Text = "Student Profile";
            this.btnStudentProfile.UseVisualStyleBackColor = true;
            this.btnStudentProfile.Click += new System.EventHandler(this.btnStudentProfile_Click);
            // 
            // btnScoringMethods
            // 
            this.btnScoringMethods.AutoSize = true;
            this.btnScoringMethods.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoringMethods.Location = new System.Drawing.Point(20, 101);
            this.btnScoringMethods.Name = "btnScoringMethods";
            this.btnScoringMethods.Size = new System.Drawing.Size(136, 29);
            this.btnScoringMethods.TabIndex = 3;
            this.btnScoringMethods.Text = "Scoring Methods";
            this.btnScoringMethods.UseVisualStyleBackColor = true;
            this.btnScoringMethods.Click += new System.EventHandler(this.btnScoringMethods_Click);
            // 
            // btnLetterGrade
            // 
            this.btnLetterGrade.AutoSize = true;
            this.btnLetterGrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterGrade.Location = new System.Drawing.Point(178, 51);
            this.btnLetterGrade.Name = "btnLetterGrade";
            this.btnLetterGrade.Size = new System.Drawing.Size(106, 29);
            this.btnLetterGrade.TabIndex = 2;
            this.btnLetterGrade.Text = "Letter Grade";
            this.btnLetterGrade.UseVisualStyleBackColor = true;
            this.btnLetterGrade.Click += new System.EventHandler(this.btnLetterGrade_Click);
            // 
            // btnQuizTimer
            // 
            this.btnQuizTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizTimer.Location = new System.Drawing.Point(178, 101);
            this.btnQuizTimer.Name = "btnQuizTimer";
            this.btnQuizTimer.Size = new System.Drawing.Size(119, 29);
            this.btnQuizTimer.TabIndex = 4;
            this.btnQuizTimer.Text = "Quiz Timer";
            this.btnQuizTimer.UseVisualStyleBackColor = true;
            this.btnQuizTimer.Click += new System.EventHandler(this.btnQuizTimer_Click);
            // 
            // btnStudyLog
            // 
            this.btnStudyLog.AutoSize = true;
            this.btnStudyLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudyLog.Location = new System.Drawing.Point(60, 151);
            this.btnStudyLog.Name = "btnStudyLog";
            this.btnStudyLog.Size = new System.Drawing.Size(96, 29);
            this.btnStudyLog.TabIndex = 5;
            this.btnStudyLog.Text = "Study Log";
            this.btnStudyLog.UseVisualStyleBackColor = true;
            this.btnStudyLog.Click += new System.EventHandler(this.btnStudyLog_Click);
            // 
            // btnGradingMethods
            // 
            this.btnGradingMethods.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGradingMethods.Location = new System.Drawing.Point(178, 151);
            this.btnGradingMethods.Name = "btnGradingMethods";
            this.btnGradingMethods.Size = new System.Drawing.Size(142, 29);
            this.btnGradingMethods.TabIndex = 6;
            this.btnGradingMethods.Text = "Grading Methods";
            this.btnGradingMethods.UseVisualStyleBackColor = true;
            this.btnGradingMethods.Click += new System.EventHandler(this.btnGradingMethods_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddCourse.Location = new System.Drawing.Point(46, 201);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(110, 29);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnGPAForm
            // 
            this.btnGPAForm.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGPAForm.Location = new System.Drawing.Point(178, 201);
            this.btnGPAForm.Name = "btnGPAForm";
            this.btnGPAForm.Size = new System.Drawing.Size(110, 29);
            this.btnGPAForm.TabIndex = 8;
            this.btnGPAForm.Text = "My GPA";
            this.btnGPAForm.UseVisualStyleBackColor = true;
            this.btnGPAForm.Click += new System.EventHandler(this.btnGPAForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(435, 243);
            this.Controls.Add(this.btnGPAForm);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnGradingMethods);
            this.Controls.Add(this.btnQuizTimer);
            this.Controls.Add(this.btnLetterGrade);
            this.Controls.Add(this.btnStudyLog);
            this.Controls.Add(this.btnScoringMethods);
            this.Controls.Add(this.btnStudentProfile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "My Grade App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStudentProfile;
        private System.Windows.Forms.Button btnScoringMethods;
        private System.Windows.Forms.Button btnLetterGrade;
        private System.Windows.Forms.Button btnQuizTimer;
        private System.Windows.Forms.Button btnStudyLog;
        private System.Windows.Forms.Button btnGradingMethods;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnGPAForm;
    }
}

