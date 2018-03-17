namespace CBMyGradeApp
{
    partial class QuizTimerForm
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
            this.txtBoxTimerVal = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.rBtnCountD = new System.Windows.Forms.RadioButton();
            this.rBtnCountU = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxTimerControls = new System.Windows.Forms.GroupBox();
            this.grpBoxTimerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxTimerVal
            // 
            this.txtBoxTimerVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTimerVal.Location = new System.Drawing.Point(121, 44);
            this.txtBoxTimerVal.Name = "txtBoxTimerVal";
            this.txtBoxTimerVal.Size = new System.Drawing.Size(100, 27);
            this.txtBoxTimerVal.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 84F);
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(343, 137);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Seconds";
            // 
            // chkBoxAlarm
            // 
            this.chkBoxAlarm.AutoSize = true;
            this.chkBoxAlarm.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkBoxAlarm.Location = new System.Drawing.Point(248, 46);
            this.chkBoxAlarm.Name = "chkBoxAlarm";
            this.chkBoxAlarm.Size = new System.Drawing.Size(71, 23);
            this.chkBoxAlarm.TabIndex = 1;
            this.chkBoxAlarm.Text = "Alarm";
            this.chkBoxAlarm.UseVisualStyleBackColor = true;
            // 
            // rBtnCountD
            // 
            this.rBtnCountD.AutoSize = true;
            this.rBtnCountD.Checked = true;
            this.rBtnCountD.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rBtnCountD.Location = new System.Drawing.Point(49, 86);
            this.rBtnCountD.Name = "rBtnCountD";
            this.rBtnCountD.Size = new System.Drawing.Size(115, 23);
            this.rBtnCountD.TabIndex = 2;
            this.rBtnCountD.TabStop = true;
            this.rBtnCountD.Text = "Count Down";
            this.rBtnCountD.UseVisualStyleBackColor = true;
            // 
            // rBtnCountU
            // 
            this.rBtnCountU.AutoSize = true;
            this.rBtnCountU.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rBtnCountU.Location = new System.Drawing.Point(170, 86);
            this.rBtnCountU.Name = "rBtnCountU";
            this.rBtnCountU.Size = new System.Drawing.Size(94, 23);
            this.rBtnCountU.TabIndex = 3;
            this.rBtnCountU.Text = "Count Up";
            this.rBtnCountU.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStart.Location = new System.Drawing.Point(10, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(242, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBoxTimerControls
            // 
            this.grpBoxTimerControls.Controls.Add(this.label2);
            this.grpBoxTimerControls.Controls.Add(this.txtBoxTimerVal);
            this.grpBoxTimerControls.Controls.Add(this.btnClose);
            this.grpBoxTimerControls.Controls.Add(this.chkBoxAlarm);
            this.grpBoxTimerControls.Controls.Add(this.btnStart);
            this.grpBoxTimerControls.Controls.Add(this.rBtnCountD);
            this.grpBoxTimerControls.Controls.Add(this.rBtnCountU);
            this.grpBoxTimerControls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTimerControls.Location = new System.Drawing.Point(10, 157);
            this.grpBoxTimerControls.Name = "grpBoxTimerControls";
            this.grpBoxTimerControls.Size = new System.Drawing.Size(346, 175);
            this.grpBoxTimerControls.TabIndex = 7;
            this.grpBoxTimerControls.TabStop = false;
            this.grpBoxTimerControls.Text = "Timer Controls";
            // 
            // QuizTimerForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 352);
            this.Controls.Add(this.grpBoxTimerControls);
            this.Controls.Add(this.lblTimer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuizTimerForm";
            this.Text = "QuizTimerForm";
            this.grpBoxTimerControls.ResumeLayout(false);
            this.grpBoxTimerControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTimerVal;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBoxAlarm;
        private System.Windows.Forms.RadioButton rBtnCountD;
        private System.Windows.Forms.RadioButton rBtnCountU;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxTimerControls;
    }
}