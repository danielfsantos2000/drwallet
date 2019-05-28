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
    public partial class RemoveAddress : Form
    {
        public RemoveAddress()
        {
            InitializeComponent();
            UpdateRemAdd();
        }

        public void UpdateRemAdd()
        {

            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                remTitleLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                remTextLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                remAddButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                remAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                remAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                remTitleLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                remTextLab.ForeColor = Color.FromArgb(255, 255, 255, 255);

                remAddButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                remAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                remAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                remTitleLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                remTextLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                remAddButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                remAddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                remAddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
            }

            if (User.uLanguage == 1)
            {
                remTitleLab.Text = DRWallet.Properties.Resources.EN_Rm_Header;
                remTitleLab.Location = new Point(68, 9);

                remTextLab.Text = $"{DRWallet.Properties.Resources.EN_Rm_Text}:";
                remTextLab.Location = new Point(103, 105);

                remAddButton.Text = DRWallet.Properties.Resources.EN_Rm_Header;
            }
            else if (User.uLanguage == 2)
            {
                remTitleLab.Text = DRWallet.Properties.Resources.PT_Rm_Header;
                remTitleLab.Location = new Point(49, 9);

                remTextLab.Text = $"{DRWallet.Properties.Resources.PT_Rm_Text}:";
                remTextLab.Location = new Point(86, 105);

                remAddButton.Text = DRWallet.Properties.Resources.PT_Rm_Header;
            }

            try
            {
                remAddBox.Items.Clear();
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
                        remAddBox.Items.Add(drs1["addnum"].ToString());
                    }
                }
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void RemAddButton_Click(object sender, EventArgs e)
        {
            if (remAddBox.Text != "")
            {
                try
                {
                    db.Open();
                    MySqlCommand cmds1 = new MySqlCommand();
                    cmds1.Connection = db;
                    cmds1.CommandText = "SELECT addnum, addbal, addcreated FROM address WHERE userid=@userid AND addnum=@addnum";
                    cmds1.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                    cmds1.Parameters.Add("@addnum", MySqlDbType.String).Value = remAddBox.Text;
                    MySqlDataReader drs1 = cmds1.ExecuteReader();
                    if (drs1.HasRows)
                    {
                        string num = "", bal = "", date = "";
                        while (drs1.Read())
                        {
                            num = drs1["addnum"].ToString();
                            bal = drs1["addbal"].ToString();
                            date = drs1["addcreated"].ToString();
                        }

                        drs1.Close();

                        string message = "";
                        string caption = "";

                        if (User.uLanguage == 1)
                        {
                            message = $"Are you sure you want to delete account number: {num} with {bal} DR, created at {date}? \n All you DR will be deleted and you can't undo this action!";
                            caption = "Remove address";
                        }
                        else if (User.uLanguage == 2)
                        {
                            message = $"Tem certeza que pretende remover o endereço com o número: {num} com {bal} DR, criado a {date}? \n Todas as DR serão eliminadas e não poderá anular esta operação!";
                            caption = "Remover Endereço";
                        }
                        

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand cmds2 = new MySqlCommand();
                            cmds2.Connection = db;
                            cmds2.CommandText = "DELETE FROM address WHERE userid=@userid AND addnum=@addnum";
                            cmds2.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                            cmds2.Parameters.Add("@addnum", MySqlDbType.String).Value = remAddBox.Text;
                            cmds2.ExecuteNonQuery();

                            Logs.RemAddressLog(User.uID, remAddBox.Text);
                            sendUpdateAddresses();

                            this.Dispose();
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
        }

        //Dashboard
        public delegate void sendUpdateAddressesEventHandler(object source, EventArgs args);
        public static event sendUpdateAddressesEventHandler sendUpdateAddresses2;

        protected virtual void sendUpdateAddresses()
        {
            if (sendUpdateAddresses2 != null)
            {
                sendUpdateAddresses2(this, EventArgs.Empty);
            }
        }
    }
}
