﻿using System;
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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        //Event
        public delegate void GotoPageEventHandler(object source, EventArgs args);
        public event GotoPageEventHandler GotoPage;

        protected virtual void OnButtonClicked()
        {
            if (GotoPage != null)
            {
                GotoPage(this, EventArgs.Empty);
            }
        }
    }
}