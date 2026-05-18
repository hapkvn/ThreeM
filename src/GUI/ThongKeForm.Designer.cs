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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.cardBaiHat = new System.Windows.Forms.Panel();
            this.cardTheLoai = new System.Windows.Forms.Panel();
            this.cardUser = new System.Windows.Forms.Panel();
            this.cardAdmin = new System.Windows.Forms.Panel();
            this.lblTitleBaiHat = new System.Windows.Forms.Label();
            this.lblTongBaiHat = new System.Windows.Forms.Label();
            this.lblTitleTheLoai = new System.Windows.Forms.Label();
            this.lblTongTheLoai = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblTongUser = new System.Windows.Forms.Label();
            this.lblTitleAdmin = new System.Windows.Forms.Label();
            this.lblTongAdmin = new System.Windows.Forms.Label();
            this.lblTieuDeBang = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.cardBaiHat.SuspendLayout();
            this.cardTheLoai.SuspendLayout();
            this.cardUser.SuspendLayout();
            this.cardAdmin.SuspendLayout();
            this.SuspendLayout();

            // ── cardBaiHat ────────────────────────────────
            this.cardBaiHat.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.cardBaiHat.Location = new System.Drawing.Point(10, 10);
            this.cardBaiHat.Size = new System.Drawing.Size(155, 100);
            this.cardBaiHat.Controls.Add(this.lblTitleBaiHat);
            this.cardBaiHat.Controls.Add(this.lblTongBaiHat);

            this.lblTitleBaiHat.Text = "Bài Hát";
            this.lblTitleBaiHat.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleBaiHat.AutoSize = true;
            this.lblTitleBaiHat.Location = new System.Drawing.Point(12, 12);

            this.lblTongBaiHat.Text = "0";
            this.lblTongBaiHat.ForeColor = System.Drawing.Color.FromArgb(30, 215, 96);
            this.lblTongBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongBaiHat.AutoSize = true;
            this.lblTongBaiHat.Location = new System.Drawing.Point(12, 38);

            // ── cardTheLoai ───────────────────────────────
            this.cardTheLoai.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.cardTheLoai.Location = new System.Drawing.Point(185, 10);
            this.cardTheLoai.Size = new System.Drawing.Size(155, 100);
            this.cardTheLoai.Controls.Add(this.lblTitleTheLoai);
            this.cardTheLoai.Controls.Add(this.lblTongTheLoai);

            this.lblTitleTheLoai.Text = "Thể Loại";
            this.lblTitleTheLoai.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleTheLoai.AutoSize = true;
            this.lblTitleTheLoai.Location = new System.Drawing.Point(12, 12);

            this.lblTongTheLoai.Text = "0";
            this.lblTongTheLoai.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.lblTongTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongTheLoai.AutoSize = true;
            this.lblTongTheLoai.Location = new System.Drawing.Point(12, 38);

            // ── cardUser ──────────────────────────────────
            this.cardUser.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.cardUser.Location = new System.Drawing.Point(360, 10);
            this.cardUser.Size = new System.Drawing.Size(155, 100);
            this.cardUser.Controls.Add(this.lblTitleUser);
            this.cardUser.Controls.Add(this.lblTongUser);

            this.lblTitleUser.Text = "Người Dùng";
            this.lblTitleUser.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Location = new System.Drawing.Point(12, 12);

            this.lblTongUser.Text = "0";
            this.lblTongUser.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.lblTongUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongUser.AutoSize = true;
            this.lblTongUser.Location = new System.Drawing.Point(12, 38);

            // ── cardAdmin ─────────────────────────────────
            this.cardAdmin.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.cardAdmin.Location = new System.Drawing.Point(535, 10);
            this.cardAdmin.Size = new System.Drawing.Size(155, 100);
            this.cardAdmin.Controls.Add(this.lblTitleAdmin);
            this.cardAdmin.Controls.Add(this.lblTongAdmin);

            this.lblTitleAdmin.Text = "Admin";
            this.lblTitleAdmin.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleAdmin.AutoSize = true;
            this.lblTitleAdmin.Location = new System.Drawing.Point(12, 12);

            this.lblTongAdmin.Text = "0";
            this.lblTongAdmin.ForeColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.lblTongAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongAdmin.AutoSize = true;
            this.lblTongAdmin.Location = new System.Drawing.Point(12, 38);

            // ── pnTop ─────────────────────────────────────
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Size = new System.Drawing.Size(720, 120);
            this.pnTop.Controls.Add(this.cardBaiHat);
            this.pnTop.Controls.Add(this.cardTheLoai);
            this.pnTop.Controls.Add(this.cardUser);
            this.pnTop.Controls.Add(this.cardAdmin);

            // ── lblTieuDeBang ─────────────────────────────
            this.lblTieuDeBang.Text = "Bài hát theo thể loại";
            this.lblTieuDeBang.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeBang.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDeBang.AutoSize = true;

            // ── dgvThongKe ────────────────────────────────
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.RowTemplate.Height = 30;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.Location = new System.Drawing.Point(20, 42);
            this.dgvThongKe.Size = new System.Drawing.Size(670, 260);
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(50, 50, 50);

            this.dgvThongKe.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dgvThongKe.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 215, 96);
            this.dgvThongKe.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            this.colID.HeaderText = "ID";
            this.colID.FillWeight = 15;
            this.colID.ReadOnly = true;

            this.colTen.HeaderText = "Thể Loại";
            this.colTen.FillWeight = 55;
            this.colTen.ReadOnly = true;

            this.colSoLuong.HeaderText = "Số Bài Hát";
            this.colSoLuong.FillWeight = 30;
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoLuong.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 215, 96);
            this.colSoLuong.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);

            this.dgvThongKe.Columns.Add(this.colID);
            this.dgvThongKe.Columns.Add(this.colTen);
            this.dgvThongKe.Columns.Add(this.colSoLuong);

            // ── pnBottom ──────────────────────────────────
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Controls.Add(this.dgvThongKe);
            this.pnBottom.Controls.Add(this.lblTieuDeBang);

            // ── Form ──────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "ThongKeForm";
            this.Text = "Thống Kê";

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.cardBaiHat.ResumeLayout(false);
            this.cardBaiHat.PerformLayout();
            this.cardTheLoai.ResumeLayout(false);
            this.cardTheLoai.PerformLayout();
            this.cardUser.ResumeLayout(false);
            this.cardUser.PerformLayout();
            this.cardAdmin.ResumeLayout(false);
            this.cardAdmin.PerformLayout();
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