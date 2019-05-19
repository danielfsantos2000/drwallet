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
            if (User.uLanguage == 1)
            {
                navDashboardButton.Text = DRWallet.Properties.Resources.EN_Nav_Dashboard;
                navMovementsButton.Text = DRWallet.Properties.Resources.EN_Nav_Movements;
                navAddressesButton.Text = DRWallet.Properties.Resources.EN_Nav_Addresses;
                navAccountButton.Text = DRWallet.Properties.Resources.EN_Nav_Account;
                navSettingsButton.Text = DRWallet.Properties.Resources.EN_Nav_Settings;
            }
            else if (User.uLanguage == 2)
            {
                navDashboardButton.Text = DRWallet.Properties.Resources.PT_Nav_Dashboard;
                navMovementsButton.Text = DRWallet.Properties.Resources.PT_Nav_Movements;
                navAddressesButton.Text = DRWallet.Properties.Resources.PT_Nav_Addresses;
                navAccountButton.Text = DRWallet.Properties.Resources.PT_Nav_Account;
                navSettingsButton.Text = DRWallet.Properties.Resources.PT_Nav_Settings;
            }

            //Theme Options
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 125, 0);

                navDashboardButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
                navDashboardButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                navDashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                navDashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                navMovementsButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
                navMovementsButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                navMovementsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                navMovementsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                navAddressesButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
                navAddressesButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                navAddressesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                navAddressesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                navAccountButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
                navAccountButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                navAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                navAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);

                navSettingsButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
                navSettingsButton.BackColor = Color.FromArgb(255, 255, 160, 66);
                navSettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                navSettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 35, 35, 35);

                navDashboardButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navDashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navDashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                navMovementsButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navMovementsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navMovementsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                navAddressesButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navAddressesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navAddressesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                navAccountButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);

                navSettingsButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navSettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navSettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 188, 188, 188);

                navDashboardButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navDashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                navDashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                navMovementsButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navMovementsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                navMovementsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                navAddressesButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navAddressesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                navAddressesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                navAccountButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                navAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);

                navSettingsButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navSettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                navSettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
            }

            if (User.uTheme == 1)
            {
                navDashboardButton.BackColor = Color.FromArgb(255, 255, 164, 76);
                navMovementsButton.BackColor = Color.FromArgb(255, 255, 164, 76);
                navAddressesButton.BackColor = Color.FromArgb(255, 255, 164, 76);
                navAccountButton.BackColor = Color.FromArgb(255, 255, 164, 76);
                navSettingsButton.BackColor = Color.FromArgb(255, 255, 164, 76);
                switch (uPage)
                {
                    case 1:
                        navDashboardButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 2:
                        navMovementsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 3:
                        navAddressesButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 4:
                        navAccountButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 5:
                        navSettingsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                }
            }
            else if (User.uTheme == 2)
            {
                navDashboardButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navMovementsButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navAddressesButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navAccountButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                navSettingsButton.BackColor = Color.FromArgb(255, 145, 145, 145);
                switch (uPage)
                {
                    case 1:
                        navDashboardButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 2:
                        navMovementsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 3:
                        navAddressesButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 4:
                        navAccountButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 5:
                        navSettingsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                }
            }
            else if (User.uTheme == 3)
            {
                navDashboardButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navMovementsButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navAddressesButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navAccountButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                navSettingsButton.BackColor = Color.FromArgb(255, 220, 220, 220);
                switch (uPage)
                {
                    case 1:
                        navDashboardButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 2:
                        navMovementsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 3:
                        navAddressesButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 4:
                        navAccountButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                    case 5:
                        navSettingsButton.BackColor = Color.FromArgb(0, 0, 0, 0);
                        break;
                }
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
