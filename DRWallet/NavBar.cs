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

        //Dashboard
        public delegate void GotoNavDashEventHandler(object source, EventArgs args);
        public static event GotoNavDashEventHandler GotoNavDash;

        private void NavDashboardButton_Click(object sender, EventArgs e)
        {
            OnNavButtonClicked();
        }
        protected virtual void OnNavButtonClicked()
        {
            if (GotoNavDash != null)
            {
                GotoNavDash(this, EventArgs.Empty);
            }
        }

        //Movements
        public delegate void GotoNavMoveEventHandler(object source, EventArgs args);
        public static event GotoNavMoveEventHandler GotoNavMove;

        private void NavMovementsButton_Click(object sender, EventArgs e)
        {
            OnMoveButtonClicked();
        }
        protected virtual void OnMoveButtonClicked()
        {
            if (GotoNavMove != null)
            {
                GotoNavMove(this, EventArgs.Empty);
            }
        }

        //Addresses
        public delegate void GotoNavAddEventHandler(object source, EventArgs args);
        public static event GotoNavAddEventHandler GotoNavAdd;

        private void NavAddressesButton_Click(object sender, EventArgs e)
        {
            OnAddButtonClicked();
        }
        protected virtual void OnAddButtonClicked()
        {
            if (GotoNavAdd != null)
            {
                GotoNavAdd(this, EventArgs.Empty);
            }
        }

        //Account
        public delegate void GotoNavAccEventHandler(object source, EventArgs args);
        public static event GotoNavAccEventHandler GotoNavAcc;

        private void NavAccountButton_Click(object sender, EventArgs e)
        {
            OnAccButtonClicked();
        }
        protected virtual void OnAccButtonClicked()
        {
            if (GotoNavAcc != null)
            {
                GotoNavAcc(this, EventArgs.Empty);
            }
        }

        //Settings
        public delegate void GotoNavSetEventHandler(object source, EventArgs args);
        public static event GotoNavSetEventHandler GotoNavSet;

        private void NavSettingsButton_Click(object sender, EventArgs e)
        {
            OnSetButtonClicked();
        }
        protected virtual void OnSetButtonClicked()
        {
            if (GotoNavSet != null)
            {
                GotoNavSet(this, EventArgs.Empty);
            }
        }
    }
}
