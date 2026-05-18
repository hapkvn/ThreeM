using Kiemtragiuaki.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki.DAL
{
    internal class AlbumDAL : DatabaseConnection
    {
        // Hàm tạo ID string ngẫu nhiên hoặc theo thứ tự
        private string GenerateAlbumID()
        {
            return "ALB_" + DateTime.Now.ToString("mmss");
        }

        public bool CreateAlbum(string albumName, string userID)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO UserAlbums (AlbumID, AlbumName, UserID) VALUES (@aid, @name, @uid)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@aid", GenerateAlbumID());
                cmd.Parameters.AddWithValue("@name", albumName);
                cmd.Parameters.AddWithValue("@uid", userID);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tại AlbumDAL.CreateAlbum: " + ex.Message);
            }
            finally { CloseConnection(); }
        }


        public bool DeleteAlbum(string albumID)
        {
            MySqlTransaction trans = null;
            try
            {
                OpenConnection();
                // Tạo Transaction để bảo đảm xóa sạch cả 2 bảng, nếu một bảng lỗi sẽ tự phục hồi (Rollback)
                trans = conn.BeginTransaction();

                // 1. Xóa tất cả các liên kết bài hát nằm trong Album này ở bảng trung gian trước
                // (Bạn hãy đổi tên bảng 'AlbumSongs' thành đúng tên bảng chứa nhạc trong album của bạn nhé)
                string sqlDeleteSongs = "DELETE FROM AlbumSongs WHERE AlbumID = @aid";
                MySqlCommand cmdSongs = new MySqlCommand(sqlDeleteSongs, conn, trans);
                cmdSongs.Parameters.AddWithValue("@aid", albumID);
                cmdSongs.ExecuteNonQuery();

                // 2. Xóa chính Album đó ở bảng UserAlbums
                string sqlDeleteAlbum = "DELETE FROM UserAlbums WHERE AlbumID = @aid";
                MySqlCommand cmdAlbum = new MySqlCommand(sqlDeleteAlbum, conn, trans);
                cmdAlbum.Parameters.AddWithValue("@aid", albumID);

                bool success = cmdAlbum.ExecuteNonQuery() > 0;

                // Xác nhận hoàn thành xóa sạch
                trans.Commit();
                return success;
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw new Exception("Lỗi tại AlbumDAL.DeleteAlbum: " + ex.Message);
            }
            finally { CloseConnection(); }
        }
        public List<UserAlbumDTO> GetUserAlbums(string userID)
        {
            List<UserAlbumDTO> list = new List<UserAlbumDTO>();
            try
            {
                OpenConnection();
                string sql = "SELECT * FROM UserAlbums WHERE UserID = @uid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new UserAlbumDTO
                        {
                            AlbumID = r["AlbumID"].ToString(),
                            AlbumName = r["AlbumName"].ToString(),
                            UserID = r["UserID"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex) {
                throw new Exception("Lỗi tại AlbumDAL.GetUserAlbums: " + ex.Message);
            }
            finally { CloseConnection(); }
            return list;
        }

        // Hàm thêm bài hát vào một Album cụ thể
        public bool AddSongToAlbum(string albumID, string songID)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO AlbumSongs (AlbumID, SongID) VALUES (@aid, @sid)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@aid", albumID);
                cmd.Parameters.AddWithValue("@sid", songID);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
            finally { CloseConnection(); }
        }

        public List<Song> GetSongsFromAlbum(string albumID)
        {
            List<Song> list = new List<Song>();
            try
            {
                OpenConnection();
                // Lệnh SQL JOIN: Lấy thông tin từ bảng Songs thông qua bảng trung gian AlbumSongs
                string sql = @"SELECT s.SongID, s.Title, s.Artist, s.FilePath 
                       FROM Songs s 
                       JOIN AlbumSongs asg ON s.SongID = asg.SongID 
                       WHERE asg.AlbumID = @aid";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@aid", albumID);

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
                MessageBox.Show("lỗi" +ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
    }
}
