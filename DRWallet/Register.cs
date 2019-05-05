using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DRWallet
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LogRegisterBox_Click(object sender, EventArgs e)
        {
            if (regFNameBox.Text != "" && regLNameBox.Text != "" && regUserBox.Text != "" && regEmailBox.Text != "" && regPassBox.Text != "" && regConfPassBox.Text != "")
            {
                if (isEmailValid(regEmailBox.Text))
                {
                    if (regPassBox.Text == regConfPassBox.Text)
                    {

                    } else {
                        regErrorLab.Location = new Point(234, 290);
                        regErrorLab.Text = "Passwords doesn't match!";
                        regErrorLab.Visible = true;
                    }
                } else {
                    regErrorLab.Location = new Point(186, 290);
                    regErrorLab.Text = "Email doesn't have a valid format!";
                    regErrorLab.Visible = true;
                }
            } else {
                regErrorLab.Location = new Point(240, 290);
                regErrorLab.Text = "You need to fill all fields!";
                regErrorLab.Visible = true;
            }
        }




        //Verify
        public bool isEmailValid(string emailaddress)
        {
            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
