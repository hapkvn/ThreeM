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
    public partial class LogRegister : Form
    {
        login login = new login();
        Register register = new Register();
        public LogRegister()
        {
            InitializeComponent();
        }

        private void LogRegister_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            register.Show();
            this.Hide(); 
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void btnResgiter_Click(object sender, EventArgs e)
        {
            register.Show();
            this.Hide();
        }
=======
>>>>>>> 10ab8420b7de0393c72cefb336108a286c67b9c0
    }
}
