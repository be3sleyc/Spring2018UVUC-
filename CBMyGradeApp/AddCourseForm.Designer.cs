namespace CBMyGradeApp
{
    partial class AddCourseForm
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
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCourseName = new System.Windows.Forms.TextBox();
            this.txtBoxSemester = new System.Windows.Forms.TextBox();
            this.txtBoxInstructor = new System.Windows.Forms.TextBox();
            this.lstBoxCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(58, 150);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(247, 34);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(125, 314);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semester:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "My Courses:";
            // 
            // txtBoxCourseName
            // 
            this.txtBoxCourseName.Location = new System.Drawing.Point(170, 46);
            this.txtBoxCourseName.Name = "txtBoxCourseName";
            this.txtBoxCourseName.Size = new System.Drawing.Size(150, 27);
            this.txtBoxCourseName.TabIndex = 0;
            // 
            // txtBoxSemester
            // 
            this.txtBoxSemester.Location = new System.Drawing.Point(170, 81);
            this.txtBoxSemester.Name = "txtBoxSemester";
            this.txtBoxSemester.Size = new System.Drawing.Size(150, 27);
            this.txtBoxSemester.TabIndex = 1;
            // 
            // txtBoxInstructor
            // 
            this.txtBoxInstructor.Location = new System.Drawing.Point(170, 116);
            this.txtBoxInstructor.Name = "txtBoxInstructor";
            this.txtBoxInstructor.Size = new System.Drawing.Size(150, 27);
            this.txtBoxInstructor.TabIndex = 2;
            // 
            // lstBoxCourses
            // 
            this.lstBoxCourses.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCourses.FormattingEnabled = true;
            this.lstBoxCourses.HorizontalScrollbar = true;
            this.lstBoxCourses.ItemHeight = 16;
            this.lstBoxCourses.Location = new System.Drawing.Point(42, 218);
            this.lstBoxCourses.Name = "lstBoxCourses";
            this.lstBoxCourses.Size = new System.Drawing.Size(278, 84);
            this.lstBoxCourses.TabIndex = 8;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.lstBoxCourses);
            this.Controls.Add(this.txtBoxInstructor);
            this.Controls.Add(this.txtBoxSemester);
            this.Controls.Add(this.txtBoxCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCourse);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourseForm";
            this.Text = "Add a Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCourseName;
        private System.Windows.Forms.TextBox txtBoxSemester;
        private System.Windows.Forms.TextBox txtBoxInstructor;
        private System.Windows.Forms.ListBox lstBoxCourses;
    }
}