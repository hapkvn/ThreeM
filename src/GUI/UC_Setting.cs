using Kiemtragiuaki.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class UC_Setting : UserControl
    {

        private SongBUS songBUS = new SongBUS();
        public UC_Setting()
        {
            InitializeComponent();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Chọn thư mục chứa các file nhạc .mp3 của bạn";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn đã chọn lên TextBox
                    txtMusicFolderPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnScanNow_Click(object sender, EventArgs e)
        {
            string folderPath = txtMusicFolderPath.Text.Trim();
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Vui lòng chọn một thư mục hợp lệ trước khi quét!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3", SearchOption.TopDirectoryOnly);
                if (mp3Files.Length == 0)
                {
                    MessageBox.Show("Không tìm thấy file nhạc .mp3 nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Tuple<string, string, string, string>> scannedSongs = new List<Tuple<string, string, string, string>>();

                int count = 1;
                foreach (string filePath in mp3Files)
                {
                    string title = Path.GetFileNameWithoutExtension(filePath);
                    string standardizedPath = filePath.Replace("\\", "/");
                    string songID = "MS_" + count.ToString("D2");

                    scannedSongs.Add(new Tuple<string, string, string, string>(songID, title, standardizedPath, "CT_01"));
                    count++;
                }

                bool isSuccess = songBUS.CapNhatKhoNhac(scannedSongs);

                if (isSuccess)
                {
                    MessageBox.Show($"Cập nhật đường dẫn cho {mp3Files.Length} bài hát thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
