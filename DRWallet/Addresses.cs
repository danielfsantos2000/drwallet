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
    public partial class Addresses : UserControl
    {
        public Addresses()
        {
            InitializeComponent();
            addListGrid.Columns[0].Width = 205;
            addListGrid.Columns[1].Width = 235;
            addListGrid.Columns[2].Width = 174;
        }

        public void addressesUpdate()
        {
            NavBar.nmPage = 3;
            addNavBar.NavbarUpdate();

            try
            {
                db.Open();

                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT addnum, addbal, addcreated FROM address WHERE userid=@userid";
                cmds1.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                MySqlDataReader drs1 = cmds1.ExecuteReader();
                if (drs1.HasRows)
                {
                    DataSet ds = new DataSet();
                    // assim necessitamos de uma tabela ao dataset
                    DataTable dataTable = new DataTable("Addresses");
                    ds.Tables.Add(dataTable);
                    // e depois carregar
                    ds.Load(drs1, LoadOption.PreserveChanges, ds.Tables["Addresses"]);

                    addListGrid.DataSource = ds.Tables["Addresses"];
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

        private void AddCreateButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to create a new address?";
            string caption = "Create Address";

            if (User.uLanguage == 2)
            {
                message = "Tem certeza que quer criar um novo endereço?";
                caption = "Adicionar endereço";
            }
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.Open();

                    Random rnd = new Random();
                    int newadd = 0;
                    bool address = false;

                    //Get new ID

                    while (!address)
                    {
                        newadd = rnd.Next(100000000, 999999999);
                        MySqlCommand cmds1 = new MySqlCommand();
                        cmds1.Connection = db;
                        cmds1.CommandText = "SELECT * FROM address WHERE addnum=@addnum";
                        cmds1.Parameters.Add("@addnum", MySqlDbType.String).Value = newadd;
                        MySqlDataReader drs1 = cmds1.ExecuteReader();
                        if (!drs1.HasRows)
                        {
                            address = true;
                        }
                        drs1.Close();
                    }
                    
                    MySqlCommand cmds2 = new MySqlCommand();
                    cmds2.Connection = db;
                    cmds2.CommandText = "INSERT INTO address (addnum,addbal,userid) VALUES (@addnum,@addbal,@userid)";
                    cmds2.Parameters.Add("@addnum", MySqlDbType.String).Value = newadd;
                    cmds2.Parameters.Add("@addbal", MySqlDbType.String).Value = 10000;
                    cmds2.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                    cmds2.ExecuteNonQuery();
                    Logs.AddAddressLog(User.uID, newadd);
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
            addressesUpdate();
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void AddRemoveButton_Click(object sender, EventArgs e)
        {
            RemoveAddress rem = new RemoveAddress();
            rem.Show();
        }
    }
}
