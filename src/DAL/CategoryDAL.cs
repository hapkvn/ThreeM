using Kiemtragiuaki.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Kiemtragiuaki.DAL
{
    internal class CategoryDAL : DatabaseConnection
    {
        public List<CategoryDTO> GetAllCategories()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            string query = "SELECT * FROM Categories";

            try
            {
                // Mở kết nối từ lớp cha
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CategoryDTO
                        {
                            CategoryID = reader["CategoryID"].ToString(),
                            CategoryName = reader["CategoryName"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thể loại: " + ex.Message);
            }
            finally
            {
                // Luôn đóng kết nối để tránh quá tải Database
                CloseConnection();
            }
            return list;
        }
    }
}