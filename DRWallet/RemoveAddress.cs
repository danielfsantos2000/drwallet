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

                        string message = $"Are you sure you want to delete account number: {num} with {bal} DR, created at {date}? \n All you DR will be deleted and you can't undo this action!";
                        string caption = "Remove address";

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand cmds2 = new MySqlCommand();
                            cmds2.Connection = db;
                            cmds2.CommandText = "DELETE FROM address WHERE userid=@userid AND addnum=@addnum";
                            cmds2.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                            cmds2.Parameters.Add("@addnum", MySqlDbType.String).Value = remAddBox.Text;
                            cmds2.ExecuteNonQuery();
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
    }
}
