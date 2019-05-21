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

                //Prepare addresses history
                string whereparam = "";

                foreach (string adds in User.addresses)
                {
                    whereparam += $" || movements.sender_addid={adds} || movements.dest_addid={adds}";
                }

                // Get History
                MySqlCommand cmds2 = new MySqlCommand();
                cmds2.Connection = db;
                cmds2.CommandText = $@"
                                        SELECT 
	                                        sender.userid as senderid
                                        ,   sender.addnum
                                        ,   movements.movqtd
                                        , 	dest.addnum as destaddnum
                                        , 	movements.movdate 
                                        FROM movements 
	                                        JOIN address AS sender ON sender.addid = movements.sender_addid 
                                            JOIN address AS dest ON movements.dest_addid = dest.addid 
                                        WHERE movements.movid = -1 
                                        {whereparam}
                                        ORDER BY movements.movdate DESC LIMIT 10".Trim();

                MySqlDataReader drs2 = cmds2.ExecuteReader();
                if (drs2.HasRows)
                {
                    Image send;
                    send = DRWallet.Properties.Resources.send;
                    Image receive;
                    receive = DRWallet.Properties.Resources.receive;
                    DataTable dt = new DataTable("History");
                    dt.Columns.Add("Image", typeof(Image));
                    dt.Columns.Add("MyAddress");
                    dt.Columns.Add("Details");
                    dt.Columns.Add("OtherAddress");
                    dt.Columns.Add("Date");

                    dashHistoryGrid.Columns[0].Width = 32;
                    dashHistoryGrid.Columns[1].Width = 170;
                    dashHistoryGrid.Columns[2].Width = 122;
                    dashHistoryGrid.Columns[3].Width = 170;
                    dashHistoryGrid.Columns[4].Width = 120;



                    while (drs2.Read())
                    {
                        DataRow dr = dt.NewRow();
                        if (drs2["senderid"].ToString() == User.uID.ToString())
                        {
                            dr["Image"] = send;
                            dr["MyAddress"] = drs2["addnum"].ToString();
                            dr["Details"] = $"Sent {drs2["movqtd"].ToString()} DR to";
                            dr["OtherAddress"] = drs2["destaddnum"].ToString();
                            dr["Date"] = drs2["movdate"].ToString();
                        }
                        else
                        {
                            dr["Image"] = receive;
                            dr["MyAddress"] = drs2["addnum"].ToString();
                            dr["Details"] = $"Received {drs2["movqtd"].ToString()} DR from";
                            dr["OtherAddress"] = drs2["destaddnum"].ToString();
                            dr["Date"] = drs2["movdate"].ToString();
                        }
                        dt.Rows.Add(dr);
                    }

                    dashHistoryGrid.DataSource = dt;
                    dashHistoryGrid.Update();
                }
                drs2.Close();
            }
            catch (Exception ex)
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
    }
}
