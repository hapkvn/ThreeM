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
    public partial class Quan_ly_nhac : Form
    {
        private SongBUS _songBUS = new SongBUS();

        public Quan_ly_nhac()
        {
            InitializeComponent();
            LoadSongs();
        }

        private void LoadSongs()
        {
            dgvSongs.DataSource = null;
            dgvSongs.DataSource = _songBUS.GetSongs();

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

        private Song BuildSongFromForm(string songID = "")
        {
            return new Song
            {
                SongID = songID,
                Title = txtTitle.Text.Trim(),
                Artist = txtArtist.Text.Trim(),
                FilePath = txtFilePath.Text.Trim(),
                CategoryID = txtCategoryID.Text.Trim()
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Audio|*.mp3;*.wav;*.flac" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    txtFilePath.Text = dlg.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _songBUS.AddSong(BuildSongFromForm());
                MessageBox.Show("Thêm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn bài hát cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvSongs.CurrentRow.Cells["SongID"].Value?.ToString();
            try
            {
                _songBUS.UpdateSong(BuildSongFromForm(id));
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn bài hát cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvSongs.CurrentRow.Cells["SongID"].Value?.ToString();
            string title = dgvSongs.CurrentRow.Cells["Title"].Value?.ToString();

            if (MessageBox.Show($"Xóa bài \"{title}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _songBUS.DeleteSong(id);
                LoadSongs();
            }
        }
        private void dgvSongs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSongs.Rows[e.RowIndex];
            txtTitle.Text = row.Cells["Title"].Value?.ToString();
            txtArtist.Text = row.Cells["Artist"].Value?.ToString();
            txtFilePath.Text = row.Cells["FilePath"].Value?.ToString();
            txtCategoryID.Text = row.Cells["CategoryID"].Value?.ToString();
        }

        private void Quan_ly_nhac_Load(object sender, EventArgs e)
        {

        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}