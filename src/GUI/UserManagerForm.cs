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
    public partial class UserManagerForm : Form
    {
        private UserBUS _userBUS = new UserBUS();

        public UserManagerForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userBUS.GetAllUsers();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvUsers.Columns["UserID"] != null) dgvUsers.Columns["UserID"].FillWeight = 20;
            if (dgvUsers.Columns["Username"] != null) dgvUsers.Columns["Username"].FillWeight = 50;
            if (dgvUsers.Columns["Role"] != null) dgvUsers.Columns["Role"].FillWeight = 30;


            // 1. Tạo các biến màu sắc chuẩn
            Color nenden = Color.FromArgb(25, 25, 25);
            Color xanh = Color.FromArgb(30, 215, 96);
            Color màuChữTiêuĐề = Color.White; 

            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.BackgroundColor = nenden; 
            dgvUsers.BorderStyle = BorderStyle.None;

            // 3. Cấu hình màu sắc cho phần NỘI DUNG (Cells)
            dgvUsers.DefaultCellStyle.BackColor = nenden;       
            dgvUsers.DefaultCellStyle.ForeColor = xanh;        
            dgvUsers.DefaultCellStyle.SelectionBackColor = xanh;  
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;  
            dgvUsers.GridColor = Color.FromArgb(40, 40, 40);            

            // 4. Cấu hình màu sắc cho thanh TIÊU ĐỀ CỘT (Headers)
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18); 
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = màuChữTiêuĐề;             
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // 5. Cấu hình màu sắc cho cột đầu hàng (Row Headers - ô trống nhỏ ngoài cùng bên trái)
            dgvUsers.RowHeadersDefaultCellStyle.BackColor = nenden;
            dgvUsers.RowHeadersDefaultCellStyle.ForeColor = xanh;
            dgvUsers.RowHeadersDefaultCellStyle.SelectionBackColor = xanh;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }



        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvUsers.Rows[e.RowIndex];
            txtUserID.Text = row.Cells["UserID"].Value?.ToString();
            txtUsername.Text = row.Cells["Username"].Value?.ToString();
            cboRole.Text = row.Cells["Role"].Value?.ToString();
        }

        private void btnSetAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)) return;
            try
            {
                _userBUS.UpdateUserRole(txtUserID.Text, "Admin");
                MessageBox.Show("Đã cấp quyền Admin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSetUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)) return;
            try
            {
                _userBUS.UpdateUserRole(txtUserID.Text, "User");
                MessageBox.Show("Đã hạ xuống User!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)) return;
            if (MessageBox.Show($"Xóa tài khoản \"{txtUsername.Text}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _userBUS.DeleteUser(txtUserID.Text, Session.CurrentUser.UserID);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}