using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ThreeM
{
    internal class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=threeM;User ID=root;Password=12345678;";

        // Hàm để lấy đối tượng kết nối 
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
