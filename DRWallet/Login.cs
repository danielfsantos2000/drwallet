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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegGotoButton_Click(object sender, EventArgs e)
        {
            OnRegButtonClicked();
        }

        private void LogLoginButton_Click(object sender, EventArgs e)
        {
            if (logUserBox.Text != "" && logPassBox.Text != "")
            {
                try
                {
                    db.Open();
                    MySqlCommand cmds1 = new MySqlCommand();
                    cmds1.Connection = db;
                    cmds1.CommandText = "SELECT * FROM users WHERE userusername=@username AND userpassword=@password";
                    cmds1.Parameters.Add("@username", MySqlDbType.String).Value = logUserBox.Text;
                    cmds1.Parameters.Add("@password", MySqlDbType.String).Value = logPassBox.Text;
                    MySqlDataReader drs1 = cmds1.ExecuteReader();
                    if (drs1.HasRows)
                    {
                        while (drs1.Read())
                        {
                            int.TryParse(drs1["userid"].ToString(), out int id);
                            User.uID = id;
                            User.uUser = drs1["userusername"].ToString();
                            User.uEmail = drs1["useremail"].ToString();
                            User.uFName = drs1["userfname"].ToString();
                            User.uLName = drs1["userlname"].ToString();
                            OnLogButtonClicked();
                        }
                        drs1.Close();
                    }
                    else
                    {
                        logErrorLab.Location = new Point(250, 290);
                        logErrorLab.Text = "Could not log in!";
                        logErrorLab.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    logErrorLab.Location = new Point(0, 290);
                    logErrorLab.Text = $"Error: {ex}";
                    logErrorLab.Visible = true;
                }
                finally
                {
                    db.Close();
                }
            } else {
                logErrorLab.Location = new Point(240, 290);
                logErrorLab.Text = "You need to fill all fields!";
                logErrorLab.Visible = true;
            }
        }


        //Events
        public delegate void GotoPageEventHandler(object source, EventArgs args);
        public event GotoPageEventHandler GotoPage;

        protected virtual void OnRegButtonClicked()
        {
            if (GotoPage != null)
            {
                this.Hide();
                logErrorLab.Visible = false;
                logUserBox.Text = "";
                logPassBox.Text = "";
                GotoPage(this, EventArgs.Empty);
            }
        }

        public delegate void GotoPage2EventHandler(object source, EventArgs args);
        public event GotoPage2EventHandler GotoPage2;

        protected virtual void OnLogButtonClicked()
        {
            if (GotoPage2 != null)
            {
                this.Hide();
                logErrorLab.Visible = false;
                logUserBox.Text = "";
                logPassBox.Text = "";
                GotoPage2(this, EventArgs.Empty);
            }
        }


        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
