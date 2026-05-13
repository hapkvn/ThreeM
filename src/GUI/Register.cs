using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace ThreeM
=======
namespace Kiemtragiuaki
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0
{
    public partial class Register : Form
    {
        login login = new login();
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string userName = txtname.Text.Trim();
            string fullName = txtfullName.Text.Trim();
            string pass = txtpassword.Text.Trim();
            string vePass = txtpassword.Text.Trim();

            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(fullName)
                || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(vePass))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(pass != vePass)
            {
                MessageBox.Show("mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                using(var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string sql = "INSERT INTO Users (Username, Password, FullName) VALUES (@user, @pass, @name)";
                    using (var command = new MySqlConnector.MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@user", userName);
                        command.Parameters.AddWithValue("@name", fullName);
                        command.Parameters.AddWithValue("@pass", pass);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login.ShowDialog();
                        this.Hide();
                        this.Close();
                    }
                   
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

=======
            
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0
        }
    }
}
