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

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}