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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegGotoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnRegButtonClicked();
        }

        private void LogLoginButton_Click(object sender, EventArgs e)
        {

        }


        //Events
        public delegate void GotoPageEventHandler(object source, EventArgs args);
        public event GotoPageEventHandler GotoPage;

        protected virtual void OnRegButtonClicked()
        {
            if (GotoPage != null)
            {
                GotoPage(this, EventArgs.Empty);
            }
        }
    }
}
