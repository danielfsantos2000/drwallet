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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            loginPage.GotoPage += this.showRegisterPage;
            loginPage.GotoPage2 += this.showDashboardPage;
            registerPage.GotoPage += this.showLoginPage;
            NavBar.GotoNavDash += this.showDashboardPage;
            NavBar.GotoNavMove += this.showMovementsPage;
            NavBar.GotoNavAdd += this.showAddressesPage;
            NavBar.GotoNavAcc += this.showAccountPage;
            NavBar.GotoNavSet += this.showSettingsPage;
            accountPage.GotoLog += this.showLoginPageLogout;
            RemoveAddress.sendUpdateAddresses2 += this.updateAddresses;

            loginPage.StartTimer += this.StartTimer;
            accountPage.StopTimer += this.StopTimer;
            Send.UpdateDash += this.showDashboardPage;
        }

        public void showRegisterPage(object source, EventArgs e)
        {
            loginPage.Hide();
            registerPage.Show();
        }

        public void showLoginPage(object source, EventArgs e)
        {
            registerPage.Hide();
            loginPage.Show();
        }

        public void showLoginPageLogout(object source, EventArgs e)
        {
            dashboardPage.Hide();
            movementsPage.Hide();
            addressesPage.Hide();
            accountPage.Hide();
            settingsPage.Hide();
            loginPage.Show();

            dashboardPage.dashboardDelete();
            movementsPage.movementsDelete();
            addressesPage.addressesDelete();
        }

        public void showDashboardPage(object source, EventArgs e)
        {
            dashboardPage.dashboardUpdate();
            dashboardPage.Show();
            movementsPage.Hide();
            addressesPage.Hide();
            accountPage.Hide();
            settingsPage.Hide();
        }

        public void showMovementsPage(object source, EventArgs e)
        {
            movementsPage.movementsUpdate();
            dashboardPage.Hide();
            movementsPage.Show();
            addressesPage.Hide();
            accountPage.Hide();
            settingsPage.Hide();
        }

        public void showAddressesPage(object source, EventArgs e)
        {
            addressesPage.addressesUpdate();
            dashboardPage.Hide();
            movementsPage.Hide();
            addressesPage.Show();
            accountPage.Hide();
            settingsPage.Hide();
        }

        public void showAccountPage(object source, EventArgs e)
        {
            accountPage.accountUpdate();
            dashboardPage.Hide();
            movementsPage.Hide();
            addressesPage.Hide();
            accountPage.Show();
            settingsPage.Hide();
        }

        public void showSettingsPage(object source, EventArgs e)
        {
            settingsPage.settingsUpdate();
            dashboardPage.Hide();
            movementsPage.Hide();
            addressesPage.Hide();
            accountPage.Hide();
            settingsPage.Show();
        }

        public void updateAddresses(object source, EventArgs e)
        {
            addressesPage.addressesUpdate();
        }

        public void StartTimer(object source, EventArgs e)
        {
            timerUserUpdate.Start();
        }

        public void StopTimer(object source, EventArgs e)
        {
            timerUserUpdate.Stop();
        }

        private void TimerUserUpdate_Tick(object sender, EventArgs e)
        {
            User.updateInfo();

            string last30Seconds = DateTime.Now.AddSeconds(-30).ToString("yyyy-MM-dd HH:mm:ss.fff");

            try
            {
                db.Open();
                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT valcurrent, valdate FROM value WHERE valdate >= @date";
                cmds1.Parameters.Add("@date", MySqlDbType.String).Value = last30Seconds;
                MySqlDataReader drs1 = cmds1.ExecuteReader();
                if (!drs1.HasRows)
                {
                    drs1.Close();

                    Random rnd = new Random();
                    double newval = RandomNumberBetween(20000.00, 800000.00);
                    newval = newval/100;
                    newval = Math.Round(newval, 2);

                    MySqlCommand cmds2 = new MySqlCommand();
                    cmds2.Connection = db;
                    cmds2.CommandText = "INSERT INTO value (valcurrent) VALUES (@val)";
                    cmds2.Parameters.Add("@val", MySqlDbType.String).Value = newval;
                    cmds2.ExecuteNonQuery();
                }
                drs1.Close();
            }
            catch
            {

            }
            finally
            {
                dashboardPage.dashboardUpdate();
                movementsPage.movementsUpdate();
                addressesPage.addressesUpdate();
                accountPage.accountUpdate();
                settingsPage.settingsUpdate();
                db.Close();
            }
        }


        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            double next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }


        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
