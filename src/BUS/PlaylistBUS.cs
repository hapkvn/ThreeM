using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiemtragiuaki.DTO;
using Kiemtragiuaki.DAL;

namespace Kiemtragiuaki.BUS
{
    public class PlaylistBUS
    {
        private PlaylistDAL playlistDAL = new PlaylistDAL();

        // Thêm bài hát vào Album cá nhân
        public string ThemVaoAlbum(string userID, string songID)
        {
            // 1. Kiểm tra ID đầu vào
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(songID))
                return "Dữ liệu không hợp lệ!";

            // 2. Kiểm tra trùng lặp
            if (playlistDAL.IsSongInPlaylist(userID, songID))
                return "Bài hát này đã có trong Album của bạn rồi!";

            // 3. Thực hiện thêm
            if (playlistDAL.AddToPlaylist(userID, songID))
                return "Thành công";

            return "Lỗi: Không thể thêm vào cơ sở dữ liệu!";
        }

        // Lấy danh sách nhạc trong Album
        public List<Song> LayAlbumCuaToi(string userID)
        {
            if (string.IsNullOrEmpty(userID)) return new List<Song>();
            return playlistDAL.GetSongsFromPlaylist(userID);
        }
    }
}
