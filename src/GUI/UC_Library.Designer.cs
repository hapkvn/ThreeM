namespace Kiemtragiuaki.GUI
{
    partial class UC_Library
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCreateAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.flpAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAlbumDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.flpSongsInAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCreateAlbum = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddSongToAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.panelAlbumDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 88);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thư Viện Của Bạn";
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.BorderRadius = 20;
            this.btnCreateAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnCreateAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateAlbum.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAlbum.Location = new System.Drawing.Point(325, 3);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(188, 45);
            this.btnCreateAlbum.TabIndex = 1;
            this.btnCreateAlbum.Text = "+ Tạo Album";
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // flpAlbums
            // 
            this.flpAlbums.AutoScroll = true;
            this.flpAlbums.BackColor = System.Drawing.Color.Transparent;
            this.flpAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAlbums.Location = new System.Drawing.Point(0, 0);
            this.flpAlbums.Name = "flpAlbums";
            this.flpAlbums.Padding = new System.Windows.Forms.Padding(10);
            this.flpAlbums.Size = new System.Drawing.Size(1000, 584);
            this.flpAlbums.TabIndex = 2;
            // 
            // panelAlbumDetail
            // 
            this.panelAlbumDetail.Controls.Add(this.flpSongsInAlbum);
            this.panelAlbumDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbumDetail.Location = new System.Drawing.Point(0, 0);
            this.panelAlbumDetail.Name = "panelAlbumDetail";
            this.panelAlbumDetail.Padding = new System.Windows.Forms.Padding(10);
            this.panelAlbumDetail.Size = new System.Drawing.Size(1000, 584);
            this.panelAlbumDetail.TabIndex = 0;
            this.panelAlbumDetail.Visible = false;
            // 
            // flpSongsInAlbum
            // 
            this.flpSongsInAlbum.AutoScroll = true;
            this.flpSongsInAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSongsInAlbum.Location = new System.Drawing.Point(10, 10);
            this.flpSongsInAlbum.Name = "flpSongsInAlbum";
            this.flpSongsInAlbum.Padding = new System.Windows.Forms.Padding(10);
            this.flpSongsInAlbum.Size = new System.Drawing.Size(980, 564);
            this.flpSongsInAlbum.TabIndex = 0;
            // 
            // panelCreateAlbum
            // 
            this.panelCreateAlbum.Location = new System.Drawing.Point(0, 0);
            this.panelCreateAlbum.Name = "panelCreateAlbum";
            this.panelCreateAlbum.Size = new System.Drawing.Size(398, 248);
            this.panelCreateAlbum.TabIndex = 0;
            this.panelCreateAlbum.Visible = false;
            // 
            // btnAddSongToAlbum
            // 
            this.btnAddSongToAlbum.BorderRadius = 20;
            this.btnAddSongToAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSongToAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSongToAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSongToAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSongToAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnAddSongToAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSongToAlbum.ForeColor = System.Drawing.Color.Black;
            this.btnAddSongToAlbum.Location = new System.Drawing.Point(325, 3);
            this.btnAddSongToAlbum.Name = "btnAddSongToAlbum";
            this.btnAddSongToAlbum.Size = new System.Drawing.Size(188, 45);
            this.btnAddSongToAlbum.TabIndex = 3;
            this.btnAddSongToAlbum.Text = "+ Thêm Nhạc";
            this.btnAddSongToAlbum.Visible = false;
            this.btnAddSongToAlbum.Click += new System.EventHandler(this.btnAddSongToAlbum_Click);
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.BorderRadius = 20;
            this.btnDeleteAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnDeleteAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAlbum.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAlbum.Location = new System.Drawing.Point(530, 3);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(188, 45);
            this.btnDeleteAlbum.TabIndex = 4;
            this.btnDeleteAlbum.Text = "Xóa Album";
            this.btnDeleteAlbum.Visible = false;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // UC_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.btnAddSongToAlbum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelAlbumDetail);
            this.Controls.Add(this.panelCreateAlbum);
            this.Controls.Add(this.flpAlbums);
            this.Name = "UC_Library";
            this.Size = new System.Drawing.Size(1000, 584);
            this.Load += new System.EventHandler(this.UC_Library_Load);
            this.panelAlbumDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCreateAlbum;
        private System.Windows.Forms.FlowLayoutPanel flpAlbums;
        private Guna.UI2.WinForms.Guna2Panel panelAlbumDetail;
        private System.Windows.Forms.FlowLayoutPanel flpSongsInAlbum;
        private Guna.UI2.WinForms.Guna2Panel panelCreateAlbum;
        private Guna.UI2.WinForms.Guna2Button btnAddSongToAlbum;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAlbum;
    }
}
