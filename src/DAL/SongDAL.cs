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
                            CategoryID = reader["CategoryID"] == DBNull.Value ? null : reader["CategoryID"].ToString()
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

        public List<Song> GetSongsByCategoryID(string categoryID)
        {
            List<Song> list = new List<Song>();
            string query = "SELECT * FROM songs WHERE CategoryID = @catID";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@catID", categoryID);

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
                            CategoryID = reader["CategoryID"] == DBNull.Value ? null : reader["CategoryID"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            finally { CloseConnection(); }
            return list;
        }


        public bool RefreshMusicLibrary(List<Tuple<string, string, string, string>> scannedSongs)
        {
            MySqlTransaction trans = null;
            try
            {
                OpenConnection();
                trans = conn.BeginTransaction();


                string sql = @"INSERT INTO songs (SongID, Title, Artist, FilePath, CategoryID) 
                       VALUES (@id, @title, @artist, @path, @catID)
                       ON DUPLICATE KEY UPDATE 
                            FilePath = @path, 
                            Title = @title;";

                foreach (var song in scannedSongs)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn, trans);
                    cmd.Parameters.AddWithValue("@id", song.Item1);
                    cmd.Parameters.AddWithValue("@title", song.Item2);
                    cmd.Parameters.AddWithValue("@artist", "Unknown");
                    cmd.Parameters.AddWithValue("@path", song.Item3);
                    cmd.Parameters.AddWithValue("@catID", song.Item4);

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw new Exception("Lỗi cập nhật kho nhạc: " + ex.Message);
            }
            finally { CloseConnection(); }
        }
        public bool AddSong(Song s)
        {
            string query = "INSERT INTO Songs (SongID, Title, Artist, FilePath, CategoryID) VALUES (@id, @title, @artist, @path, @catID)";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", s.SongID);
                cmd.Parameters.AddWithValue("@title", s.Title);
                cmd.Parameters.AddWithValue("@artist", s.Artist);
                cmd.Parameters.AddWithValue("@path", s.FilePath);
                cmd.Parameters.AddWithValue("@catID", s.CategoryID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }

        public bool UpdateSong(Song s)
        {
            string query = "UPDATE Songs SET Title=@title, Artist=@artist, FilePath=@path, CategoryID=@catID WHERE SongID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", s.SongID);
                cmd.Parameters.AddWithValue("@title", s.Title);
                cmd.Parameters.AddWithValue("@artist", s.Artist);
                cmd.Parameters.AddWithValue("@path", s.FilePath);
                cmd.Parameters.AddWithValue("@catID", s.CategoryID == null ? (object)DBNull.Value : s.CategoryID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }

        public bool DeleteSong(string songID)
        {
            string query = "DELETE FROM Songs WHERE SongID=@id";
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", songID);
                return cmd.ExecuteNonQuery() > 0;
            }
            finally { CloseConnection(); }
        }
    }
}