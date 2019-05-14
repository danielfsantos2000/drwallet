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

                //Get Value
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
                drs1.Close();

                // Get History
                MySqlCommand cmds2 = new MySqlCommand();
                cmds2.Connection = db;
                cmds2.CommandText = "SELECT movaddsender,movqtd,movaddreceiver,movdate FROM movements WHERE movaddsender=@id || movaddreceiver=@id ORDER BY movdate DESC LIMIT 10";
                cmds2.Parameters.Add("@id", MySqlDbType.String).Value = "1";
                MySqlDataReader drs2 = cmds2.ExecuteReader();
                if (drs2.HasRows)
                {
                    //Manual
                    DataTable dt = new DataTable("History");
                    dt.Columns.Add("Image");
                    dt.Columns.Add("MyAddress");
                    dt.Columns.Add("Details");
                    dt.Columns.Add("OtherAddress");
                    dt.Columns.Add("Date");

                    DataRow dr = dt.NewRow();

                   // while (drs2.Read())
                    //{
                        if (drs2["movaddsender"].ToString() == User.uID.ToString())
                        {
                            dr["Image"] = "Send";
                            dr["MyAddress"] = drs2["movaddsender"].ToString();
                            dr["Details"] = $"Sent {drs2["movqtd"].ToString()} DR";
                            dr["OtherAddress"] = drs2["movaddreceiver"].ToString();
                            dr["Date"] = drs2["movdate"].ToString();
                            dt.Rows.Add(dr);
                        }
                    //}







                    //Auto
                    DataSet ds = new DataSet();
                    //DataTable dataTable = new DataTable("history");

                    //ds.Tables.Add(dt);

                    //ds.Load(drs2, LoadOption.PreserveChanges, ds.Tables["history"]);

                    dashHistoryGrid.DataSource = dt;
                    dashHistoryGrid.Update();
                }
                drs2.Close();
            }
            catch (Exception ex)
            {
                dashValueLab.Text = ex.Message;
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
