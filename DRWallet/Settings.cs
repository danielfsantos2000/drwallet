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
            //Update ID Settings
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

            //Language Options
            if (User.uLanguage == 1)
            {
                setSetLab.Text = DRWallet.Properties.Resources.EN_Set_Header;
                setLangLab.Location = new Point(279, 164);
                setLangLab.Text = $"{DRWallet.Properties.Resources.EN_Set_Language}:";
                setThemeLab.Location = new Point(323, 224);
                setThemeLab.Text = $"{DRWallet.Properties.Resources.EN_Set_Theme}:";
                setSaveBox.Text = DRWallet.Properties.Resources.EN_Set_SaveButton;
            }
            else if (User.uLanguage == 2)
            {
                setSetLab.Text = DRWallet.Properties.Resources.PT_Set_Header;
                setLangLab.Location = new Point(327, 164);
                setLangLab.Text = $"{DRWallet.Properties.Resources.PT_Set_Language}:";
                setThemeLab.Location = new Point(342, 224);
                setThemeLab.Text = $"{DRWallet.Properties.Resources.PT_Set_Theme}:";
                setSaveBox.Text = DRWallet.Properties.Resources.PT_Set_SaveButton;
            }

            //Theme Options
            if (User.uTheme == 1)
            {
                this.BackColor = Color.FromArgb(255, 255, 178, 102);
                setSetLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                setLangLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                setThemeLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                setSaveBox.BackColor = Color.FromArgb(255, 255, 160, 66);
                setSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 137, 25);
                setSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 149, 48);
            }
            else if (User.uTheme == 2)
            {
                this.BackColor = Color.FromArgb(255, 43, 43, 43);
                setSetLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                setLangLab.ForeColor = Color.FromArgb(255, 255, 255, 255);
                setThemeLab.ForeColor = Color.FromArgb(255, 255, 255, 255);

                setSaveBox.BackColor = Color.FromArgb(255, 145, 145, 145);
                setSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 81, 81, 81);
                setSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 114, 114, 114);
            }
            else if (User.uTheme == 3)
            {
                this.BackColor = Color.FromArgb(255, 255, 255, 255);
                setSetLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                setLangLab.ForeColor = Color.FromArgb(255, 0, 0, 0);
                setThemeLab.ForeColor = Color.FromArgb(255, 0, 0, 0);

                setSaveBox.BackColor = Color.FromArgb(255, 220, 220, 220);
                setSaveBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 168, 168, 168);
                setSaveBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 193, 193, 193);
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
                    MessageBox.Show("Something went wrong.\nError code: 0x000701");
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
