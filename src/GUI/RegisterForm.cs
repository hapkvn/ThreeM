using Kiemtragiuaki.BUS;
using System;
using System.Windows.Forms;
 // Gọi tầng BUS

namespace Kiemtragiuaki.GUI
{
    public partial class RegisterForm : Form
    {
        loginForm frmLogin = new loginForm();
        LogRegisterForm lor = new LogRegisterForm();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtname.Text.Trim();
            string fullName = txtfullName.Text.Trim();
            string pass = txtpassword.Text.Trim();
            string vePass = txtVePass.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(fullName)
                || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(vePass))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != vePass)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SỬ DỤNG BUS THAY VÌ VIẾT SQL TRỰC TIẾP TẠI ĐÂY
                UserBUS userBUS = new UserBUS();
                bool isSuccess = userBUS.RegisterUser(userName, pass, fullName);

                if (isSuccess)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin.ShowDialog();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Tài khoản có thể đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            lor.ShowDialog();
            
        }
    }
}