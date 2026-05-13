using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DAL;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Kiemtragiuaki.GUI

{
    public partial class UC_Home : UserControl
    {

        // để thông báo cho form1   
        public Action<string> OnSongSelected { get; set; }

        CategoryBUS categoryBUS = new CategoryBUS();
        SongBUS songBUS = new SongBUS();

        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {

            LoadCategories();


        }

        private void LoadCategories()
        {
            List<CategoryDTO> list = categoryBUS.LayTatCaTheLoai();

            // Dọn dẹp danh sách cũ
            for (int i = flpCategories.Controls.Count - 1; i >= 0; i--)
            {
                if (flpCategories.Controls[i].Name != "pnlCategorySample")
                    flpCategories.Controls.RemoveAt(i);
            }

            foreach (var cat in list)
            {
                Guna.UI2.WinForms.Guna2Panel pnlNew = new Guna.UI2.WinForms.Guna2Panel();
                pnlNew.Size = pnlCategorySample.Size;
                pnlNew.FillColor = pnlCategorySample.FillColor;
                pnlNew.BorderRadius = pnlCategorySample.BorderRadius;
                pnlNew.Margin = new Padding(15);
                pnlNew.Cursor = Cursors.Hand;
                pnlNew.Visible = true;

                pnlNew.Tag = cat.CategoryID;

                Guna.UI2.WinForms.Guna2HtmlLabel lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
                lblName.Text = cat.CategoryName;
                lblName.ForeColor = Color.White;
                lblName.Font = lblCategoryNameSample.Font;
                lblName.AutoSize = false;
                lblName.Dock = DockStyle.Fill;
                lblName.TextAlignment = ContentAlignment.MiddleCenter;

                // Cho phép bấm vào cả chữ và Panel
                lblName.Click += (s, e) => { pnlCategorySample_Click(pnlNew, e); };
                pnlNew.Click += pnlCategorySample_Click;

                pnlNew.Controls.Add(lblName);
                flpCategories.Controls.Add(pnlNew);
            }
        }
        private void LoadSongsByCategory(string categoryID)
        {
            List<Song> songList = songBUS.GetSongsByCategoryID(categoryID);
            flpSongs.Controls.Clear();

            int stt = 1;
            foreach (var s in songList)
            {
                UC_SongItem item = new UC_SongItem();
                item.SetData(s, stt++);

                // ĐĂNG KÝ NHẬN TIN TỪ ITEM Ở ĐÂY
                item.OnPlayClick = (path) => {
                    // Khi Item bấm play, UC_Home báo tiếp lên cho Form1
                    OnSongSelected?.Invoke(path);
                };

                // Ép kích thước cố định
                item.Size = new Size(flpSongs.Width - 30, 60);
                // Thêm vào danh sách hiển thị
                flpSongs.Controls.Add(item);
                item.Show();


            }
        }
        private void pnlCategorySample_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel pnl = (Guna.UI2.WinForms.Guna2Panel)sender;
            string id = pnl.Tag.ToString();
            // 1. Chuyển đổi trạng thái hiển thị
            flpCategories.Visible = false;
            flpSongs.Visible = true;
            flpSongs.BringToFront(); // Đưa danh sách bài hát lên lớp trên cùng
            flpSongs.Dock = DockStyle.Fill; // Đảm bảo nó lấp đầy vùng trống

            LoadSongsByCategory(id);
        }



    }
}