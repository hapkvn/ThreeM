using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// mọi lớp BUS có chức năng kiểm tra dữ liệu
namespace Kiemtragiuaki.BUS
{
    internal class SongBUS
    {
        private SongDAL _songDAL = new SongDAL();

        // Hàm lấy toàn bộ danh sách bài hát
        public List<Song> GetSongs()
        {
            return _songDAL.GetAllSongs();
        }

       
        public bool AddNewSong(Song s)
        {
            
            if (string.IsNullOrEmpty(s.Title)) return false; // Không cho để trống tiêu đề

            return true;
        }

        public List<Song> GetSongsByCategoryID(string categoryID)
        {
           
            return _songDAL.GetSongsByCategoryID(categoryID);
        }

        public bool CapNhatKhoNhac(List<Tuple<string, string, string, string>> scannedSongs)
        {
            if (scannedSongs == null || scannedSongs.Count == 0) return false;

            return _songDAL.RefreshMusicLibrary(scannedSongs);
        }
        public bool AddSong(Song s)
        {
            if (string.IsNullOrEmpty(s.Title) || string.IsNullOrEmpty(s.FilePath))
                throw new Exception("Tiêu đề và đường dẫn file không được để trống.");
            if (string.IsNullOrEmpty(s.SongID))
                s.SongID = "MS_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            return _songDAL.AddSong(s);
        }

        public bool UpdateSong(Song s)
        {
            if (string.IsNullOrEmpty(s.Title))
                throw new Exception("Tiêu đề không được để trống.");
            return _songDAL.UpdateSong(s);
        }

        public bool DeleteSong(string songID)
        {
            if (string.IsNullOrEmpty(songID))
                throw new Exception("Không tìm thấy bài hát.");
            return _songDAL.DeleteSong(songID);
        }

    }
}
