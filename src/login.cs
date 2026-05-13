using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sử dụng thư viện để dùng sql
using System.Data.SqlClient;
<<<<<<< HEAD
using MySqlConnector;

namespace ThreeM
=======

namespace Kiemtragiuaki
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0
{
    public partial class login : Form
    {
        Form1 form = new Form1();
        public login()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //lẫy dữ liệu từ text box
            string username = txtuer.Text.Trim();
            string pass = txtPassword.Text.Trim();

            //Kiểm tra xem người dùng có bỏ trống textbox nào không
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // luồng kiểm tra đăng nhập
            try
            {
                // Kết nối với database
                using (var connection = DatabaseConnection.GetConnection())
                {
                    //thiết lập cổng kết nối với cơ sở dữ liệu
                    connection.Open();
                    string sql = "select COUNT(*) from users Where Username = @user AND @pass";
                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@pass", pass);
                        //Tạo giá trị số để kiểm tra
                        int n = Convert.ToInt32(command.ExecuteScalar());
                        //Kiểm tra giá trị
                        if (n>0)
                        {
                            this.Hide();
                            form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
=======
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0

        }
    }
}
