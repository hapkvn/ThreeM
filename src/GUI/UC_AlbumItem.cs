using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class UC_AlbumItem : UserControl
    {
        public string AlbumID { get; set; }
        public Action<string, string> OnAlbumClick;

        public UC_AlbumItem()
        {
            InitializeComponent();
            RegisterEvents();
        }

        // Đăng ký sự kiện tường minh cho từng control, tránh dùng foreach gây lỗi nạp giao diện động
        private void RegisterEvents()
        {
            // Gán cho chính UserControl
            this.Click += Item_Click;
            this.MouseEnter += UC_AlbumItem_MouseEnter;
            this.MouseLeave += UC_AlbumItem_MouseLeave;

            if (lblAlbumName != null)
            {
                lblAlbumName.Click += Item_Click;
                lblAlbumName.MouseEnter += UC_AlbumItem_MouseEnter;
                lblAlbumName.MouseLeave += UC_AlbumItem_MouseLeave;
            }

            // Gán cho Label hiển thị chữ cái đại diện (đảm bảo tồn tại trong Designer)
            if (lblLetter != null)
            {
                lblLetter.Click += Item_Click;
                lblLetter.MouseEnter += UC_AlbumItem_MouseEnter;
                lblLetter.MouseLeave += UC_AlbumItem_MouseLeave;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            // Gọi Action truyền ID và Tên ra ngoài cho UC_Library hứng
            OnAlbumClick?.Invoke(AlbumID, lblAlbumName.Text);
        }

        public void SetData(string id, string name)
        {
            this.AlbumID = id;
            lblAlbumName.Text = name;

            if (!string.IsNullOrEmpty(name))
            {
                lblLetter.Text = name.Substring(0, 1).ToUpper();
            }

            // Ép buộc UserControl cập nhật và vẽ lại nội dung ngay lập tức
            this.Invalidate();
        }

        private void UC_AlbumItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void UC_AlbumItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
        }
    }
}