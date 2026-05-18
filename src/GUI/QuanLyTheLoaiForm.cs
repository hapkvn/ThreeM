using System;
using System.Drawing;
using System.Windows.Forms;
using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;

namespace Kiemtragiuaki.GUI
{
    public partial class QuanLyTheLoaiForm : Form
    {
        private CategoryBUS _categoryBUS = new CategoryBUS();
        private SongBUS _songBUS = new SongBUS();
        private string _selectedSongID = null;

        public QuanLyTheLoaiForm()
        {
            InitializeComponent();
            ApplyDarkTheme();
            LoadCategories();
            LoadSongs();
        }

        //Load danh sách bài hát 
        private void LoadSongs()
        {
            dgvSongs.DataSource = null;
            dgvSongs.DataSource = _songBUS.GetSongs();
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ẩn hết
            foreach (DataGridViewColumn col in dgvSongs.Columns)
                col.Visible = false;

            // Hiện các cột cần thiết
            if (dgvSongs.Columns["SongID"] != null)
            {
                dgvSongs.Columns["SongID"].Visible = true;
                dgvSongs.Columns["SongID"].FillWeight = 15;
            }

            if (dgvSongs.Columns["Title"] != null)
            {
                dgvSongs.Columns["Title"].Visible = true;
                dgvSongs.Columns["Title"].FillWeight = 45;
            }

            if (dgvSongs.Columns["Artist"] != null)
            {
                dgvSongs.Columns["Artist"].Visible = true;
                dgvSongs.Columns["Artist"].FillWeight = 30;
            }

            // Đổi CategoryID thành tên thể loại
            if (dgvSongs.Columns["CategoryID"] != null)
            {
                dgvSongs.Columns["CategoryID"].Visible = true;
                dgvSongs.Columns["CategoryID"].HeaderText = "Thể loại";

                foreach (DataGridViewRow row in dgvSongs.Rows)
                {
                    if (row.Cells["CategoryID"].Value != null)
                    {
                        string catID = row.Cells["CategoryID"].Value.ToString();

                        var category = _categoryBUS
                            .LayTatCaTheLoai()
                            .Find(c => c.CategoryID == catID);

                        if (category != null)
                        {
                            row.Cells["CategoryID"].Value = category.CategoryName;
                        }
                    }
                }
            }

            _selectedSongID = null;
            lblSelectedSong.Text = "← Bấm vào bài hát để chọn thể loại";
            comboBox1.SelectedIndex = -1;
        }

        // ── Load thể loại vào ComboBox ──────────────────────
        private void LoadCategories()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _categoryBUS.LayTatCaTheLoai();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.SelectedIndex = -1;
        }

        // ── Click vào bài hát → hiện tên + chọn thể loại ──
        private void dgvSongs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSongs.Rows[e.RowIndex];
            _selectedSongID = row.Cells["SongID"].Value?.ToString();
            string title = row.Cells["Title"].Value?.ToString();
            string catID = row.Cells["CategoryID"].Value?.ToString();

            lblSelectedSong.Text = $" {title}";
            comboBox1.SelectedValue = catID;
        }

        // ── Cập nhật thể loại cho bài hát đang chọn ────────
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedSongID))
            {
                MessageBox.Show("Hãy chọn một bài hát!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn thể loại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var songs = _songBUS.GetSongs();
                var song = songs.Find(s => s.SongID == _selectedSongID);
                if (song == null) return;

                song.CategoryID = comboBox1.SelectedValue?.ToString();
                _songBUS.UpdateSong(song);

                MessageBox.Show("Đã cập nhật thể loại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSongs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // ── Thêm thể loại mới ───────────────────────────────
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            string ten = txtTenTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Nhập tên thể loại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _categoryBUS.ThemTheLoai(new CategoryDTO { CategoryName = ten });
                MessageBox.Show($"Đã thêm \"{ten}\"!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTheLoai.Text = "";
                LoadCategories();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // ── Xóa thể loại đang chọn trong ComboBox ──────────
        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn thể loại cần xóa trong danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string catID = comboBox1.SelectedValue?.ToString();
            string catName = (comboBox1.SelectedItem as CategoryDTO)?.CategoryName;

            // Đếm số bài hát đang dùng thể loại này
            var baiHatLienQuan = _songBUS.GetSongs().FindAll(s => s.CategoryID == catID);
            string canhBao = baiHatLienQuan.Count > 0
                ? $"Xóa thể loại \"{catName}\"?\n\n⚠ Có {baiHatLienQuan.Count} bài hát đang dùng thể loại này, CategoryID của các bài đó sẽ bị xóa."
                : $"Xóa thể loại \"{catName}\"";

            if (MessageBox.Show(canhBao, "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Bước 1: Set CategoryID = null cho tất cả bài hát liên quan trước
                    foreach (var song in baiHatLienQuan)
                    {
                        song.CategoryID = null;
                        _songBUS.UpdateSong(song);
                    }

                    // Bước 2: Xóa thể loại (không còn bị FK chặn)
                    _categoryBUS.XoaTheLoai(catID);

                    MessageBox.Show("Đã xóa thể loại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    LoadSongs();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // ── Dark theme ──────────────────────────────────────
        private void ApplyDarkTheme()
        {
            Color bg = Color.FromArgb(25, 25, 25);
            Color green = Color.FromArgb(30, 215, 96);
            Color header = Color.FromArgb(18, 18, 18);

            dgvSongs.EnableHeadersVisualStyles = false;
            dgvSongs.BackgroundColor = bg;
            dgvSongs.BorderStyle = BorderStyle.None;
            dgvSongs.GridColor = Color.FromArgb(40, 40, 40);

            dgvSongs.DefaultCellStyle.BackColor = bg;
            dgvSongs.DefaultCellStyle.ForeColor = green;
            dgvSongs.DefaultCellStyle.SelectionBackColor = green;
            dgvSongs.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvSongs.ColumnHeadersDefaultCellStyle.BackColor = header;
            dgvSongs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSongs.ColumnHeadersDefaultCellStyle.SelectionBackColor = header;
            dgvSongs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvSongs.RowHeadersDefaultCellStyle.BackColor = bg;
            dgvSongs.RowHeadersDefaultCellStyle.ForeColor = green;
            dgvSongs.RowHeadersDefaultCellStyle.SelectionBackColor = green;
            dgvSongs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void QuanLyTheLoaiForm_Load(object sender, EventArgs e)
        {

        }
    }
}