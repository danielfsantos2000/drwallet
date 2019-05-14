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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        public void settingsUpdate()
        {
            NavBar.nmPage = 5;
            setNavBar.NavbarUpdate();
            switch (User.uLanguage)
            {
                case 1: setLangBox.SelectedItem = "English"; break;
                case 2: setLangBox.SelectedItem = "Portuguese"; break;
            }
            switch (User.uTheme)
            {
                case 1: setThemeBox.SelectedItem = "DRWallet"; break;
                case 2: setThemeBox.SelectedItem = "Dark"; break;
                case 3: setThemeBox.SelectedItem = "Light"; break;
            }
        }

        private void AccSaveBox_Click(object sender, EventArgs e)
        {
            if (setLangBox.Text != "" && setThemeBox.Text != "")
            {
                try
                {
                    db.Open();
                    MySqlCommand cmdChange = new MySqlCommand();
                    cmdChange.Connection = db;
                    cmdChange.CommandText = "UPDATE settings SET setlanguage=@lang, settheme=@theme WHERE setowner=@id";

                    switch (setLangBox.Text)
                    {
                        case "English": cmdChange.Parameters.Add("@lang", MySqlDbType.String).Value = 1; User.uLanguage = 1; break;
                        case "Portuguese": cmdChange.Parameters.Add("@lang", MySqlDbType.String).Value = 2; User.uLanguage = 2; break;
                    }

                    switch (setThemeBox.Text)
                    {
                        case "DRWallet": cmdChange.Parameters.Add("@theme", MySqlDbType.String).Value = 1; User.uTheme = 1; break;
                        case "Dark": cmdChange.Parameters.Add("@theme", MySqlDbType.String).Value = 2; User.uTheme = 2; break;
                        case "Light": cmdChange.Parameters.Add("@theme", MySqlDbType.String).Value = 3; User.uTheme = 3;  break;
                    }

                    cmdChange.Parameters.Add("@id", MySqlDbType.String).Value = User.uID;
                    cmdChange.ExecuteNonQuery();

                    settingsUpdate();
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
