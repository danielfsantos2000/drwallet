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


            if (User.uLanguage == 1)
            {
                addAddLab.Text = DRWallet.Properties.Resources.EN_Add_Header;

                addListInfoLab_YAID.Text = DRWallet.Properties.Resources.EN_ALL_YAID;
                addListInfoLab_YAID.Location = new Point(27, 6);

                addListInfoLab_Bal.Text = DRWallet.Properties.Resources.EN_ALL_Balance;
                addListInfoLab_Bal.Location = new Point(278, 6);


                addListInfoLab_Date.Text = DRWallet.Properties.Resources.EN_ALL_Date;
                addListInfoLab_Date.Location = new Point(497, 6);

                addCreateButton.Text = DRWallet.Properties.Resources.EN_Add_Create;
                addRemoveButton.Text = DRWallet.Properties.Resources.EN_Add_Remove;
            }
            else if (User.uLanguage == 2)
            {
                addAddLab.Text = DRWallet.Properties.Resources.PT_Add_Header;

                addListInfoLab_YAID.Text = DRWallet.Properties.Resources.PT_ALL_YAID;
                addListInfoLab_YAID.Location = new Point(42, 6);

                addListInfoLab_Bal.Text = DRWallet.Properties.Resources.PT_ALL_Balance;
                addListInfoLab_Bal.Location = new Point(288, 6);

                addListInfoLab_Date.Text = DRWallet.Properties.Resources.PT_ALL_Date;
                addListInfoLab_Date.Location = new Point(497, 6);

                addCreateButton.Text = DRWallet.Properties.Resources.PT_Add_Create;
                addRemoveButton.Text = DRWallet.Properties.Resources.PT_Add_Remove;
            }

            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                addAddLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_Bal.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                addCreateButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                addCreateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                addCreateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                addRemoveButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                addRemoveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                addRemoveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                panel1.BackColor = Color.FromArgb(255, 255, 125, 0);
                addListGrid.BackgroundColor = Color.FromArgb(255, 255, 164, 76);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                addAddLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                addListInfoLab_YAID.ForeColor = Color.FromArgb(255, 255, 255, 255);
                addListInfoLab_Bal.ForeColor = Color.FromArgb(255, 255, 255, 255);
                addListInfoLab_Date.ForeColor = Color.FromArgb(255, 255, 255, 255);

                addCreateButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                addCreateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                addCreateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                addRemoveButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                addRemoveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                addRemoveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                panel1.BackColor = Color.FromArgb(255, 35, 35, 35);
                addListGrid.BackgroundColor = Color.FromArgb(255, 145, 145, 145);
            }
            else if(User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                addAddLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_Bal.ForeColor = Color.FromArgb(255, 0, 0, 0);
                addListInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                addCreateButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                addCreateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                addCreateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                addRemoveButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                addRemoveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                addRemoveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                panel1.BackColor = Color.FromArgb(255, 188, 188, 188);
                addListGrid.BackgroundColor = Color.FromArgb(255, 220, 220, 220);
            }

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
                    DataTable dataTable = new DataTable("Addresses");
                    ds.Tables.Add(dataTable);
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
