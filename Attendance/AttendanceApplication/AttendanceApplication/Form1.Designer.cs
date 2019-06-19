namespace AttendanceApplication
{
    partial class TrainingAttendanceMain
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.TraineeButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(60, 31);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(145, 42);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // TraineeButton
            // 
            this.TraineeButton.Location = new System.Drawing.Point(260, 31);
            this.TraineeButton.Name = "TraineeButton";
            this.TraineeButton.Size = new System.Drawing.Size(145, 42);
            this.TraineeButton.TabIndex = 0;
            this.TraineeButton.Text = "Trainee";
            this.TraineeButton.UseVisualStyleBackColor = true;
            this.TraineeButton.Click += new System.EventHandler(this.TraineeButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.Location = new System.Drawing.Point(159, 109);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(145, 42);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // TrainingAttendanceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(474, 182);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.TraineeButton);
            this.Controls.Add(this.AdminButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingAttendanceMain";
            this.Text = "Tranining Attendance";

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button TraineeButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

