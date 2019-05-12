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
            catch(Exception ex)
            {

            }
            finally
            {
                db.Close();
            }
        }
    }
}
