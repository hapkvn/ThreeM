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

            // ── Card labels ──
            this.lblTitleBaiHat = new System.Windows.Forms.Label();
            this.lblTongBaiHat = new System.Windows.Forms.Label();
            this.lblTitleTheLoai = new System.Windows.Forms.Label();
            this.lblTongTheLoai = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblTongUser = new System.Windows.Forms.Label();
            this.lblTitleAdmin = new System.Windows.Forms.Label();
            this.lblTongAdmin = new System.Windows.Forms.Label();

            // ── Card panels ──
            this.cardBaiHat = new System.Windows.Forms.Panel();
            this.cardTheLoai = new System.Windows.Forms.Panel();
            this.cardUser = new System.Windows.Forms.Panel();
            this.cardAdmin = new System.Windows.Forms.Panel();

            // ── Table ──
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDeBang = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.cardBaiHat.SuspendLayout();
            this.cardTheLoai.SuspendLayout();
            this.cardUser.SuspendLayout();
            this.cardAdmin.SuspendLayout();
            this.SuspendLayout();

            // ── pnTop (4 cards) ──────────────────────────
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Size = new System.Drawing.Size(700, 130);
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.Controls.Add(this.cardAdmin);
            this.pnTop.Controls.Add(this.cardUser);
            this.pnTop.Controls.Add(this.cardTheLoai);
            this.pnTop.Controls.Add(this.cardBaiHat);

            // ── Card helper (local method equivalent via init) ──
            SetupCard(this.cardBaiHat, 0, 10, System.Drawing.Color.FromArgb(30, 215, 96), this.lblTitleBaiHat, "Bài Hát", this.lblTongBaiHat);
            SetupCard(this.cardTheLoai, 175, 10, System.Drawing.Color.FromArgb(33, 150, 243), this.lblTitleTheLoai, "Thể Loại", this.lblTongTheLoai);
            SetupCard(this.cardUser, 350, 10, System.Drawing.Color.FromArgb(255, 152, 0), this.lblTitleUser, "Người Dùng", this.lblTongUser);
            SetupCard(this.cardAdmin, 525, 10, System.Drawing.Color.FromArgb(244, 67, 54), this.lblTitleAdmin, "Admin", this.lblTongAdmin);

            // ── pnBottom (table) ─────────────────────────
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.Controls.Add(this.dgvThongKe);
            this.pnBottom.Controls.Add(this.lblTieuDeBang);

            // ── lblTieuDeBang ─────────────────────────────
            this.lblTieuDeBang.Text = "Bài hát theo thể loại";
            this.lblTieuDeBang.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeBang.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDeBang.AutoSize = true;

            // ── dgvThongKe ────────────────────────────────
            this.dgvThongKe.Location = new System.Drawing.Point(20, 40);
            this.dgvThongKe.Size = new System.Drawing.Size(640, 280);
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.RowTemplate.Height = 30;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.EnableHeadersVisualStyles = false;

            // Colors
            var bg = System.Drawing.Color.FromArgb(35, 35, 35);
            var green = System.Drawing.Color.FromArgb(30, 215, 96);
            var hdr = System.Drawing.Color.FromArgb(18, 18, 18);
            this.dgvThongKe.BackgroundColor = bg;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvThongKe.DefaultCellStyle.BackColor = bg;
            this.dgvThongKe.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.DefaultCellStyle.SelectionBackColor = green;
            this.dgvThongKe.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = hdr;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle.SelectionBackColor = hdr;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            // Columns
            this.colID.HeaderText = "ID";
            this.colID.FillWeight = 15;
            this.colTen.HeaderText = "Thể Loại";
            this.colTen.FillWeight = 55;
            this.colSoLuong.HeaderText = "Số Bài Hát";
            this.colSoLuong.FillWeight = 30;
            this.colSoLuong.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoLuong.DefaultCellStyle.ForeColor = green;
            this.colSoLuong.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);

            this.dgvThongKe.Columns.Add(this.colID);
            this.dgvThongKe.Columns.Add(this.colTen);
            this.dgvThongKe.Columns.Add(this.colSoLuong);

            // ── Form ──────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.ClientSize = new System.Drawing.Size(700, 480);
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

        private void SetupCard(System.Windows.Forms.Panel card, int x, int y,
            System.Drawing.Color accent,
            System.Windows.Forms.Label lblTitle, string titleText,
            System.Windows.Forms.Label lblCount)
        {
            card.Size = new System.Drawing.Size(155, 100);
            card.Location = new System.Drawing.Point(x, y);
            card.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);

            lblTitle.Text = titleText;
            lblTitle.ForeColor = System.Drawing.Color.Silver;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 12);

            lblCount.Text = "0";
            lblCount.ForeColor = accent;
            lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            lblCount.AutoSize = true;
            lblCount.Location = new System.Drawing.Point(12, 38);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblCount);
        }

        // Controls
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