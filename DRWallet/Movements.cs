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
    public partial class Movements : UserControl
    {
        public Movements()
        {
            InitializeComponent();
        }

        public void movementsUpdate()
        {
            NavBar.nmPage = 2;
            movNavBar.NavbarUpdate();

            if (User.uLanguage == 1)
            {
                movMovLab.Text = DRWallet.Properties.Resources.EN_Mov_Header;
                movHistoryInfoLab_YAID.Text = DRWallet.Properties.Resources.EN_Mov_YAID;
                movHistoryInfoLab_YAID.Location = new Point(39, 5);
                movHistoryInfoLab_Details.Text = DRWallet.Properties.Resources.EN_Mov_Details;
                movHistoryInfoLab_Details.Location = new Point(232, 5);
                movHistoryInfoLab_AID.Text = DRWallet.Properties.Resources.EN_Mov_AID;
                movHistoryInfoLab_AID.Location = new Point(359, 5);
                movHistoryInfoLab_Date.Text = DRWallet.Properties.Resources.EN_Mov_Date;
                movHistoryInfoLab_Date.Location = new Point(530, 5);
            }
            else if (User.uLanguage == 2)
            {
                movMovLab.Text = DRWallet.Properties.Resources.PT_Mov_Header;
                movHistoryInfoLab_YAID.Text = DRWallet.Properties.Resources.PT_Mov_YAID;
                movHistoryInfoLab_YAID.Location = new Point(54, 5);
                movHistoryInfoLab_Details.Text = DRWallet.Properties.Resources.PT_Mov_Details;
                movHistoryInfoLab_Details.Location = new Point(227, 5);
                movHistoryInfoLab_AID.Text = DRWallet.Properties.Resources.PT_Mov_AID;
                movHistoryInfoLab_AID.Location = new Point(377, 5);
                movHistoryInfoLab_Date.Text = DRWallet.Properties.Resources.PT_Mov_Date;
                movHistoryInfoLab_Date.Location = new Point(530, 5);
            }

            //Theme Options
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                movMovLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                panel1.BackColor = Color.FromArgb(255, 255, 125, 0);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 255, 164, 76);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                movMovLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                movHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 255, 255, 255);
                movHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 255, 255, 255);
                movHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 255, 255, 255);
                movHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 255, 255, 255);

                panel1.BackColor = Color.FromArgb(255, 35, 35, 35);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 145, 145, 145);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                movMovLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_YAID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_Details.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_AID.ForeColor = Color.FromArgb(255, 0, 0, 0);
                movHistoryInfoLab_Date.ForeColor = Color.FromArgb(255, 0, 0, 0);

                panel1.BackColor = Color.FromArgb(255, 188, 188, 188);
                movHistoryGrid.BackgroundColor = Color.FromArgb(255, 220, 220, 220);
            }

            try
            {
                db.Open();

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
                                        ORDER BY movements.movdate DESC".Trim();

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
                            if (User.uLanguage == 1)
                            {
                                dr["Details"] = $"Sent {drs2["movqtd"].ToString()} DR to";
                            }
                            else if (User.uLanguage == 2)
                            {
                                dr["Details"] = $"Enviou {drs2["movqtd"].ToString()} DR para";
                            }
                            dr["OtherAddress"] = drs2["destaddnum"].ToString();
                            dr["Date"] = drs2["movdate"].ToString();
                        }
                        else
                        {
                            dr["Image"] = receive;
                            dr["MyAddress"] = drs2["addnum"].ToString();
                            if (User.uLanguage == 1)
                            {
                                dr["Details"] = $"Received {drs2["movqtd"].ToString()} DR from";
                            }
                            else if (User.uLanguage == 2)
                            {
                                dr["Details"] = $"Recebeu {drs2["movqtd"].ToString()} DR de";
                            }
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
    }
}
