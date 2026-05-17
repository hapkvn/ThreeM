using System;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class LogRegisterForm : Form
    {
        // KHAI BÁO ĐÚNG TÊN FORM MỚI
        loginForm frmLogin = new loginForm();
        RegisterForm frmRegister = new RegisterForm();

        public LogRegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Hide();
        }

        private void btnResgiter_Click(object sender, EventArgs e) // Bạn có thể nối sự kiện này cho nút Đăng ký
        {
            frmRegister.Show();
            this.Hide();
        }

        // Hàm trống này để sửa lỗi "LogRegisterForm_Load_1" không tồn tại
        private void LogRegisterForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}