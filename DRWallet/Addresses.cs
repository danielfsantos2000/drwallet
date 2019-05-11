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
    public partial class Addresses : UserControl
    {
        public Addresses()
        {
            InitializeComponent();
        }

        public void addressesUpdate()
        {
            NavBar.nmPage = 3;
            addNavBar.NavbarUpdate();
        }
    }
}
