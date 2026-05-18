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
        public bool RegisterUser(string username, string password, string fullname)
        {
            try
            {
                string query = "INSERT INTO Users (Username, Password, FullName) VALUES (@user, @pass, @name)";
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@name", fullname);

                int result = cmd.ExecuteNonQuery();
                return result > 0; // Trả về true nếu thêm thành công
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            string query = "SELECT UserID, Username, Role FROM Users";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User
                        {
                            UserID = reader["UserID"].ToString(),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }
            finally { CloseConnection(); }
            return list;
        }

        public bool UpdateUserRole(string userID, string newRole)
        {
            string query = "UPDATE Users SET Role=@role WHERE UserID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@role", newRole);
                cmd.Parameters.AddWithValue("@id", userID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }

        public bool DeleteUser(string userID)
        {
            string query = "DELETE FROM Users WHERE UserID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }
    }
}
