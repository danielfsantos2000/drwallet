using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRWallet
{
    static class Encryption
    {
        public static string encrypt(string text)
        {
            string encryptedpass = "";

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            text = new string(charArray);

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    encryptedpass += text[i] + 7;
                }
                else
                {
                    encryptedpass += text[i] + 2;
                }
            }
            return encryptedpass;
        }

        public static string hash(double sender_id, double receiver_id, double value)
        {
            string lasthash = "";
            string hashedstring = "";
            int movid = 0;

            try
            {
                db.Open();
                MySqlCommand cmds1 = new MySqlCommand();
                cmds1.Connection = db;
                cmds1.CommandText = "SELECT movid,movhash FROM movements ORDER BY movid DESC LIMIT 1";
                MySqlDataReader drs1 = cmds1.ExecuteReader();

                if (drs1.HasRows)
                {
                    while (drs1.Read())
                    {
                        lasthash = drs1["movhash"].ToString();
                        int.TryParse(drs1["movid"].ToString(), out movid);
                    }
                }
                else
                {
                    lasthash = "firsthash";
                }

                drs1.Close();
            }
            catch
            {

            }
            finally
            {
                db.Close();
            }

            movid++;

            string hashedvalue = $"DRWID:{movid}S:{sender_id}R:{receiver_id}LH:{lasthash}V:{value}";
            char[] charArray = hashedvalue.ToCharArray();
            Array.Reverse(charArray);
            hashedvalue = new string(charArray);

            for (int i = 0; i < hashedvalue.Length; i++)
            {
                hashedstring += hashedvalue[i] + i;
            }

            return hashedstring;
        }

        //Database conections and functions
        private static string _connectionString = "Server=127.0.0.1;Database=drwallet;Uid=root;Pwd=;";
        private static MySqlConnection db = new MySqlConnection(_connectionString);
    }
}
