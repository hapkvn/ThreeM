using System;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class LogRegisterForm : Form
    {
       

        public LogRegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (loginForm frmLogin = new loginForm())
            {
                this.Hide(); 

                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void btnResgiter_Click(object sender, EventArgs e) // Bạn có thể nối sự kiện này cho nút Đăng ký
        {
            using (RegisterForm frmRegister = new RegisterForm())
            {
                this.Hide();
                frmRegister.ShowDialog(); // Chạy độc lập
                this.Show(); // Đăng ký xong hoặc tắt đi thì hiện lại form lựa chọn
            }
        }
    }
}