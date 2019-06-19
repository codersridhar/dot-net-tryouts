namespace AttendanceApplication
{
    partial class AdminConsole
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
            this.LoadTraineesButton = new System.Windows.Forms.Button();
            this.AddTraineeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LoginRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoutRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.LogoutTraineeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadTraineesButton
            // 
            this.LoadTraineesButton.Location = new System.Drawing.Point(26, 28);
            this.LoadTraineesButton.Name = "LoadTraineesButton";
            this.LoadTraineesButton.Size = new System.Drawing.Size(125, 40);
            this.LoadTraineesButton.TabIndex = 1;
            this.LoadTraineesButton.Text = "Load Trainees";
            this.LoadTraineesButton.UseVisualStyleBackColor = true;
            this.LoadTraineesButton.Click += new System.EventHandler(this.LoadTraineesButton_Click);
            // 
            // AddTraineeButton
            // 
            this.AddTraineeButton.Location = new System.Drawing.Point(175, 28);
            this.AddTraineeButton.Name = "AddTraineeButton";
            this.AddTraineeButton.Size = new System.Drawing.Size(125, 40);
            this.AddTraineeButton.TabIndex = 1;
            this.AddTraineeButton.Text = "Add Trainee";
            this.AddTraineeButton.UseVisualStyleBackColor = true;
            this.AddTraineeButton.Click += new System.EventHandler(this.TraineeOps_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(336, 107);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 42);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoginRadioButton
            // 
            this.LoginRadioButton.AutoSize = true;
            this.LoginRadioButton.Checked = true;
            this.LoginRadioButton.Location = new System.Drawing.Point(14, 21);
            this.LoginRadioButton.Name = "LoginRadioButton";
            this.LoginRadioButton.Size = new System.Drawing.Size(51, 17);
            this.LoginRadioButton.TabIndex = 3;
            this.LoginRadioButton.TabStop = true;
            this.LoginRadioButton.Text = "Login";
            this.LoginRadioButton.UseVisualStyleBackColor = true;
            // 
            // LogoutRadioButton
            // 
            this.LogoutRadioButton.AutoSize = true;
            this.LogoutRadioButton.Location = new System.Drawing.Point(67, 21);
            this.LogoutRadioButton.Name = "LogoutRadioButton";
            this.LogoutRadioButton.Size = new System.Drawing.Size(58, 17);
            this.LogoutRadioButton.TabIndex = 3;
            this.LogoutRadioButton.Text = "Logout";
            this.LogoutRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogoutRadioButton);
            this.groupBox1.Controls.Add(this.LoginRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(175, 107);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(125, 40);
            this.GenerateReportButton.TabIndex = 5;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // LogoutTraineeButton
            // 
            this.LogoutTraineeButton.Location = new System.Drawing.Point(336, 28);
            this.LogoutTraineeButton.Name = "LogoutTraineeButton";
            this.LogoutTraineeButton.Size = new System.Drawing.Size(125, 40);
            this.LogoutTraineeButton.TabIndex = 6;
            this.LogoutTraineeButton.Text = "Logout Trainee";
            this.LogoutTraineeButton.UseVisualStyleBackColor = true;
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 182);
            this.Controls.Add(this.LogoutTraineeButton);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddTraineeButton);
            this.Controls.Add(this.LoadTraineesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminConsole";
            this.Text = "Admin Console";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadTraineesButton;
        private System.Windows.Forms.Button AddTraineeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton LoginRadioButton;
        private System.Windows.Forms.RadioButton LogoutRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Button LogoutTraineeButton;
    }
}