namespace Kiemtragiuaki.GUI
{
    partial class ThongKeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.cardBaiHat = new System.Windows.Forms.Panel();
            this.lblTitleBaiHat = new System.Windows.Forms.Label();
            this.lblTongBaiHat = new System.Windows.Forms.Label();
            this.cardTheLoai = new System.Windows.Forms.Panel();
            this.lblTitleTheLoai = new System.Windows.Forms.Label();
            this.lblTongTheLoai = new System.Windows.Forms.Label();
            this.cardUser = new System.Windows.Forms.Panel();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblTongUser = new System.Windows.Forms.Label();
            this.cardAdmin = new System.Windows.Forms.Panel();
            this.lblTitleAdmin = new System.Windows.Forms.Label();
            this.lblTongAdmin = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDeBang = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.cardBaiHat.SuspendLayout();
            this.cardTheLoai.SuspendLayout();
            this.cardUser.SuspendLayout();
            this.cardAdmin.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.Controls.Add(this.cardBaiHat);
            this.pnTop.Controls.Add(this.cardTheLoai);
            this.pnTop.Controls.Add(this.cardUser);
            this.pnTop.Controls.Add(this.cardAdmin);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(720, 120);
            this.pnTop.TabIndex = 1;
            // 
            // cardBaiHat
            // 
            this.cardBaiHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardBaiHat.Controls.Add(this.lblTitleBaiHat);
            this.cardBaiHat.Controls.Add(this.lblTongBaiHat);
            this.cardBaiHat.Location = new System.Drawing.Point(10, 10);
            this.cardBaiHat.Name = "cardBaiHat";
            this.cardBaiHat.Size = new System.Drawing.Size(155, 100);
            this.cardBaiHat.TabIndex = 0;
            // 
            // lblTitleBaiHat
            // 
            this.lblTitleBaiHat.AutoSize = true;
            this.lblTitleBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleBaiHat.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleBaiHat.Location = new System.Drawing.Point(12, 12);
            this.lblTitleBaiHat.Name = "lblTitleBaiHat";
            this.lblTitleBaiHat.Size = new System.Drawing.Size(56, 18);
            this.lblTitleBaiHat.TabIndex = 0;
            this.lblTitleBaiHat.Text = "Bài Hát";
            // 
            // lblTongBaiHat
            // 
            this.lblTongBaiHat.AutoSize = true;
            this.lblTongBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongBaiHat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblTongBaiHat.Location = new System.Drawing.Point(12, 38);
            this.lblTongBaiHat.Name = "lblTongBaiHat";
            this.lblTongBaiHat.Size = new System.Drawing.Size(47, 52);
            this.lblTongBaiHat.TabIndex = 1;
            this.lblTongBaiHat.Text = "0";
            // 
            // cardTheLoai
            // 
            this.cardTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardTheLoai.Controls.Add(this.lblTitleTheLoai);
            this.cardTheLoai.Controls.Add(this.lblTongTheLoai);
            this.cardTheLoai.Location = new System.Drawing.Point(185, 10);
            this.cardTheLoai.Name = "cardTheLoai";
            this.cardTheLoai.Size = new System.Drawing.Size(155, 100);
            this.cardTheLoai.TabIndex = 1;
            // 
            // lblTitleTheLoai
            // 
            this.lblTitleTheLoai.AutoSize = true;
            this.lblTitleTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleTheLoai.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleTheLoai.Location = new System.Drawing.Point(12, 12);
            this.lblTitleTheLoai.Name = "lblTitleTheLoai";
            this.lblTitleTheLoai.Size = new System.Drawing.Size(65, 18);
            this.lblTitleTheLoai.TabIndex = 0;
            this.lblTitleTheLoai.Text = "Thể Loại";
            // 
            // lblTongTheLoai
            // 
            this.lblTongTheLoai.AutoSize = true;
            this.lblTongTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTongTheLoai.Location = new System.Drawing.Point(12, 38);
            this.lblTongTheLoai.Name = "lblTongTheLoai";
            this.lblTongTheLoai.Size = new System.Drawing.Size(47, 52);
            this.lblTongTheLoai.TabIndex = 1;
            this.lblTongTheLoai.Text = "0";
            // 
            // cardUser
            // 
            this.cardUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardUser.Controls.Add(this.lblTitleUser);
            this.cardUser.Controls.Add(this.lblTongUser);
            this.cardUser.Location = new System.Drawing.Point(360, 10);
            this.cardUser.Name = "cardUser";
            this.cardUser.Size = new System.Drawing.Size(155, 100);
            this.cardUser.TabIndex = 2;
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleUser.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleUser.Location = new System.Drawing.Point(12, 12);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(75, 18);
            this.lblTitleUser.TabIndex = 0;
            this.lblTitleUser.Text = "Tài Khoản";
            // 
            // lblTongUser
            // 
            this.lblTongUser.AutoSize = true;
            this.lblTongUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblTongUser.Location = new System.Drawing.Point(12, 38);
            this.lblTongUser.Name = "lblTongUser";
            this.lblTongUser.Size = new System.Drawing.Size(47, 52);
            this.lblTongUser.TabIndex = 1;
            this.lblTongUser.Text = "0";
            // 
            // cardAdmin
            // 
            this.cardAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cardAdmin.Controls.Add(this.lblTitleAdmin);
            this.cardAdmin.Controls.Add(this.lblTongAdmin);
            this.cardAdmin.Location = new System.Drawing.Point(535, 10);
            this.cardAdmin.Name = "cardAdmin";
            this.cardAdmin.Size = new System.Drawing.Size(155, 100);
            this.cardAdmin.TabIndex = 3;
            // 
            // lblTitleAdmin
            // 
            this.lblTitleAdmin.AutoSize = true;
            this.lblTitleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleAdmin.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleAdmin.Location = new System.Drawing.Point(12, 12);
            this.lblTitleAdmin.Name = "lblTitleAdmin";
            this.lblTitleAdmin.Size = new System.Drawing.Size(49, 18);
            this.lblTitleAdmin.TabIndex = 0;
            this.lblTitleAdmin.Text = "Admin";
            // 
            // lblTongAdmin
            // 
            this.lblTongAdmin.AutoSize = true;
            this.lblTongAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblTongAdmin.Location = new System.Drawing.Point(12, 38);
            this.lblTongAdmin.Name = "lblTongAdmin";
            this.lblTongAdmin.Size = new System.Drawing.Size(47, 52);
            this.lblTongAdmin.TabIndex = 1;
            this.lblTongAdmin.Text = "0";
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.Controls.Add(this.dgvThongKe);
            this.pnBottom.Controls.Add(this.lblTieuDeBang);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 120);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(720, 380);
            this.pnBottom.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.ColumnHeadersHeight = 29;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colSoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvThongKe.Location = new System.Drawing.Point(20, 42);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 30;
            this.dgvThongKe.Size = new System.Drawing.Size(670, 260);
            this.dgvThongKe.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.FillWeight = 15F;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.FillWeight = 55F;
            this.colTen.HeaderText = "Thể Loại";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colSoLuong
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoLuong.FillWeight = 30F;
            this.colSoLuong.HeaderText = "Số Bài Hát";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // lblTieuDeBang
            // 
            this.lblTieuDeBang.AutoSize = true;
            this.lblTieuDeBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeBang.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeBang.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDeBang.Name = "lblTieuDeBang";
            this.lblTieuDeBang.Size = new System.Drawing.Size(194, 24);
            this.lblTieuDeBang.TabIndex = 1;
            this.lblTieuDeBang.Text = "Bài hát theo thể loại";
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "ThongKeForm";
            this.Text = "Thống Kê";
            this.pnTop.ResumeLayout(false);
            this.cardBaiHat.ResumeLayout(false);
            this.cardBaiHat.PerformLayout();
            this.cardTheLoai.ResumeLayout(false);
            this.cardTheLoai.PerformLayout();
            this.cardUser.ResumeLayout(false);
            this.cardUser.PerformLayout();
            this.cardAdmin.ResumeLayout(false);
            this.cardAdmin.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnTop, pnBottom;
        private System.Windows.Forms.Panel cardBaiHat, cardTheLoai, cardUser, cardAdmin;
        private System.Windows.Forms.Label lblTitleBaiHat, lblTongBaiHat;
        private System.Windows.Forms.Label lblTitleTheLoai, lblTongTheLoai;
        private System.Windows.Forms.Label lblTitleUser, lblTongUser;
        private System.Windows.Forms.Label lblTitleAdmin, lblTongAdmin;
        private System.Windows.Forms.Label lblTieuDeBang;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID, colTen, colSoLuong;
    }
}