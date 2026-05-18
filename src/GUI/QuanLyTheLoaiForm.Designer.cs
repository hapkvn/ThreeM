namespace Kiemtragiuaki.GUI
{
    partial class QuanLyTheLoaiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDangChon = new System.Windows.Forms.Label();
            this.lblSelectedSong = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaTheLoai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSongs.Location = new System.Drawing.Point(0, 0);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.RowTemplate.Height = 28;
            this.dgvSongs.Size = new System.Drawing.Size(1210, 310);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblDangChon);
            this.panel1.Controls.Add(this.lblSelectedSong);
            this.panel1.Controls.Add(this.txtTenTheLoai);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.btnThemTheLoai);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoaTheLoai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 213);
            this.panel1.TabIndex = 1;
            // 
            // lblDangChon
            // 
            this.lblDangChon.AutoSize = true;
            this.lblDangChon.BackColor = System.Drawing.Color.Transparent;
            this.lblDangChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDangChon.ForeColor = System.Drawing.Color.White;
            this.lblDangChon.Location = new System.Drawing.Point(60, 35);
            this.lblDangChon.Name = "lblDangChon";
            this.lblDangChon.Size = new System.Drawing.Size(94, 18);
            this.lblDangChon.TabIndex = 0;
            this.lblDangChon.Text = "Đang chọn:";
            // 
            // lblSelectedSong
            // 
            this.lblSelectedSong.AutoSize = true;
            this.lblSelectedSong.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblSelectedSong.Location = new System.Drawing.Point(160, 35);
            this.lblSelectedSong.Name = "lblSelectedSong";
            this.lblSelectedSong.Size = new System.Drawing.Size(275, 18);
            this.lblSelectedSong.TabIndex = 1;
            this.lblSelectedSong.Text = "← Bấm vào bài hát để chọn thể loại";
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTenTheLoai.Location = new System.Drawing.Point(160, 140);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(280, 22);
            this.txtTenTheLoai.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTheLoai.ForeColor = System.Drawing.Color.White;
            this.lblTheLoai.Location = new System.Drawing.Point(60, 90);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(73, 18);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnThemTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnThemTheLoai.Location = new System.Drawing.Point(460, 136);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(140, 32);
            this.btnThemTheLoai.TabIndex = 3;
            this.btnThemTheLoai.Text = "Thêm thể loại";
            this.btnThemTheLoai.UseVisualStyleBackColor = false;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(460, 82);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(140, 32);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.BackColor = System.Drawing.Color.Red;
            this.btnXoaTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnXoaTheLoai.Location = new System.Drawing.Point(620, 136);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(140, 32);
            this.btnXoaTheLoai.TabIndex = 5;
            this.btnXoaTheLoai.Text = "Xóa thể loại";
            this.btnXoaTheLoai.UseVisualStyleBackColor = false;
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // QuanLyTheLoaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1210, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSongs);
            this.Name = "QuanLyTheLoaiForm";
            this.Text = "Quản Lý Thể Loại Nhạc";
            this.Load += new System.EventHandler(this.QuanLyTheLoaiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDangChon;
        private System.Windows.Forms.Label lblSelectedSong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaTheLoai;
    }
}