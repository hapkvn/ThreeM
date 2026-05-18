using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;
using System;
using System.Windows.Forms;


namespace Kiemtragiuaki.GUI
{
    public partial class loginForm : Form
    {
        


        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ text box
            string username = txtuer.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Kiểm tra xem người dùng có bỏ trống textbox nào không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SỬ DỤNG TẦNG BUS: Gọn gàng, bảo mật và chuẩn cấu trúc 3 lớp
                UserBUS userBUS = new UserBUS();
                User account = userBUS.Login(username, pass);

                // Nếu account khác null nghĩa là có tài khoản trùng khớp trong Database
                if (account != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK; // Gửi tín hiệu thành công
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK && this.DialogResult != DialogResult.Cancel)
            {
                Application.Exit(); 
            }
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}