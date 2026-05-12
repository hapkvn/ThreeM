using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Cần thiết để sử dụng Path.GetFileName

namespace Kiemtragiuaki.GUI
{
    public partial class UC_Library : UserControl
    {
        // Khai báo sự kiện để gửi đường dẫn nhạc về Form chính
        public Action<string> OnSongSelected;

        public UC_Library()
        {
            InitializeComponent();
            // Thiết lập font Arial đồng bộ cho bảng
            dgvMusic.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvMusic.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Music Files|*.mp3;*.wav;*.flac";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    string title = Path.GetFileNameWithoutExtension(filePath);
                    string artist = "Unknown Artist";
                    string album = "Unknown Album";

                    try
                    {
                        // Đọc Metadata từ file nhạc
                        var fileTag = TagLib.File.Create(filePath);

                        // Lấy tiêu đề (nếu file có tag Title thì lấy, không thì dùng tên file)
                        if (!string.IsNullOrEmpty(fileTag.Tag.Title))
                            title = fileTag.Tag.Title;

                        // Lấy tên nghệ sĩ (Contributing artists)
                        if (fileTag.Tag.Performers.Length > 0)
                            artist = string.Join(", ", fileTag.Tag.Performers);

                        // Lấy tên Album
                        if (!string.IsNullOrEmpty(fileTag.Tag.Album))
                            album = fileTag.Tag.Album;
                    }
                    catch
                    {
                        // Nếu file lỗi tag, giữ các giá trị mặc định
                    }

                    // Thêm vào DataGridView theo đúng thứ tự cột
                    dgvMusic.Rows.Add(dgvMusic.Rows.Count + 1, title, artist, album, filePath);
                }

                // Ẩn cột đường dẫn (Index 4)
                if (dgvMusic.Columns.Count >= 5)
                    dgvMusic.Columns[4].Visible = false;
            }
        }

        // Sự kiện click để chọn bài hát phát nhạc
        private void dgvMusic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Bây giờ đường dẫn nằm ở cột thứ 5 (Index là 4)
                var cellValue = dgvMusic.Rows[e.RowIndex].Cells[4].Value;

                if (cellValue != null)
                {
                    string selectedPath = cellValue.ToString();
                    OnSongSelected?.Invoke(selectedPath);
                }
            }
        }
    }
}