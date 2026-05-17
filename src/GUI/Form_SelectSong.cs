using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class Form_SelectSong : Form
    {
        // Sử dụng đúng các lớp BUS bạn đang có
        private SongBUS songBUS = new SongBUS();
        private AlbumBUS albumBUS = new AlbumBUS();

        private string targetAlbumID;
        public Action OnSongAddedSuccess; // Gọi ngược về UC_Library để ép tải lại danh sách bài hát

        public Form_SelectSong(string albumID, string albumName)
        {
            InitializeComponent();
            this.targetAlbumID = albumID;
            this.Text = "Thêm nhạc vào Album: " + albumName;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form_SelectSong_Load);
        }

        private void Form_SelectSong_Load(object sender, EventArgs e)
        {
            LoadAllSongsToSelect();
        }

        private void LoadAllSongsToSelect()
        {
            flpSelectSongs.Controls.Clear();
            flpSelectSongs.BackColor = Color.FromArgb(25, 25, 25);
            flpSelectSongs.SuspendLayout();

            try
            {
                List<Song> allSongs = songBUS.GetSongs();
                List<Song> currentSongsInAlbum = albumBUS.LayNhacTrongAlbum(targetAlbumID);
                HashSet<string> existedSongIDs = new HashSet<string>();

                if (currentSongsInAlbum != null)
                {
                    foreach (var s in currentSongsInAlbum) existedSongIDs.Add(s.SongID);
                }

                int count = 1;
                foreach (var s in allSongs)
                {
                    UC_SongItem songUI = new UC_SongItem();
                    songUI.SetData(s, count++);

                    // 1. Ép chiều rộng theo Form
                    songUI.Width = this.ClientSize.Width - 35;
                    songUI.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

                    
                    songUI.Margin = new Padding(10, 4, 10, 4);

                    if (existedSongIDs.Contains(s.SongID))
                    {
                        songUI.Enabled = false;
                        songUI.BackColor = Color.FromArgb(45, 45, 45);
                    }
                    else
                    {
                        songUI.BackColor = Color.FromArgb(35, 35, 35);
                        songUI.OnPlayClick = (path) => {
                            bool success = albumBUS.ThemNhacVaoAlbum(targetAlbumID, s.SongID);
                            if (success)
                            {
                                OnSongAddedSuccess?.Invoke();
                                LoadAllSongsToSelect();
                            }
                            else
                            {
                                MessageBox.Show("Thêm bài hát thất bại!");
                            }
                        };
                    }

                    flpSelectSongs.Controls.Add(songUI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy bài hát: " + ex.Message);
            }
            finally
            {
                flpSelectSongs.ResumeLayout();
            }
        }
    }
}