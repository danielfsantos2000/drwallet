using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DRWallet
{
    public static class Logs
    {

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        public static void AddRegisterLog(string username)
        {
            try
            {
                string info = $"User Registered: {username}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (1,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void AddLoginLog(int username)
        {
            try
            {
                string info = $"Logged in: {username}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (2,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void AddAddressLog(int username, int address)
        {
            try
            {
                string info = $"New Address: {username}, Number: {address}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (4,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void RemAddressLog(int username, string address)
        {
            try
            {
                string info = $"Removed Address: {username}, Number: {address}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (5,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void ChangeAccountLog(int username, string fname, string lname, string email)
        {
            try
            {
                string info = $"Changed Account: {username}, First name: {fname}, Last Name: {lname}, Email: {email}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (6,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void ChangePasswordLog(int username)
        {
            try
            {
                string info = $"Changed Password: {username}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (7,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void AddSettingsLog(int username)
        {
            try
            {
                string info = $"Created Settings: {username}, Language: English, Theme: DRWallet";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (8,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }

        public static void ChangeSettingsLog(int username, string language, string theme)
        {
            try
            {
                string info = $"Changed Settings: {username}, Language: {language}, Theme: {theme}";

                db.Open();
                MySqlCommand cmdLogInsert = new MySqlCommand();
                cmdLogInsert.Connection = db;
                cmdLogInsert.CommandText = "INSERT INTO logs (logtype,loginfo) VALUES (9,@info)";
                cmdLogInsert.Parameters.Add("@info", MySqlDbType.String).Value = info;
                int numbers = cmdLogInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }
        }
    }
}
