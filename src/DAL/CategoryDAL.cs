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
            finally { CloseConnection(); }
            return list;
        }

        public bool AddCategory(CategoryDTO c)
        {
            string query = "INSERT INTO Categories (CategoryID, CategoryName) VALUES (@id, @name)";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", c.CategoryID);
                cmd.Parameters.AddWithValue("@name", c.CategoryName);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }

        public bool UpdateCategory(CategoryDTO c)
        {
            string query = "UPDATE Categories SET CategoryName=@name WHERE CategoryID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", c.CategoryName);
                cmd.Parameters.AddWithValue("@id", c.CategoryID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }

        public bool DeleteCategory(string categoryID)
        {
            string query = "DELETE FROM Categories WHERE CategoryID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", categoryID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }
    }
}