namespace Kiemtragiuaki.GUI
{
    partial class UC_Home
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
            this.lbCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlCategorySample = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCategoryNameSample = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArtist = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSongName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flpSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategorySample.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = false;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(0, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(940, 56);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "<b><span style=\"color: #1DB954;\">Thể loại Nhạc\r\n";
            // 
            // pnlCategorySample
            // 
            this.pnlCategorySample.BorderRadius = 15;
            this.pnlCategorySample.Controls.Add(this.lblCategoryNameSample);
            this.pnlCategorySample.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.pnlCategorySample.Location = new System.Drawing.Point(33, 3);
            this.pnlCategorySample.Name = "pnlCategorySample";
            this.pnlCategorySample.Size = new System.Drawing.Size(160, 100);
            this.pnlCategorySample.TabIndex = 0;
            this.pnlCategorySample.Visible = false;
            this.pnlCategorySample.Click += new System.EventHandler(this.pnlCategorySample_Click);
            // 
            // lblCategoryNameSample
            // 
            this.lblCategoryNameSample.AutoSize = false;
            this.lblCategoryNameSample.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryNameSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryNameSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryNameSample.ForeColor = System.Drawing.Color.White;
            this.lblCategoryNameSample.Location = new System.Drawing.Point(0, 0);
            this.lblCategoryNameSample.Name = "lblCategoryNameSample";
            this.lblCategoryNameSample.Size = new System.Drawing.Size(160, 100);
            this.lblCategoryNameSample.TabIndex = 0;
            this.lblCategoryNameSample.Text = "Tên Thể Loại";
            this.lblCategoryNameSample.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpCategories
            // 
            this.flpCategories.Controls.Add(this.pnlCategorySample);
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCategories.Location = new System.Drawing.Point(0, 56);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flpCategories.Size = new System.Drawing.Size(940, 449);
            this.flpCategories.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(268, 118);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 18);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "<b><span style=\"color: #1DB954;\">Thời Lượng";
            // 
            // lblArtist
            // 
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(268, 172);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(60, 18);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "<b><span style=\"color: #1DB954;\">Nghệ Sĩ";
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.ForeColor = System.Drawing.Color.White;
            this.lblSongName.Location = new System.Drawing.Point(264, 66);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(85, 18);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "<b><span style=\"color: #1DB954;\">Tên Bài Hát";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(264, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "<b><span style=\"color: #1DB954;\">Số Thứ Tự\r\n";
            // 
            // flpSongs
            // 
            this.flpSongs.AutoScroll = true;
            this.flpSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSongs.Location = new System.Drawing.Point(0, 56);
            this.flpSongs.Name = "flpSongs";
            this.flpSongs.Size = new System.Drawing.Size(940, 449);
            this.flpSongs.TabIndex = 2;
            this.flpSongs.Visible = false;
            this.flpSongs.WrapContents = false;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.flpSongs);
            this.Controls.Add(this.flpCategories);
            this.Controls.Add(this.lbCategory);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(940, 505);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.pnlCategorySample.ResumeLayout(false);
            this.flpCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbCategory;
        private Guna.UI2.WinForms.Guna2Panel pnlCategorySample;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryNameSample;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArtist;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSongName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private System.Windows.Forms.FlowLayoutPanel flpSongs;
    }
}
