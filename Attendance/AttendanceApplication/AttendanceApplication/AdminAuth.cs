using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AttendanceApplication
{
    public partial class AdminAuth : Form
    {
        bool confirmPassd = true;

        public AdminAuth(bool value)
        {
            InitializeComponent();

            if (value == false)
            {
                confirmPassd = false;
                AdminAuthCnfrmPasscdLbl.Visible = false;
                AdminAuthCnfrmPasscdTextBox.Visible = false;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AdminAuthPasswdTextBox.Text) ||
                (confirmPassd == true && String.IsNullOrEmpty(AdminAuthCnfrmPasscdTextBox.Text)))
            {
                AdminAuthToolStripStatusLabel.Text = "Fields cannot be blank";
                AdminAuthPasswdTextBox.Clear();
                AdminAuthCnfrmPasscdTextBox.Clear();
            }
            else if (AdminAuthPasswdTextBox.Text.Length < 4 || 
                (confirmPassd == true && AdminAuthCnfrmPasscdTextBox.Text.Length < 4))
            {
                AdminAuthToolStripStatusLabel.Text = "Passcodes atleast 4 characters";
                AdminAuthPasswdTextBox.Clear();
                AdminAuthCnfrmPasscdTextBox.Clear();
            }
            else if (confirmPassd == true)
            {
                if (String.Compare(AdminAuthPasswdTextBox.Text, AdminAuthCnfrmPasscdTextBox.Text, false) != 0)
                {
                    AdminAuthToolStripStatusLabel.Text = "Passcodes mismatch";
                    AdminAuthPasswdTextBox.Clear();
                    AdminAuthCnfrmPasscdTextBox.Clear();
                }
                else
                {
                    File.WriteAllText(Constants.adminInfoFile,
                                        CryptoEngine.Encrypt(AdminAuthPasswdTextBox.Text, Constants.cryptoKey));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                string[] readText = File.ReadAllLines(Constants.adminInfoFile);

                if (String.Compare(AdminAuthPasswdTextBox.Text, 
                    CryptoEngine.Decrypt(readText[0], Constants.cryptoKey), false) == 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    AdminAuthToolStripStatusLabel.Text = "Passcodes mismatch";
                    AdminAuthPasswdTextBox.Clear();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminAuthPasscdTextBox_Enter(object sender, EventArgs e)
        {
            AdminAuthPasswdTextBox.SelectAll();
        }

        private void AdminAuthCnfrmPasscdTextBox_Enter(object sender, EventArgs e)
        {
            AdminAuthCnfrmPasscdTextBox.SelectAll();
        }

        private void AdminAuthPasscdTextBox_TextChanged(object sender, EventArgs e)
        {
            AdminAuthCnfrmPasscdTextBox.Clear();
        }
    }
}
