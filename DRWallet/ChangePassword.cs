using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DRWallet
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void CpwdSubmitButton_Click(object sender, EventArgs e)
        {
            if (cpwdCPassBox.Text != "" && cpwdNPassBox.Text != "" && cpwdCNPassBox.Text != "")
            {
                if (cpwdNPassBox.Text == cpwdCNPassBox.Text)
                {
                    try
                    {
                        db.Open();
                        MySqlCommand cmds1 = new MySqlCommand();
                        cmds1.Connection = db;
                        cmds1.CommandText = "SELECT * FROM users WHERE userpassword=@password AND userid=@id";
                        cmds1.Parameters.Add("@password", MySqlDbType.String).Value = cpwdCPassBox.Text;
                        cmds1.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                        MySqlDataReader drs1 = cmds1.ExecuteReader();
                        if (drs1.HasRows)
                        {
                            drs1.Close();
                            MySqlCommand cmdChange = new MySqlCommand();
                            cmdChange.Connection = db;
                            cmdChange.CommandText = "UPDATE users SET userpassword=@pass WHERE userid=@id";
                            cmdChange.Parameters.Add("@pass", MySqlDbType.String).Value = cpwdNPassBox.Text;
                            cmdChange.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                            cmdChange.ExecuteNonQuery();

                            cpwdErrorLab.Text = "Successfully Changed!";
                            cpwdErrorLab.Location = new Point(138, 75);
                            cpwdErrorLab.Visible = true;

                            cpwdCPassBox.Text = "";
                            cpwdNPassBox.Text = "";
                            cpwdCNPassBox.Text = "";
                        }
                        else
                        {
                            cpwdErrorLab.Text = "Wrong password!";
                            cpwdErrorLab.Location = new Point(145, 75);
                            cpwdErrorLab.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        cpwdErrorLab.Text = "Something went wrong!";
                        cpwdErrorLab.Location = new Point(125, 75);
                        cpwdErrorLab.Visible = true;
                    }
                    finally
                    {
                        db.Close();
                    }
                }
                else
                {
                    cpwdErrorLab.Text = "Passwords doesn't match.";
                    cpwdErrorLab.Location = new Point(125, 75);
                    cpwdErrorLab.Visible = true;
                }
            }
            else
            {
                cpwdErrorLab.Text = "You need to fill all fields!";
                cpwdErrorLab.Location = new Point(125, 75);
                cpwdErrorLab.Visible = true;
            }
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
