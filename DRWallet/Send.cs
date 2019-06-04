using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRWallet
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();

            //Theme
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);

                sendHeaderLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                sendYALab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                sendTALab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                SendValLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                sendSubmitButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                sendSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                sendSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);

                sendHeaderLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                sendYALab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                sendTALab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                SendValLab.ForeColor = Color.FromArgb(255, 255, 255, 255);

                sendSubmitButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                sendSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                sendSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);

                sendHeaderLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                sendYALab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                sendTALab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                SendValLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                sendSubmitButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                sendSubmitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                sendSubmitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
            }

            if (User.uLanguage == 1)
            {
                sendHeaderLab.Text = DRWallet.Properties.Resources.EN_Send_Header;
                sendHeaderLab.Location = new Point(183, 9);

                sendYALab.Text = $"{DRWallet.Properties.Resources.EN_Send_YA}:";
                sendYALab.Location = new Point(97, 94);

                sendTALab.Text = $"{DRWallet.Properties.Resources.EN_Send_TA}:";
                sendTALab.Location = new Point(83, 142);

                SendValLab.Text = $"{DRWallet.Properties.Resources.EN_Send_Value}:";
                SendValLab.Location = new Point(172, 187);

                sendSubmitButton.Text = DRWallet.Properties.Resources.EN_Send_Button;

                this.Text = $"{sendHeaderLab.Text} - DRWallet";
            }
            else if (User.uLanguage == 2)
            {
                sendHeaderLab.Text = DRWallet.Properties.Resources.PT_Send_Header;
                sendHeaderLab.Location = new Point(176, 9);

                sendYALab.Text = $"{DRWallet.Properties.Resources.PT_Send_YA}:";
                sendYALab.Location = new Point(135, 94);

                sendTALab.Text = $"{DRWallet.Properties.Resources.PT_Send_TA}:";
                sendTALab.Location = new Point(49, 142);

                SendValLab.Text = $"{DRWallet.Properties.Resources.PT_Send_Value}:";
                SendValLab.Location = new Point(138, 187);

                sendSubmitButton.Text = DRWallet.Properties.Resources.PT_Send_Button;

                this.Text = $"{sendHeaderLab.Text} - DRWallet";
            }

            try
            {
                db.Open();
                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT addnum FROM address WHERE userid=@userid";
                cmds1.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                MySqlDataReader drs1 = cmds1.ExecuteReader();

                if (drs1.HasRows)
                {
                    while (drs1.Read())
                    {
                        sendYACombo.Items.Add(drs1["addnum"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void SupressKeys(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void SupressKeysNumb(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.NumPad0 && e.KeyCode != Keys.NumPad1 && e.KeyCode != Keys.NumPad2 && e.KeyCode != Keys.NumPad3 && e.KeyCode != Keys.NumPad4 && e.KeyCode != Keys.NumPad5 && e.KeyCode != Keys.NumPad6 && e.KeyCode != Keys.NumPad7 && e.KeyCode != Keys.NumPad8 && e.KeyCode != Keys.NumPad9 && e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9 && e.KeyCode != Keys.OemPeriod && e.KeyCode != Keys.Decimal && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void SendSubmitButton_Click(object sender, EventArgs e)
        {
            if (sendTABox.Text != "" && sendValBox.Text != "" && sendYACombo.Text != "")
            {
                double balance = 0;
                double myID = 0;
                double targetBalance = 0;
                double targetID = 0;
                double sendValue = 0;

                double.TryParse(sendValBox.Text, out sendValue);

                try
                {
                    db.Open();

                    MySqlCommand cmds1 = new MySqlCommand();
                    cmds1.Connection = db;
                    cmds1.CommandText = "SELECT addbal, addid FROM address WHERE addnum=@addnum";
                    cmds1.Parameters.Add("@addnum", MySqlDbType.String).Value = sendYACombo.Text;
                    MySqlDataReader drs1 = cmds1.ExecuteReader();

                    if (drs1.HasRows)
                    {
                        while (drs1.Read())
                        {
                            double.TryParse(drs1["addbal"].ToString(), out balance);
                            double.TryParse(drs1["addid"].ToString(), out myID);
                        }
                    }

                    drs1.Close();

                    if (balance > sendValue)
                    {
                        MySqlCommand cmds3 = new MySqlCommand();
                        cmds3.Connection = db;
                        cmds3.CommandText = "SELECT addbal, addid FROM address WHERE addnum=@addnum";
                        cmds3.Parameters.Add("@addnum", MySqlDbType.String).Value = sendTABox.Text;
                        MySqlDataReader drs3 = cmds3.ExecuteReader();

                        if (drs3.HasRows)
                        {
                            while (drs3.Read())
                            {
                                double.TryParse(drs3["addbal"].ToString(), out targetBalance);
                                double.TryParse(drs3["addid"].ToString(), out targetID);
                            }

                            drs3.Close();

                            MySqlCommand cmds4 = new MySqlCommand();
                            cmds4.Connection = db;
                            cmds4.CommandText = "UPDATE address SET addbal=@balance WHERE addnum=@addnum";
                            cmds4.Parameters.Add("@balance", MySqlDbType.String).Value = targetBalance + sendValue;
                            cmds4.Parameters.Add("@addnum", MySqlDbType.String).Value = sendTABox.Text;
                            cmds4.ExecuteNonQuery();

                            MySqlCommand cmds2 = new MySqlCommand();
                            cmds2.Connection = db;
                            cmds2.CommandText = "UPDATE address SET addbal=@balance WHERE addnum=@addnum";
                            cmds2.Parameters.Add("@balance", MySqlDbType.String).Value = balance - sendValue;
                            cmds2.Parameters.Add("@addnum", MySqlDbType.String).Value = sendYACombo.Text;
                            cmds2.ExecuteNonQuery();

                            MySqlCommand cmds5 = new MySqlCommand();
                            cmds5.Connection = db;
                            cmds5.CommandText = "INSERT INTO movements (sender_addid, dest_addid, movqtd, movhash) VALUES (@sender, @dest, @qtd, @hash)";
                            cmds5.Parameters.Add("@sender", MySqlDbType.Int32).Value = myID;
                            cmds5.Parameters.Add("@dest", MySqlDbType.Int32).Value = targetID;
                            cmds5.Parameters.Add("@qtd", MySqlDbType.Double).Value = sendValue;
                            cmds5.Parameters.Add("@hash", MySqlDbType.String).Value = Encryption.hash(myID, targetID,sendValue);
                            cmds5.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.Close();
                    UpdateDashFunc();
                    this.Close();
                }
            }
        }


        //Movements
        public delegate void UpdateDashEventHandler(object source, EventArgs args);
        public static event UpdateDashEventHandler UpdateDash;

        protected virtual void UpdateDashFunc()
        {
            if (UpdateDash != null)
            {
                UpdateDash(this, EventArgs.Empty);
            }
        }
    }
}
