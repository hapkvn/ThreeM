namespace Kiemtragiuaki.GUI
{
    partial class UC_SongItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSTT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArtist = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPlaySong = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSTT
            // 
            this.lblSTT.BackColor = System.Drawing.Color.Transparent;
            this.lblSTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.lblSTT.Location = new System.Drawing.Point(24, 20);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(74, 18);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "<b><span style=\"color: #1DB954;\">Số Thứ Tự\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(132, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "<b><span style=\"color: #FFFFFF;\">Tên Bài Hát\r\n";
            // 
            // lblArtist
            // 
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblArtist.Location = new System.Drawing.Point(132, 44);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(53, 18);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "<span style=\"color: #DBD9D9\r\n;\">Nghệ Sĩ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnPlaySong);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.lblArtist);
            this.guna2Panel1.Controls.Add(this.lblSTT);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaySong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaySong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaySong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaySong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnPlaySong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlaySong.ForeColor = System.Drawing.Color.White;
            this.btnPlaySong.Image = global::Kiemtragiuaki.Properties.Resources.right_arrow__1_;
            this.btnPlaySong.ImageSize = new System.Drawing.Size(32, 27);
            this.btnPlaySong.Location = new System.Drawing.Point(704, 20);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlaySong.Size = new System.Drawing.Size(67, 54);
            this.btnPlaySong.TabIndex = 3;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // UC_SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_SongItem";
            this.Size = new System.Drawing.Size(800, 600);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSTT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArtist;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlaySong;
    }
}
