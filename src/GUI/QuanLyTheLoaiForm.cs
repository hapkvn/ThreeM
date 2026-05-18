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

            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvSongs.Columns["SongID"] != null) dgvSongs.Columns["SongID"].FillWeight = 15;
            if (dgvSongs.Columns["Title"] != null) dgvSongs.Columns["Title"].FillWeight = 30;
            if (dgvSongs.Columns["Artist"] != null) dgvSongs.Columns["Artist"].FillWeight = 25;
            if (dgvSongs.Columns["FilePath"] != null) dgvSongs.Columns["FilePath"].FillWeight = 30;
            if (dgvSongs.Columns["CategoryID"] != null) dgvSongs.Columns["CategoryID"].FillWeight = 15;

            Color nenden = Color.FromArgb(25, 25, 25);
            Color xanh = Color.FromArgb(30, 215, 96);
            Color màuChữTiêuĐề = Color.White;

            dgvSongs.EnableHeadersVisualStyles = false;
            dgvSongs.BackgroundColor = nenden;
            dgvSongs.BorderStyle = BorderStyle.None;

            dgvSongs.DefaultCellStyle.BackColor = nenden;
            dgvSongs.DefaultCellStyle.ForeColor = xanh;
            dgvSongs.DefaultCellStyle.SelectionBackColor = xanh;
            dgvSongs.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSongs.GridColor = Color.FromArgb(40, 40, 40);

            dgvSongs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            dgvSongs.ColumnHeadersDefaultCellStyle.ForeColor = màuChữTiêuĐề;
            dgvSongs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
            dgvSongs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvSongs.RowHeadersDefaultCellStyle.BackColor = nenden;
            dgvSongs.RowHeadersDefaultCellStyle.ForeColor = xanh;
            dgvSongs.RowHeadersDefaultCellStyle.SelectionBackColor = xanh;
            dgvSongs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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
    }
}