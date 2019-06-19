using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AttendanceApplication
{
    public partial class AdminConsole : Form
    {
        public AdminConsole()
        {
            InitializeComponent();
        }

        public bool GetLoginMode()
        {
            if (LoginRadioButton.Checked == true)
            {
                return true;
            }
            return false;
        }

        public void LoadTraineeInfo(string filePath)
        {
            if (!File.Exists(Constants.empAllFile))
            {
                File.Copy(filePath, Constants.empAllFile, true);
            }
        }

        private void LoadTraineesButton_Click(object sender, EventArgs e)
        {
            bool loadData = true;

            if (File.Exists(Constants.empAllFile))
            {
                const string message =
                    "Employee data loaded. Do you want to reload?";
                const string caption = "Reload Data";

                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    loadData = false;
                }
                else
                {
                    File.Delete(Constants.empAllFile);
                }
            }

            if (loadData == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    LoadTraineeInfo(filePath);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TraineeOps_Click(object sender, EventArgs e)
        {

        }
    }
}
