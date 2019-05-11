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
        }
    }
}
