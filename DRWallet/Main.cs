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
            dashboardPage.Show();
            dashboardPage.dashboardUpdate();
        }
    }
}
