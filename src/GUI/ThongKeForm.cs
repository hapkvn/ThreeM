using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;

namespace Kiemtragiuaki.GUI
{
    public partial class ThongKeForm : Form
    {
        private SongBUS _songBUS = new SongBUS();
        private CategoryBUS _categoryBUS = new CategoryBUS();
        private UserBUS _userBUS = new UserBUS();

        public ThongKeForm()
        {
            InitializeComponent();
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            var songs = _songBUS.GetSongs();
            var categories = _categoryBUS.LayTatCaTheLoai();
            var users = _userBUS.GetAllUsers();

            // ── Số liệu tổng quan ──
            lblTongBaiHat.Text = songs.Count.ToString();
            lblTongTheLoai.Text = categories.Count.ToString();
            lblTongUser.Text = users.Count.ToString();
            lblTongAdmin.Text = users.Count(u => u.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase)).ToString();

            // ── Bài hát theo thể loại ──
            dgvThongKe.Rows.Clear();
            foreach (var cat in categories)
            {
                int soLuong = songs.Count(s => s.CategoryID == cat.CategoryID);
                dgvThongKe.Rows.Add(cat.CategoryID, cat.CategoryName, soLuong);
            }

            // Bài hát chưa có thể loại
            int chuaXepLoai = songs.Count(s => string.IsNullOrEmpty(s.CategoryID));
            if (chuaXepLoai > 0)
                dgvThongKe.Rows.Add("—", "Chưa xếp loại", chuaXepLoai);
        }
    }
}