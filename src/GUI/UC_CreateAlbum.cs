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
    public partial class UC_CreateAlbum : UserControl
    {
        // Định nghĩa 2 hành động để báo cho UC_Library (cha) biết kết quả
        public Action<string> OnConfirm { get; set; }
        public Action OnCancel { get; set; }
        public UC_CreateAlbum()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string albumName = txtAlbumName.Text.Trim();

            // Kiểm tra nếu người dùng để trống hoặc chỉ gõ dấu cách
            if (string.IsNullOrEmpty(albumName))
            {
                MessageBox.Show("Vui lòng nhập tên Album!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlbumName.Focus(); // Đưa con trỏ chuột quay lại ô nhập
                return;
            }

            // Gửi tên album ra bên ngoài cho lớp cha xử lý tiếp dữ liệu
            OnConfirm?.Invoke(albumName);

            // Xóa trống ô nhập để chuẩn bị cho lần tạo sau
            txtAlbumName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAlbumName.Clear(); // Xóa chữ đã gõ dở (nếu có)
            OnCancel?.Invoke();   // Báo cho lớp cha biết người dùng đã hủy
        }
    }
}
