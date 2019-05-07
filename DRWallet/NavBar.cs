using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRWallet
{
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
            uPage = 0;
        }

        private static int uPage;
        public static int nmPage {
            get
            {
                return uPage;
            }
            set
            {
                uPage = value;
            }
        }


        public void NavbarUpdate()
        {
            navDashboardButton.BackColor = Color.FromArgb(255, 255, 164, 76);
            navMovementsButton.BackColor = Color.FromArgb(255, 255, 164, 76);
            navAddressesButton.BackColor = Color.FromArgb(255, 255, 164, 76);
            navAccountButton.BackColor = Color.FromArgb(255, 255, 164, 76);
            navSettingsButton.BackColor = Color.FromArgb(255, 255, 164, 76);
            switch (uPage)
            {
                case 1: navDashboardButton.BackColor = Color.FromArgb(0, 252, 138, 27); break;
                case 2: navMovementsButton.BackColor = Color.FromArgb(0, 252, 138, 27); break;
                case 3: navAddressesButton.BackColor = Color.FromArgb(0, 252, 138, 27); break;
                case 4: navAccountButton.BackColor = Color.FromArgb(0, 252, 138, 27); break;
                case 5: navSettingsButton.BackColor = Color.FromArgb(0, 252, 138, 27); break;
            }
        }
    }
}
