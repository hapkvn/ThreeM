namespace Kiemtragiuaki.GUI
{
    partial class LogRegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnResgiter = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(336, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click); // Gắn sự kiện click
            // 
            // btnResgiter
            // 
            this.btnResgiter.BorderRadius = 20;
            this.btnResgiter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnResgiter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResgiter.ForeColor = System.Drawing.Color.Black;
            this.btnResgiter.Location = new System.Drawing.Point(336, 257);
            this.btnResgiter.Name = "btnResgiter";
            this.btnResgiter.Size = new System.Drawing.Size(141, 37);
            this.btnResgiter.TabIndex = 3;
            this.btnResgiter.Text = "Đăng ký";
            this.btnResgiter.Click += new System.EventHandler(this.btnResgiter_Click); // Gắn sự kiện click
            // 
            // LogRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResgiter);
            this.Controls.Add(this.btnLogin);
            this.Name = "LogRegisterForm";
            this.Text = "Welcome to Music Manager";
            this.Load += new System.EventHandler(this.LogRegisterForm_Load_1); // Gắn sự kiện Load
            this.ResumeLayout(false);
        }

        

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnResgiter;
    }
}