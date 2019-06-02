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

            double value = 0;

            try
            {
                db.Open();

                //Balance
                MySqlCommand cmds3 = new MySqlCommand();
                cmds3.Connection = db;
                cmds3.CommandText = "SELECT SUM(addbal) AS balance FROM address WHERE userid=@userid";
                cmds3.Parameters.Add("@userid", MySqlDbType.String).Value = User.uID;
                MySqlDataReader getBal = cmds3.ExecuteReader();
                if (getBal.HasRows)
                {
                    while (getBal.Read())
                    {
                        double.TryParse(getBal["balance"].ToString(), out value);
                    }
                }

                getBal.Close();

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
                        dashValueLab.Text = $"{dashValueLab.Text} €";
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
                                        ORDER BY movements.movdate DESC LIMIT 7".Trim();

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

                    movHistoryGrid.Columns[0].Width = 32;
                    movHistoryGrid.Columns[1].Width = 170;
                    movHistoryGrid.Columns[2].Width = 122;
                    movHistoryGrid.Columns[3].Width = 170;
                    movHistoryGrid.Columns[4].Width = 120;



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

                    movHistoryGrid.DataSource = dt;
                    movHistoryGrid.Update();
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

            //Theme
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);

                dashUsernameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashBalanceLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashDRCoinLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashValueLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                dashSendButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                dashSendButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                dashSendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                panel1.BackColor = Color.FromArgb(255, 255, 125, 0);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 255, 164, 76);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);

                dashUsernameLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashBalanceLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashDRCoinLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashValueLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashHistoryLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 255, 255, 255);
                dashHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 255, 255, 255);

                dashSendButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                dashSendButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                dashSendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                panel1.BackColor = Color.FromArgb(255, 35, 35, 35);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 145, 145, 145);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);

                dashUsernameLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashBalanceLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashDRCoinLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashValueLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                dashHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                dashSendButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                dashSendButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                dashSendButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                panel1.BackColor = Color.FromArgb(255, 188, 188, 188);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 220, 220, 220);
            }

            //Language
            if (User.uLanguage == 1)
            {
                dashBalanceLab.Text = $"{DRWallet.Properties.Resources.EN_Dash_Bal}: {value} DR";
                dashBalanceLab.Location = new Point(166, 109);

                dashDRCoinLab.Text = $"{DRWallet.Properties.Resources.EN_Dash_Val}:";
                dashDRCoinLab.Location = new Point(498, 109);

                dashHistoryLab.Text = $"{DRWallet.Properties.Resources.EN_Dash_History}:";
                dashHistoryLab.Location = new Point(160, 239);

                dashHistoryInfoLab_YAID.Text = DRWallet.Properties.Resources.EN_ALL_YAID;
                dashHistoryInfoLab_YAID.Location = new Point(39, 5);
                dashHistoryInfoLab_Details.Text = DRWallet.Properties.Resources.EN_ALL_Details;
                dashHistoryInfoLab_Details.Location = new Point(232, 5);
                dashHistoryInfoLab_AID.Text = DRWallet.Properties.Resources.EN_ALL_AID;
                dashHistoryInfoLab_AID.Location = new Point(359, 5);
                dashHistoryInfoLab_Date.Text = DRWallet.Properties.Resources.EN_ALL_Date;
                dashHistoryInfoLab_Date.Location = new Point(530, 5);

                dashSendButton.Text = DRWallet.Properties.Resources.EN_Send_Header;
            }
            else if (User.uLanguage == 2)
            {
                dashBalanceLab.Text = $"{DRWallet.Properties.Resources.PT_Dash_Bal}: {value} DR";
                dashBalanceLab.Location = new Point(166, 109);

                dashDRCoinLab.Text = $"{DRWallet.Properties.Resources.PT_Dash_Val}:";
                dashDRCoinLab.Location = new Point(498, 109);

                dashHistoryLab.Text = $"{DRWallet.Properties.Resources.PT_Dash_History}:";
                dashHistoryLab.Location = new Point(160, 239);

                dashHistoryInfoLab_YAID.Text = DRWallet.Properties.Resources.PT_ALL_YAID;
                dashHistoryInfoLab_YAID.Location = new Point(54, 5);
                dashHistoryInfoLab_Details.Text = DRWallet.Properties.Resources.PT_ALL_Details;
                dashHistoryInfoLab_Details.Location = new Point(227, 5);
                dashHistoryInfoLab_AID.Text = DRWallet.Properties.Resources.PT_ALL_AID;
                dashHistoryInfoLab_AID.Location = new Point(377, 5);
                dashHistoryInfoLab_Date.Text = DRWallet.Properties.Resources.PT_ALL_Date;
                dashHistoryInfoLab_Date.Location = new Point(530, 5);

                dashSendButton.Text = DRWallet.Properties.Resources.PT_Send_Header;
            }

        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void DashSendButton_Click(object sender, EventArgs e)
        {
            Send send = new Send();
            send.Show();
        }
    }
}
