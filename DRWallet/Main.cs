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
        }

        public void showRegisterPage(object source, EventArgs e)
        {
            registerPage.Show();
        }
    }
}
