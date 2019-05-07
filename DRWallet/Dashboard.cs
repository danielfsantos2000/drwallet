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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        public void dashboardUpdate()
        {
            NavBar.nmPage = 1;
            dashNavBar.NavbarUpdate();
            dashUsernameLab.Text = $"{User.uFName} {User.uLName}";

            try
            {
                db.Open();
                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT * FROM value ORDER BY valdate DESC LIMIT 1";
                MySqlDataReader drs1 = cmds1.ExecuteReader();
                if (drs1.HasRows)
                {
                    while (drs1.Read())
                    {
                        dashValueLab.Text = drs1["valcurrent"].ToString();
                        dashValueLab.Text = $"{dashValueLab.Text}€";
                    }
                }
            }
            catch (Exception ex)
            {
                dashValueLab.Text = "ERROR!";
            }
            finally
            {
                db.Close();
            }
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
