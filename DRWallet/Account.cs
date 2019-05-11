﻿using System;
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
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        public void accountUpdate()
        {
            NavBar.nmPage = 4;
            accNavBar.NavbarUpdate();

            accFNameBox.Text = User.uFName;
            accLNameBox.Text = User.uLName;
            accEmailBox.Text = User.uEmail;
        }

        private void AccSaveBox_Click(object sender, EventArgs e)
        {

            if (accFNameBox.Text != "" && accLNameBox.Text != "" && accEmailBox.Text != "")
            {
                try
                {
                    db.Open();
                    MySqlCommand cmdChange = new MySqlCommand();
                    cmdChange.Connection = db;
                    cmdChange.CommandText = "UPDATE users SET userfname=@fname, userlname=@lname, useremail=@email WHERE userid=@id";
                    cmdChange.Parameters.Add("@fname", MySqlDbType.String).Value = accFNameBox.Text;
                    cmdChange.Parameters.Add("@lname", MySqlDbType.String).Value = accLNameBox.Text;
                    cmdChange.Parameters.Add("@email", MySqlDbType.String).Value = accEmailBox.Text;
                    cmdChange.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                    cmdChange.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    db.Close();
                }
            }
        }


        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
