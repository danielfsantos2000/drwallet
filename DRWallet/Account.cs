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
            }
            else if (User.uLanguage == 2)
            {
                accAccLab.Text = DRWallet.Properties.Resources.PT_Set_Header;

                accFNameLab.Location = new Point(156, 117);
                accFNameLab.Text = $"{DRWallet.Properties.Resources.PT_Acc_FName}:";

                accLNameLab.Location = new Point(187, 178);
                accLNameLab.Text = $"{DRWallet.Properties.Resources.PT_Acc_LName}:";
            }
        }

        private void AccSaveBox_Click(object sender, EventArgs e)
        {

            if (accFNameBox.Text != "" && accLNameBox.Text != "" && accEmailBox.Text != "")
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
                        }
                        else
                        {
                            MessageBox.Show("Email already in use.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong.");
                }
                finally
                {
                    db.Close();
                }
            }
            else
            {
                MessageBox.Show("You need to fill all fields.");
            }
        }


        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void accPasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword npass = new ChangePassword();
            npass.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User.logout();
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
    }
}
