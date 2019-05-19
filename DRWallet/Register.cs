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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LogRegisterBox_Click(object sender, EventArgs e)
        {
            registProcess();
        }

        private void Register_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registProcess();
            }
        }

        private void registProcess()
        {
            if (regFNameBox.Text != "" && regLNameBox.Text != "" && regUserBox.Text != "" && regEmailBox.Text != "" && regPassBox.Text != "" && regConfPassBox.Text != "")
            {
                if (isEmailValid(regEmailBox.Text))
                {
                    if (regPassBox.Text == regConfPassBox.Text)
                    {
                        //Database verify
                        try
                        {
                            db.Open();

                            MySqlCommand cmds1 = new MySqlCommand();
                            cmds1.Connection = db;
                            cmds1.CommandText = "SELECT * FROM users WHERE userusername=@username";
                            cmds1.Parameters.Add("@username", MySqlDbType.String).Value = regUserBox.Text;
                            MySqlDataReader drs1 = cmds1.ExecuteReader();
                            if (!drs1.HasRows)
                            {
                                drs1.Close();
                                MySqlCommand cmds2 = new MySqlCommand();
                                cmds2.Connection = db;
                                cmds2.CommandText = "SELECT * FROM users WHERE useremail=@email";
                                cmds2.Parameters.Add("@email", MySqlDbType.String).Value = regEmailBox.Text;
                                MySqlDataReader drs2 = cmds2.ExecuteReader();
                                if (!drs2.HasRows)
                                {
                                    drs2.Close();
                                    MySqlCommand cmdInsert = new MySqlCommand();
                                    cmdInsert.Connection = db;
                                    cmdInsert.CommandText = "INSERT INTO users (userusername,userpassword,userfname,userlname,useremail) VALUES (@user,@pass,@fname,@lname,@email)";
                                    cmdInsert.Parameters.Add("@user", MySqlDbType.String).Value = regUserBox.Text;
                                    cmdInsert.Parameters.Add("@pass", MySqlDbType.String).Value = regPassBox.Text;
                                    cmdInsert.Parameters.Add("@fname", MySqlDbType.String).Value = regFNameBox.Text;
                                    cmdInsert.Parameters.Add("@lname", MySqlDbType.String).Value = regLNameBox.Text;
                                    cmdInsert.Parameters.Add("@email", MySqlDbType.String).Value = regEmailBox.Text;
                                    int numbers = cmdInsert.ExecuteNonQuery();
                                    if (numbers == 1)
                                    {
                                        regErrorLab.Location = new Point(250, 290);
                                        regErrorLab.Text = "Successfully registered!";
                                        regErrorLab.Visible = true;

                                        Logs.AddRegisterLog(regUserBox.Text);

                                        OnButtonClicked();
                                    }
                                    else
                                    {
                                        regErrorLab.Location = new Point(260, 290);
                                        regErrorLab.Text = "Something went wrong!";
                                        regErrorLab.Visible = true;
                                    }
                                }
                                else
                                {
                                    regErrorLab.Location = new Point(250, 290);
                                    regErrorLab.Text = "Email already in use!";
                                    regErrorLab.Visible = true;
                                }
                            }
                            else
                            {
                                regErrorLab.Location = new Point(242, 290);
                                regErrorLab.Text = "Username already in use!";
                                regErrorLab.Visible = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            regErrorLab.Text = ex.Message;
                            regErrorLab.Location = new Point(-30, 290);
                            regErrorLab.Visible = true;
                        }
                        finally
                        {
                            db.Close();
                        }

                    }
                    else
                    {
                        regErrorLab.Location = new Point(234, 290);
                        regErrorLab.Text = "Passwords doesn't match!";
                        regErrorLab.Visible = true;
                    }
                }
                else
                {
                    regErrorLab.Location = new Point(186, 290);
                    regErrorLab.Text = "Email doesn't have a valid format!";
                    regErrorLab.Visible = true;
                }
            }
            else
            {
                regErrorLab.Location = new Point(240, 290);
                regErrorLab.Text = "You need to fill all fields!";
                regErrorLab.Visible = true;
            }
        }


        private void LogBackButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }




        //Verify
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

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);


        //Events
        public delegate void GotoPageEventHandler(object source, EventArgs args);
        public event GotoPageEventHandler GotoPage;

        protected virtual void OnButtonClicked()
        {
            if (GotoPage != null)
            {
                this.Hide();
                regErrorLab.Visible = false;
                regFNameBox.Text = "";
                regLNameBox.Text = "";
                regUserBox.Text = "";
                regEmailBox.Text = "";
                regPassBox.Text = "";
                regConfPassBox.Text = "";
                GotoPage(this, EventArgs.Empty);
            }
        }
    }
}