namespace CBMyGradeApp
{
    partial class StudentProfileForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblPrefEmail = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxMajor = new System.Windows.Forms.TextBox();
            this.txtBoxPrefEmail = new System.Windows.Forms.TextBox();
            this.btnCloseStudentProfForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(43, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(45, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 19);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(79, 88);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(49, 19);
            this.lblMajor.TabIndex = 2;
            this.lblMajor.Text = "Major";
            // 
            // lblPrefEmail
            // 
            this.lblPrefEmail.AutoSize = true;
            this.lblPrefEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefEmail.Location = new System.Drawing.Point(10, 124);
            this.lblPrefEmail.Name = "lblPrefEmail";
            this.lblPrefEmail.Size = new System.Drawing.Size(118, 19);
            this.lblPrefEmail.TabIndex = 3;
            this.lblPrefEmail.Text = "Preferred Email";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxFirstName.Location = new System.Drawing.Point(135, 26);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 24);
            this.txtBoxFirstName.TabIndex = 4;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxLastName.Location = new System.Drawing.Point(134, 59);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 24);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // txtBoxMajor
            // 
            this.txtBoxMajor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxMajor.Location = new System.Drawing.Point(134, 90);
            this.txtBoxMajor.Name = "txtBoxMajor";
            this.txtBoxMajor.Size = new System.Drawing.Size(100, 24);
            this.txtBoxMajor.TabIndex = 4;
            // 
            // txtBoxPrefEmail
            // 
            this.txtBoxPrefEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxPrefEmail.Location = new System.Drawing.Point(134, 123);
            this.txtBoxPrefEmail.Name = "txtBoxPrefEmail";
            this.txtBoxPrefEmail.Size = new System.Drawing.Size(100, 24);
            this.txtBoxPrefEmail.TabIndex = 4;
            // 
            // btnCloseStudentProfForm
            // 
            this.btnCloseStudentProfForm.AutoSize = true;
            this.btnCloseStudentProfForm.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCloseStudentProfForm.Location = new System.Drawing.Point(158, 188);
            this.btnCloseStudentProfForm.Name = "btnCloseStudentProfForm";
            this.btnCloseStudentProfForm.Size = new System.Drawing.Size(75, 29);
            this.btnCloseStudentProfForm.TabIndex = 5;
            this.btnCloseStudentProfForm.Text = "Close";
            this.btnCloseStudentProfForm.UseVisualStyleBackColor = true;
            this.btnCloseStudentProfForm.Click += new System.EventHandler(this.btnCloseStudentProfForm_Click);
            // 
            // StudentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 227);
            this.Controls.Add(this.btnCloseStudentProfForm);
            this.Controls.Add(this.txtBoxPrefEmail);
            this.Controls.Add(this.txtBoxMajor);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblPrefEmail);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "StudentProfileForm";
            this.Text = "Student Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblPrefEmail;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxMajor;
        private System.Windows.Forms.TextBox txtBoxPrefEmail;
        private System.Windows.Forms.Button btnCloseStudentProfForm;
    }
}