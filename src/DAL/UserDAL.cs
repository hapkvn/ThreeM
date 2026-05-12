using Kiemtragiuaki.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.DAL
{
    internal class UserDAL : DatabaseConnection
    {
        public User Login(string user, string pass)
        {
            User account = null;
            string query = "SELECT * FROM Users WHERE Username=@user AND Password=@pass";

            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    account = new User
                    {
                        UserID = reader["UserID"].ToString(),
                        Username = reader["Username"].ToString(),
                        Role = reader["Role"].ToString()
                    };
                }
            }
            CloseConnection();
            return account;
        }
    }
}
