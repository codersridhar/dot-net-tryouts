namespace AttendanceApplication
{
    partial class TraineeLoginConsole
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginOrLogOut = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PINConfirmTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPINLabel = new System.Windows.Forms.Label();
            this.TraineeStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TraineeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TraineeStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(77, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(361, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // LoginOrLogOut
            // 
            this.LoginOrLogOut.Location = new System.Drawing.Point(81, 126);
            this.LoginOrLogOut.Name = "LoginOrLogOut";
            this.LoginOrLogOut.Size = new System.Drawing.Size(145, 42);
            this.LoginOrLogOut.TabIndex = 3;
            this.LoginOrLogOut.Text = "Login";
            this.LoginOrLogOut.UseVisualStyleBackColor = true;
            this.LoginOrLogOut.Click += new System.EventHandler(this.LoginOrLogOut_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(262, 126);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 42);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PINTextBox
            // 
            this.PINTextBox.Location = new System.Drawing.Point(77, 66);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.PasswordChar = '#';
            this.PINTextBox.Size = new System.Drawing.Size(120, 20);
            this.PINTextBox.TabIndex = 1;
            this.PINTextBox.Enter += new System.EventHandler(this.PINTextBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passcode";
            // 
            // PINConfirmTextBox
            // 
            this.PINConfirmTextBox.Location = new System.Drawing.Point(318, 69);
            this.PINConfirmTextBox.Name = "PINConfirmTextBox";
            this.PINConfirmTextBox.PasswordChar = '#';
            this.PINConfirmTextBox.Size = new System.Drawing.Size(120, 20);
            this.PINConfirmTextBox.TabIndex = 2;
            this.PINConfirmTextBox.Enter += new System.EventHandler(this.PINConfirmTextBox_Enter);
            // 
            // ConfirmPINLabel
            // 
            this.ConfirmPINLabel.AutoSize = true;
            this.ConfirmPINLabel.Location = new System.Drawing.Point(220, 69);
            this.ConfirmPINLabel.Name = "ConfirmPINLabel";
            this.ConfirmPINLabel.Size = new System.Drawing.Size(92, 13);
            this.ConfirmPINLabel.TabIndex = 1;
            this.ConfirmPINLabel.Text = "Confirm Passcode";
            // 
            // TraineeStatusStrip
            // 
            this.TraineeStatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.TraineeStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TraineeToolStripStatusLabel});
            this.TraineeStatusStrip.Location = new System.Drawing.Point(0, 170);
            this.TraineeStatusStrip.Name = "TraineeStatusStrip";
            this.TraineeStatusStrip.Size = new System.Drawing.Size(484, 22);
            this.TraineeStatusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TraineeToolStripStatusLabel
            // 
            this.TraineeToolStripStatusLabel.Name = "TraineeToolStripStatusLabel";
            this.TraineeToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TraineeLoginConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 192);
            this.Controls.Add(this.TraineeStatusStrip);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LoginOrLogOut);
            this.Controls.Add(this.ConfirmPINLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PINConfirmTextBox);
            this.Controls.Add(this.PINTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraineeLoginConsole";
            this.Text = "Trainee Login Console";
            this.TraineeStatusStrip.ResumeLayout(false);
            this.TraineeStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginOrLogOut;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PINConfirmTextBox;
        private System.Windows.Forms.Label ConfirmPINLabel;
        private System.Windows.Forms.StatusStrip TraineeStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TraineeToolStripStatusLabel;
    }
}