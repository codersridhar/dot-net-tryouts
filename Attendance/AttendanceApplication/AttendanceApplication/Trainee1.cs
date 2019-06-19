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
    public partial class TraineeLoginConsole : Form
    {
        public TraineeLoginConsole()
        {
            InitializeComponent();
        }

        public void SetLoginOrLogOutButtonText(string text)
        {
            LoginOrLogOut.Text = text;
            bool isLogin = true;

            if (text.Equals("Logout"))
            {
                isLogin = false;

                PINConfirmTextBox.Visible = false;
                ConfirmPINLabel.Visible = false;
            }

            NameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection trainees = new AutoCompleteStringCollection();

            string filePath = "";

            if (isLogin == true)
            {
                filePath = Constants.empAllFile;
            }
            else
            {
                filePath = Constants.empLoginFile;

                if (!File.Exists(filePath))
                {
                    //MessageBox.Show("No login data found", "Login Doesn't exists", MessageBoxButtons.OK,
                    //                    MessageBoxIcon.Stop);
                    //LoginOrLogOut.Enabled = false;

                    TraineeToolStripStatusLabel.Text = "No login data found";
                }
            }

            if (File.Exists(filePath))
            {
                foreach (string aline in File.ReadLines(filePath))
                {
                    string[] fields = aline.Split(',').ToArray();

                    if (isLogin == true)
                    {
                        trainees.Add(fields[0] + " [" + fields[1] + "]");
                    }
                    else
                    {
                        trainees.Add(fields[0]);
                    }
                }
                NameTextBox.AutoCompleteCustomSource = trainees;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginOrLogOut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text) ||
                String.IsNullOrEmpty(PINTextBox.Text)  ||
                (LoginOrLogOut.Text.Equals("Login") && String.IsNullOrEmpty(PINConfirmTextBox.Text)))
            {
                //const string message = "Fields cannot be blank";
                //const string caption = "Caution";

                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.OK,
                //                             MessageBoxIcon.Exclamation);

                TraineeToolStripStatusLabel.Text = "Fields cannot be blank";
                return;
            }

            if (PINTextBox.Text.Length < 4 ||
                     (LoginOrLogOut.Text.Equals("Login") && PINConfirmTextBox.Text.Length < 4))
            {
                //const string message = "Passwords atleast 4 characters";
                //const string caption = "Caution";

                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.OK,
                //                             MessageBoxIcon.Exclamation);
                TraineeToolStripStatusLabel.Text = "Passcodes atleast 4 characters";
                return;
            }


            if (!String.IsNullOrEmpty(NameTextBox.Text) && (
                NameTextBox.Text.IndexOf('[') < 0 || NameTextBox.Text.IndexOf(']') < 0))
            {
                //MessageBox.Show("Fictional User?", "Invalid User", MessageBoxButtons.OK,
                //                MessageBoxIcon.Exclamation);
                TraineeToolStripStatusLabel.Text = "Fictional User?";
                return;
            }

            if (LoginOrLogOut.Text.Equals("Login"))
            {
                string loginFilePath = Constants.empLoginFile;
                bool logTraineeIn = false;

                if (File.Exists(loginFilePath))
                {
                    string[] readText = File.ReadAllLines(loginFilePath);

                    foreach (string s in readText)
                    {
                        string[] fields = s.Split(',').ToArray();

                        if (String.Compare(NameTextBox.Text, fields[0], true) == 0)
                        {
                            logTraineeIn = true;
                            break;
                        }
                    }
                }

                if (logTraineeIn == true)
                {
                    //MessageBox.Show(NameTextBox.Text + " has already logged-in", "Login Exists", MessageBoxButtons.OK,
                    //                MessageBoxIcon.Information);
                    TraineeToolStripStatusLabel.Text = NameTextBox.Text + " has already logged-in";
                }
                else
                {
                    if (String.Compare(PINTextBox.Text, PINConfirmTextBox.Text, false) == 0)
                    {
                        DateTime localDate = DateTime.Now;

                        File.AppendAllText(loginFilePath, NameTextBox.Text + "," +
                                           //PINTextBox.Text + "," +
                                           CryptoEngine.Encrypt(PINTextBox.Text, Constants.cryptoKey) + "," +
                                           localDate.Ticks +
                                           Environment.NewLine);

                        //MessageBox.Show("Your login time: "+localDate.ToString("t"), "Login Time", MessageBoxButtons.OK,
                        //            MessageBoxIcon.Information);

                        TraineeToolStripStatusLabel.Text = NameTextBox.Text + " logged-in at " + localDate.ToString("t");

                        NameTextBox.Clear();
                        PINTextBox.Clear();
                        PINConfirmTextBox.Clear();
                    }
                    else
                    {
                        //const string message = "Passcodes mismatch";
                        //const string caption = "Caution";

                        //MessageBox.Show(message, caption, MessageBoxButtons.OK,
                        //                MessageBoxIcon.Exclamation);

                        TraineeToolStripStatusLabel.Text = "Passcodes mismatch";
                        PINTextBox.Clear();
                        PINConfirmTextBox.Clear();
                    }
                }
            }
            else // Logout case
            {
                string logoutFilePath = Constants.empLogoutFile;
                string[] readText = File.ReadAllLines(Constants.empLoginFile);

                DateTime localDate = DateTime.Now;

                foreach (string s in readText)
                {
                    string[] fields = s.Split(',').ToArray();

                    if (String.Compare(NameTextBox.Text, fields[0], true) == 0)    
                    {
                        MessageBox.Show(fields[0] + " " + fields[1]);
                        if (String.Compare(PINTextBox.Text, CryptoEngine.Decrypt(fields[1], Constants.cryptoKey), false) == 0)
                        {
                            string[] tokens = fields[0].Split('[').ToArray();
                            string emp_id = tokens[1].Trim(']');
                            string emp_name = tokens[0].Trim();

                            File.AppendAllText(logoutFilePath, emp_id + "," + emp_name + "," +
                                               new TimeSpan(localDate.Ticks - Convert.ToInt64(fields[2])).ToString(@"hh\:mm\:ss") +
                                               Environment.NewLine);

                            //MessageBox.Show(emp_name + " has logged out", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);                            

                            TraineeToolStripStatusLabel.Text = NameTextBox.Text + " logged-out at " + localDate.ToString("t");
                            NameTextBox.Clear();
                            PINTextBox.Clear();
                        }
                        else
                        {
                            //MessageBox.Show("Wrong PIN", "Error",
                            //                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TraineeToolStripStatusLabel.Text = "Wrong PIN";
                            PINTextBox.Clear();
                        }
                        break;
                    }
                }
            }
        }

        private void PINTextBox_Enter(object sender, EventArgs e)
        {
            PINTextBox.SelectAll();
        }

        private void PINConfirmTextBox_Enter(object sender, EventArgs e)
        {
            PINConfirmTextBox.SelectAll();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            PINTextBox.Clear();
            PINConfirmTextBox.Clear();
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            NameTextBox.SelectAll();
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {

        }
    }
}
