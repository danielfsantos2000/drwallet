using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DRWallet
{
    public static class User
    {

        private static int puID;
        private static string puUser;
        private static string puFName;
        private static string puLName;
        private static string puEmail;

        public static int uID
        {
            get
            {
                return puID;
            }
            set
            {
                puID = value;
            }
        }

        public static string uUser {
            get
            {
                return puUser;
            }
            set
            {
                puUser = value;
            }
        }

        public static string uFName {
            get
            {
                return puFName;
            }
            set
            {
                puFName = value;
            }
        }

        public static string uLName
        {
            get
            {
                return puLName;
            }
            set
            {
                puLName = value;
            }
        }

        public static string uEmail
        {
            get
            {
                return puEmail;
            }
            set
            {
                puEmail = value;
            }
        }

        public static ArrayList addresses = new ArrayList();

        //Settings
        private static int puLanguage;
        private static int puTheme;

        public static int uLanguage
        {
            get
            {
                return puLanguage;
            }
            set
            {
                puLanguage = value;
            }
        }

        public static int uTheme
        {
            get
            {
                return puTheme;
            }
            set
            {
                puTheme = value;
            }
        }


        //Updater
        public static void updateInfo()
        {
            try
            {
                db.Open();
                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT * FROM address WHERE userid=@userid";
                cmds1.Parameters.Add("@userid", MySqlDbType.String).Value = puID;
                MySqlDataReader drs1 = cmds1.ExecuteReader();
                if (drs1.HasRows)
                {
                    while (drs1.Read())
                    {
                        addresses.Add(drs1["addid"].ToString());
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                db.Close();
            }
        }

        public static void logout()
        {
            puID = 0;
            puUser = "";
            puEmail = "";
            puFName = "";
            puLName = "";
            puLanguage = 1;
            puTheme = 1;
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
