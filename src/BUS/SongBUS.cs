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


    }
}
