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
    public partial class TrainingAttendanceMain : Form
    {
        AdminConsole adminConsole = new AdminConsole();

        public TrainingAttendanceMain()
        {
            InitializeComponent();

            if (File.Exists(Constants.empAllFile))
            {
                adminConsole.LoadTraineeInfo(Constants.empAllFile);
            }
            if (File.Exists(Constants.empLoginFile))
            {
                File.Delete(Constants.empLoginFile);
            }
            if (File.Exists(Constants.empLogoutFile))
            {
                File.Delete(Constants.empLogoutFile);
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Constants.adminInfoFile))
            {
                AdminAuth adminAuth = new AdminAuth(false);

                var result = adminAuth.ShowDialog();

                if (result == DialogResult.OK)
                {
                    adminConsole.Show();
                }
            }
            else
            {
                var result = MessageBox.Show(
                                "Passcode for Admin doesn't exists. Want to create now?",
                                "Admin Passcode", MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    AdminAuth adminAuth = new AdminAuth(true);

                    result = adminAuth.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        adminConsole.Show();
                    }
                }
            }            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the application?";
            const string caption = "Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TraineeButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Constants.empAllFile))
            {
                const string message =
                    "Employee data not loaded. Load through Admin Console";
                const string caption = "Caution";

                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Stop);
            }
            else
            {
                TraineeLoginConsole traineeConsole = new TraineeLoginConsole();

                if (adminConsole.GetLoginMode() == true)
                {
                    traineeConsole.SetLoginOrLogOutButtonText("Login");
                }
                else
                {
                    traineeConsole.SetLoginOrLogOutButtonText("Logout");
                }

                traineeConsole.Show();
            }

            /*
             *             Hashtable ht = adminConsole.GetTraineeInfo();

            ICollection keys = ht.Keys;

            foreach (String k in keys)
            {
                MessageBox.Show(k + "==>" + ht[k].ToString());
            }

             * string[] readText = File.ReadAllLines(@"C:\Users\surya.sridhar\Downloads\sgzemps.txt");

            foreach (string s in readText)
            {
                MessageBox.Show(s);
            }
             */
        }
    }
}