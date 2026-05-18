using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;
using System;
using System.Windows.Forms;


namespace Kiemtragiuaki.GUI
{
    public partial class loginForm : Form
    {
        Form1 form = new Form1(); // Khởi tạo Form chính của ứng dụng

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

                // Trong btnLogin_Click, sau khi login thành công:
                if (account != null)
                {
                    Session.CurrentUser = account; // ← Thêm dòng này
                    this.Hide();
                    form.ShowDialog();
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
            //Application.Exit();
        }
    }
}