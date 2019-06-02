using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DRWallet
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        public void accountUpdate()
        {
            NavBar.nmPage = 4;
            accNavBar.NavbarUpdate();

            accFNameBox.Text = User.uFName;
            accLNameBox.Text = User.uLName;
            accEmailBox.Text = User.uEmail;

            // Language Options
            if (User.uLanguage == 1)
            {
                accAccLab.Text = DRWallet.Properties.Resources.EN_Acc_Header;
                accFNameLab.Location = new Point(218, 117);
                accFNameLab.Text = $"{DRWallet.Properties.Resources.EN_Acc_FName}:";
                accLNameLab.Location = new Point(221, 178);
                accLNameLab.Text = $"{DRWallet.Properties.Resources.EN_Acc_LName}:";
                accPasswordButton.Text = DRWallet.Properties.Resources.EN_Acc_ChangePwd;
                accSaveBox.Text = DRWallet.Properties.Resources.EN_Acc_SaveChanges;
                accLogoutBut.Text = DRWallet.Properties.Resources.EN_Acc_Logout;
            }
            else if (User.uLanguage == 2)
            {
                accAccLab.Text = DRWallet.Properties.Resources.PT_Acc_Header;
                accFNameLab.Location = new Point(156, 117);
                accFNameLab.Text = $"{DRWallet.Properties.Resources.PT_Acc_FName}:";
                accLNameLab.Location = new Point(187, 178);
                accLNameLab.Text = $"{DRWallet.Properties.Resources.PT_Acc_LName}:";
                accPasswordButton.Text = DRWallet.Properties.Resources.PT_Acc_ChangePwd;
                accSaveBox.Text = DRWallet.Properties.Resources.PT_Acc_SaveChanges;
                accLogoutBut.Text = DRWallet.Properties.Resources.PT_Acc_Logout;
            }

            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                accAccLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accFNameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accLNameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accEmailLab.ForeColor = Color.FromArgb(255, 0, 0, 0);



                accPasswordButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                accPasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                accPasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                accSaveBox.BackColor = Color.FromArgb(255, 255, 160, 66);
                accSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                accSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                accLogoutBut.BackColor = Color.FromArgb(255, 255, 160, 66);
                accLogoutBut.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                accLogoutBut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                accAccLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                accFNameLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                accLNameLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                accEmailLab.ForeColor = Color.FromArgb(255, 255, 255, 255);



                accPasswordButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                accPasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                accPasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                accSaveBox.BackColor = Color.FromArgb(255, 145, 145, 145);
                accSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                accSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                accLogoutBut.BackColor = Color.FromArgb(255, 145, 145, 145);
                accLogoutBut.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                accLogoutBut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                accAccLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accFNameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accLNameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                accEmailLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                accPasswordButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                accPasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                accPasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                accSaveBox.BackColor = Color.FromArgb(255, 220, 220, 220);
                accSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                accSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                accLogoutBut.BackColor = Color.FromArgb(255, 220, 220, 220);
                accLogoutBut.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                accLogoutBut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
            }
        }

        private void AccSaveBox_Click(object sender, EventArgs e)
        {

            if (accFNameBox.Text != "" && accLNameBox.Text != "" && accEmailBox.Text != "")
            {
                if (isEmailValid(accEmailBox.Text))
                {
                    try
                    {
                        db.Open();

                        if (accEmailBox.Text == User.uEmail)
                        {
                            MySqlCommand cmdChange = new MySqlCommand();
                            cmdChange.Connection = db;
                            cmdChange.CommandText = "UPDATE users SET userfname=@fname, userlname=@lname WHERE userid=@id";
                            cmdChange.Parameters.Add("@fname", MySqlDbType.String).Value = accFNameBox.Text;
                            cmdChange.Parameters.Add("@lname", MySqlDbType.String).Value = accLNameBox.Text;
                            cmdChange.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                            cmdChange.ExecuteNonQuery();
                            User.uFName = accFNameBox.Text;
                            User.uLName = accLNameBox.Text;
                            User.uEmail = accEmailBox.Text;

                            Logs.ChangeAccountLog(User.uID, accFNameBox.Text, accLNameBox.Text, accEmailBox.Text);
                        }
                        else
                        {
                            MySqlCommand cmds1 = new MySqlCommand();
                            cmds1.Connection = db;
                            cmds1.CommandText = "SELECT * FROM users WHERE useremail=@email";
                            cmds1.Parameters.Add("@email", MySqlDbType.String).Value = accEmailBox.Text;
                            MySqlDataReader drs1 = cmds1.ExecuteReader();
                            if (!drs1.HasRows)
                            {
                                drs1.Close();
                                MySqlCommand cmdChange = new MySqlCommand();
                                cmdChange.Connection = db;
                                cmdChange.CommandText = "UPDATE users SET userfname=@fname, userlname=@lname, useremail=@email WHERE userid=@id";
                                cmdChange.Parameters.Add("@fname", MySqlDbType.String).Value = accFNameBox.Text;
                                cmdChange.Parameters.Add("@lname", MySqlDbType.String).Value = accLNameBox.Text;
                                cmdChange.Parameters.Add("@email", MySqlDbType.String).Value = accEmailBox.Text;
                                cmdChange.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                                cmdChange.ExecuteNonQuery();
                                User.uFName = accFNameBox.Text;
                                User.uLName = accLNameBox.Text;
                                User.uEmail = accEmailBox.Text;

                                Logs.ChangeAccountLog(User.uID, accFNameBox.Text, accLNameBox.Text, accEmailBox.Text);
                            }
                            else
                            {
                                if (User.uLanguage == 1)
                                {
                                    MessageBox.Show(DRWallet.Properties.Resources.EN_Error_Emailinuse);
                                }
                                else if (User.uLanguage == 2)
                                {
                                    MessageBox.Show(DRWallet.Properties.Resources.PT_Error_Emailinuse);
                                }
                            }
                        }
                    }
                    catch
                    {
                        if (User.uLanguage == 1)
                        {
                            MessageBox.Show(DRWallet.Properties.Resources.EN_Error_Unknown);
                        }
                        else if (User.uLanguage == 2)
                        {
                            MessageBox.Show(DRWallet.Properties.Resources.PT_Error_Unknown);
                        }
                    }
                    finally
                    {
                        db.Close();
                    }
                }
                else
                {
                    if (User.uLanguage == 1)
                    {
                        MessageBox.Show(DRWallet.Properties.Resources.EN_Error_Emailinvalid);
                    }
                    else if (User.uLanguage == 2)
                    {
                        MessageBox.Show(DRWallet.Properties.Resources.PT_Error_Emailinvalid);
                    }
                }
            }
            else
            {
                if (User.uLanguage == 1)
                {
                    MessageBox.Show(DRWallet.Properties.Resources.EN_Error_Fields);
                }
                else if (User.uLanguage == 2)
                {
                    MessageBox.Show(DRWallet.Properties.Resources.PT_Error_Fields);
                }
            }
        }


        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void accPasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword npass = new ChangePassword();
            npass.changePasswordUpdate();
            npass.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User.logout();
            StopTimerFunc();
            OnLogButtonClicked();
        }

        //Goto Login
        public delegate void GotoLogEventHandler(object source, EventArgs args);
        public event GotoLogEventHandler GotoLog;

        protected virtual void OnLogButtonClicked()
        {
            if (GotoLog != null)
            {
                GotoLog(this, EventArgs.Empty);
            }
        }

        //Stop Timer
        public delegate void StopTimergEventHandler(object source, EventArgs args);
        public event StopTimergEventHandler StopTimer;

        protected virtual void StopTimerFunc()
        {
            if (StopTimer != null)
            {
                StopTimer(this, EventArgs.Empty);
            }
        }

        public bool isEmailValid(string emailaddress)
        {
            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
