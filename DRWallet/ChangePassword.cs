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
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void changePasswordUpdate()
        {
            if (User.uLanguage == 1)
            {
                cpwdTitleLab.Location = new Point(68, 9);
                cpwdTitleLab.Text = DRWallet.Properties.Resources.EN_CPwd_Header;
                cpwdCurrLab.Location = new Point(54, 113);
                cpwdCurrLab.Text = $"{DRWallet.Properties.Resources.EN_CPwd_CurrPassword}:";
                cpwdNPassLab.Location = new Point(84, 158);
                cpwdNPassLab.Text = $"{DRWallet.Properties.Resources.EN_CPwd_NewPassword}:";
                cpwdCNPassLab.Location = new Point(52, 202);
                cpwdCNPassLab.Text = $"{DRWallet.Properties.Resources.EN_CPwd_NewCPassword}:";
                cpwdSubmitButton.Text = DRWallet.Properties.Resources.EN_CPwd_SaveButton;

            }
            else if (User.uLanguage == 2)
            {
                cpwdTitleLab.Location = new Point(48, 17);
                cpwdTitleLab.Text = DRWallet.Properties.Resources.PT_CPwd_Header;
                cpwdCurrLab.Location = new Point(49, 113);
                cpwdCurrLab.Text = $"{DRWallet.Properties.Resources.PT_CPwd_CurrPassword}:";
                cpwdNPassLab.Location = new Point(48, 158);
                cpwdNPassLab.Text = $"{DRWallet.Properties.Resources.PT_CPwd_NewPassword}:";
                cpwdCNPassLab.Location = new Point(2, 202);
                cpwdCNPassLab.Text = $"{DRWallet.Properties.Resources.PT_CPwd_NewCPassword}:";
                cpwdSubmitButton.Text = DRWallet.Properties.Resources.PT_CPwd_SaveButton;
            }

            //Theme Options
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                cpwdTitleLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdErrorLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdCurrLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdNPassLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdCNPassLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                cpwdSubmitButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                cpwdSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                cpwdSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                cpwdTitleLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cpwdErrorLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cpwdCurrLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cpwdNPassLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cpwdCNPassLab.ForeColor = Color.FromArgb(255, 255, 255, 255);

                cpwdSubmitButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                cpwdSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                cpwdSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                cpwdTitleLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdErrorLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdCurrLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdNPassLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                cpwdCNPassLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                cpwdSubmitButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                cpwdSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                cpwdSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
            }
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

                            Logs.ChangePasswordLog(User.uID);

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

                        MessageBox.Show(ex.Message);
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
