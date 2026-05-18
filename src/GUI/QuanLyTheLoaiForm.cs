using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;

namespace Kiemtragiuaki.GUI
{
    public partial class QuanLyTheLoaiForm : Form
    {
        private CategoryBUS _bus = new CategoryBUS();

        public QuanLyTheLoaiForm()
        {
            InitializeComponent();
            CauHinhComboBox();
            LoadDanhSach();
        }

        private void CauHinhComboBox()
        {
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = _bus.LayTatCaTheLoai();
            comboBox1.SelectedIndex = -1;
        }

        private void LoadDanhSach()
        {
            dgvSongs.DataSource = null;
            dgvSongs.DataSource = new SongBUS().GetSongs();
        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSongs.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Title"].Value?.ToString();
            textBox2.Text = row.Cells["Artist"].Value?.ToString();
            textBox3.Text = row.Cells["FilePath"].Value?.ToString();
            comboBox1.SelectedValue = row.Cells["CategoryID"].Value?.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Audio|*.mp3;*.wav;*.flac" })
                if (dlg.ShowDialog() == DialogResult.OK)
                    textBox3.Text = dlg.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                new SongBUS().AddSong(new Song
                {
                    Title = textBox1.Text.Trim(),
                    Artist = textBox2.Text.Trim(),
                    FilePath = textBox3.Text.Trim(),
                    CategoryID = comboBox1.SelectedValue?.ToString()
                });
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(); ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn bài hát cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                new SongBUS().UpdateSong(new Song
                {
                    SongID = dgvSongs.CurrentRow.Cells["SongID"].Value?.ToString(),
                    Title = textBox1.Text.Trim(),
                    Artist = textBox2.Text.Trim(),
                    FilePath = textBox3.Text.Trim(),
                    CategoryID = comboBox1.SelectedValue?.ToString()
                });
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(); ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn bài hát cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvSongs.CurrentRow.Cells["SongID"].Value?.ToString();
            string title = dgvSongs.CurrentRow.Cells["Title"].Value?.ToString();
            if (MessageBox.Show($"Xóa bài \"{title}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new SongBUS().DeleteSong(id);
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach(); ClearForm();
            }
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            dgvSongs.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}