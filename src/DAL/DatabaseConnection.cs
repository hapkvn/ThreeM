using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kiemtragiuaki.DAL
{
    internal class DatabaseConnection
    {
        // chuỗi kết nối
       private string connectionString = "server=localhost;port=3306;database=musicmanagerdb;uid=root;pwd=123456789;charset=utf8";

        protected MySqlConnection conn;
        public DatabaseConnection()
        {
            conn = new MySqlConnection(connectionString);
        }

        // hàm mở kết nối
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // hàm đóng kết nối
        public void CloseConnection() 
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
