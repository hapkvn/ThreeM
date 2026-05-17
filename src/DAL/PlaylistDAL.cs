using Kiemtragiuaki.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.DAL
{
    internal class PlaylistDAL : DatabaseConnection
    {
        // 1. Thêm bài hát vào Album
        public bool AddToPlaylist(string userID, string songID)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO Playlists (UserID, SongID) VALUES (@uid, @sid)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@sid", songID);

                return cmd.ExecuteNonQuery() > 0;
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

        // 2. Lấy danh sách bài hát trong Album của User
        public List<Song> GetSongsFromPlaylist(string userID)
        {
            List<Song> list = new List<Song>();
            try
            {
                OpenConnection();
                // JOIN bảng Songs để lấy thông tin chi tiết bài hát
                string sql = @"SELECT s.SongID, s.Title, s.Artist, s.FilePath 
                               FROM Songs s 
                               JOIN Playlists p ON s.SongID = p.SongID 
                               WHERE p.UserID = @uid";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);

                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Song s = new Song
                        {
                            SongID = r["SongID"].ToString(),
                            Title = r["Title"].ToString(),
                            Artist = r["Artist"].ToString(),
                            FilePath = r["FilePath"].ToString()
                        };
                        list.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }

        // 3. Kiểm tra bài hát đã có trong Album chưa (Tránh trùng lặp)
        public bool IsSongInPlaylist(string userID, string songID)
        {
            try
            {
                OpenConnection();
                string sql = "SELECT COUNT(*) FROM Playlists WHERE UserID = @uid AND SongID = @sid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@sid", songID);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch { return false; }
            finally { CloseConnection(); }
        }
    }
}
