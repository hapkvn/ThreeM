using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI

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
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
    }
}
