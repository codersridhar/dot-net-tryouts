namespace AttendanceApplication
{
    partial class AdminAuth
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
            this.AdminAuthPasscdLbl = new System.Windows.Forms.Label();
            this.AdminAuthCnfrmPasscdLbl = new System.Windows.Forms.Label();
            this.AdminAuthPasswdTextBox = new System.Windows.Forms.TextBox();
            this.AdminAuthCnfrmPasscdTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AdminAuthToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminAuthPasscdLbl
            // 
            this.AdminAuthPasscdLbl.AutoSize = true;
            this.AdminAuthPasscdLbl.Location = new System.Drawing.Point(63, 28);
            this.AdminAuthPasscdLbl.Name = "AdminAuthPasscdLbl";
            this.AdminAuthPasscdLbl.Size = new System.Drawing.Size(54, 13);
            this.AdminAuthPasscdLbl.TabIndex = 0;
            this.AdminAuthPasscdLbl.Text = "Passcode";
            // 
            // AdminAuthCnfrmPasscdLbl
            // 
            this.AdminAuthCnfrmPasscdLbl.AutoSize = true;
            this.AdminAuthCnfrmPasscdLbl.Location = new System.Drawing.Point(25, 63);
            this.AdminAuthCnfrmPasscdLbl.Name = "AdminAuthCnfrmPasscdLbl";
            this.AdminAuthCnfrmPasscdLbl.Size = new System.Drawing.Size(92, 13);
            this.AdminAuthCnfrmPasscdLbl.TabIndex = 1;
            this.AdminAuthCnfrmPasscdLbl.Text = "Confirm Passcode";
            // 
            // AdminAuthPasswdTextBox
            // 
            this.AdminAuthPasswdTextBox.Location = new System.Drawing.Point(123, 25);
            this.AdminAuthPasswdTextBox.Name = "AdminAuthPasswdTextBox";
            this.AdminAuthPasswdTextBox.PasswordChar = '#';
            this.AdminAuthPasswdTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminAuthPasswdTextBox.TabIndex = 2;
            this.AdminAuthPasswdTextBox.TextChanged += new System.EventHandler(this.AdminAuthPasscdTextBox_TextChanged);
            this.AdminAuthPasswdTextBox.Enter += new System.EventHandler(this.AdminAuthPasscdTextBox_Enter);
            // 
            // AdminAuthCnfrmPasscdTextBox
            // 
            this.AdminAuthCnfrmPasscdTextBox.Location = new System.Drawing.Point(124, 60);
            this.AdminAuthCnfrmPasscdTextBox.Name = "AdminAuthCnfrmPasscdTextBox";
            this.AdminAuthCnfrmPasscdTextBox.PasswordChar = '#';
            this.AdminAuthCnfrmPasscdTextBox.Size = new System.Drawing.Size(99, 20);
            this.AdminAuthCnfrmPasscdTextBox.TabIndex = 3;
            this.AdminAuthCnfrmPasscdTextBox.Enter += new System.EventHandler(this.AdminAuthCnfrmPasscdTextBox_Enter);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(42, 106);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(147, 106);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 5;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminAuthToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 151);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AdminAuthToolStripStatusLabel
            // 
            this.AdminAuthToolStripStatusLabel.Name = "AdminAuthToolStripStatusLabel";
            this.AdminAuthToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // AdminAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.AdminAuthCnfrmPasscdTextBox);
            this.Controls.Add(this.AdminAuthPasswdTextBox);
            this.Controls.Add(this.AdminAuthCnfrmPasscdLbl);
            this.Controls.Add(this.AdminAuthPasscdLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminAuth";
            this.Text = "Admin Authenticate Console";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminAuthPasscdLbl;
        private System.Windows.Forms.Label AdminAuthCnfrmPasscdLbl;
        private System.Windows.Forms.TextBox AdminAuthPasswdTextBox;
        private System.Windows.Forms.TextBox AdminAuthCnfrmPasscdTextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AdminAuthToolStripStatusLabel;
    }
}