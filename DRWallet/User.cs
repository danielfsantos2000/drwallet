using System;
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

            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
