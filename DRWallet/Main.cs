using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public void showRegisterPage(object source, EventArgs e)
        {
            registerPage.Show();
        }

        public void showLoginPage(object source, EventArgs e)
        {
            loginPage.Show();
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
    }
}
