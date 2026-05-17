using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.BUS
{
    public class AlbumBUS
    {
        private AlbumDAL albumDAL = new AlbumDAL();

        public bool TaoAlbumMoi(string tenAlbum, string userID)
        {
            if (string.IsNullOrWhiteSpace(tenAlbum)) return false;
            return albumDAL.CreateAlbum(tenAlbum, userID);
        }

        public List<UserAlbumDTO> LayDanhSachAlbum(string userID)
        {
            return albumDAL.GetUserAlbums(userID);
        }

        public bool ThemNhacVaoAlbum(string albumID, string songID)
        {
            //Có thể kiểm tra xem bài hát đã tồn tại trong album này chưa
            return albumDAL.AddSongToAlbum(albumID, songID);
        }

        public bool XoaAlbum(string albumID)
        {
            if (string.IsNullOrEmpty(albumID)) return false;
            return albumDAL.DeleteAlbum(albumID);
        }

        public List<Song> LayNhacTrongAlbum(string albumID)
        {
            if (string.IsNullOrEmpty(albumID)) return new List<Song>();

            return albumDAL.GetSongsFromAlbum(albumID);
        }
    }
}
