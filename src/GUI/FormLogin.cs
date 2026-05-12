using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;
using Kiemtragiuaki.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Gọi lớp BUS để xử lý nghiệp vụ
        UserBUS userBUS = new UserBUS();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Gọi hàm Login từ lớp BUS (lớp này sẽ gọi xuống DAL)
            User user = userBUS.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Chào {user.Role}: {user.Username}", "Thành công");

                // Mở Form chính và truyền đối tượng User sang để phân quyền
                Form1 mainForm = new Form1(user);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }
    }
}
