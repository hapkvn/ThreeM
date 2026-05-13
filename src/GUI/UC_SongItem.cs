using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class UC_SongItem : UserControl
    {

        // 1. Khai báo sự kiện truyền đường dẫn ra ngoài
        public Action<string> OnPlayClick;
        public UC_SongItem()
        {
            InitializeComponent();
        }

        public void SetData(Song s, int index)
        {
            lblSTT.Text = index.ToString("D2"); // Hiện 01, 02...
            lblTitle.Text = s.Title;
            lblArtist.Text = s.Artist;
            this.Tag = s.FilePath; 
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {
            // Khi bấm Play, lấy FilePath từ Tag và gửi đi
            if (this.Tag != null)
            {
                OnPlayClick?.Invoke(this.Tag.ToString());
            }
        }
    }
}
