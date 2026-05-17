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
            this.btnLogin.Location = new System.Drawing.Point(448, 245);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnResgiter
            // 
            this.btnResgiter.BorderRadius = 20;
            this.btnResgiter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnResgiter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResgiter.ForeColor = System.Drawing.Color.Black;
            this.btnResgiter.Location = new System.Drawing.Point(448, 316);
            this.btnResgiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResgiter.Name = "btnResgiter";
            this.btnResgiter.Size = new System.Drawing.Size(188, 46);
            this.btnResgiter.TabIndex = 3;
            this.btnResgiter.Text = "Đăng ký";
            this.btnResgiter.Click += new System.EventHandler(this.btnResgiter_Click);
            // 
            // LogRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnResgiter);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogRegisterForm";
            this.Text = "Welcome to Music Manager";
            this.ResumeLayout(false);

        }

        

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnResgiter;
    }
}