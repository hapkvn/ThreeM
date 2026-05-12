using Kiemtragiuaki.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.DAL
{
    internal class SongDAL : DatabaseConnection
    {
        public List<Song> GetAllSongs()
        {
            List<Song> list = new List<Song>();
            string query = "SELECT * FROM Songs";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Song
                        {
                            SongID = reader["SongID"].ToString(),
                            Title = reader["Title"].ToString(),
                            Artist = reader["Artist"].ToString(),
                            FilePath = reader["FilePath"].ToString(),
                            CategoryID = reader["CategoryID"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; // Hoặc xử lý lỗi tùy ý
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
    }
}
