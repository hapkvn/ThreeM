using Kiemtragiuaki.BUS;
using Kiemtragiuaki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Cần thiết để sử dụng Path.GetFileName
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki.GUI
{
    public partial class UC_Library : UserControl
    {

        private string currentOpeningAlbumID = "";
        private string currentOpeningAlbumName = "";

        AlbumBUS albumBUS = new AlbumBUS();
        string currentUserID = "US_01";
        // Khai báo sự kiện để gửi đường dẫn nhạc về Form chính
        public Action<string> OnSongSelected;

        // 1. Khai báo biến toàn cục để quản lý UserControl tạo album
        private UC_CreateAlbum ucCreateAlbumArea;
        public UC_Library()
        {
            InitializeComponent();


            InitCreateAlbumControl();
        }


        // Hàm xử lý tạo và cấu hình UC
        private void InitCreateAlbumControl()
        {
            // 1. Khởi tạo UserControl con bằng code
            ucCreateAlbumArea = new UC_CreateAlbum();
            ucCreateAlbumArea.Dock = DockStyle.Fill; // Để nó lấp đầy panel bọc ngoài

            

            // Đưa UserControl vào trong Panel bọc ngoài
            panelCreateAlbum.Controls.Add(ucCreateAlbumArea);
        }

        public void LoadUserAlbums()
        {
            // 1. Quản lý trạng thái hiển thị: Ẩn khung tạo, hiện danh sách album chính
            panelCreateAlbum.Visible = false;
            panelAlbumDetail.Visible = false;
            flpAlbums.Visible = true;
            flpAlbums.BringToFront();

            btnAddSongToAlbum.Visible = false;  
            btnCreateAlbum.Visible = true;   
            

            // 2. Tạm dừng vẽ giao diện (CHỈ GỌI 1 LẦN DUY NHẤT) để tránh bị giật hình
            flpAlbums.SuspendLayout();
            flpAlbums.Controls.Clear();

            try
            {
                // 3. Lấy dữ liệu từ BUS
                var list = albumBUS.LayDanhSachAlbum(currentUserID);

                if (list != null && list.Count > 0)
                {
                    foreach (var a in list)
                    {
                        UC_AlbumItem item = new UC_AlbumItem();

                        // Đổ dữ liệu
                        item.SetData(a.AlbumID, a.AlbumName);

                        // Cài đặt kích thước và khoảng cách
                        item.Margin = new Padding(20, 20, 0, 0); // Cách lề trên và trái 20px cho thoáng

                        // Cài đặt sự kiện click
                        item.OnAlbumClick = (id, name) => {
                            Form1.selectedAlbumID = id;
                            ShowAllSong(id, name); // Hàm hiển thị danh sách bài hát
                        };

                        // Thêm vào FlowLayoutPanel
                        flpAlbums.Controls.Add(item);
                    }
                }
                else
                {
                    // Hiển thị thông báo thân thiện nếu không có album
                    Label lblEmpty = new Label();
                    lblEmpty.Text = "Bạn chưa có album nào. Hãy tạo mới ngay!";
                    lblEmpty.ForeColor = Color.Gray;
                    lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
                    lblEmpty.AutoSize = false;
                    lblEmpty.Size = new Size(flpAlbums.Width, 100);
                    flpAlbums.Controls.Add(lblEmpty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thư viện: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Cho phép vẽ lại giao diện (Bảo đảm giải phóng đóng băng hoàn toàn)
                flpAlbums.ResumeLayout(true);
            }
        }

        private void ShowAllSong(string albumID, string albumName)
        {
            // Lưu lại thông tin Album đang mở để nút "Thêm nhạc" lấy làm căn cứ xử lý
            currentOpeningAlbumID = albumID;
            currentOpeningAlbumName = albumName;

            flpAlbums.Visible = false;
            panelAlbumDetail.Visible = true;
            panelAlbumDetail.BringToFront();

            btnCreateAlbum.Visible = false;     // Ẩn nút tạo album chính đi

            btnAddSongToAlbum.Visible = true;   
            btnAddSongToAlbum.BringToFront();
            btnDeleteAlbum.Visible = true;
            btnDeleteAlbum.BringToFront();
            flpSongsInAlbum.Controls.Clear();

           

            try
            {
                List<Song> dsNhac = albumBUS.LayNhacTrongAlbum(albumID);

                if (dsNhac == null || dsNhac.Count == 0)
                {
                    HienThiThongBaoTrongAlbum("Album này hiện chưa có bài hát nào.");
                    return;
                }

                flpSongsInAlbum.SuspendLayout();
                int count = 1;
                foreach (var s in dsNhac)
                {
                    UC_SongItem songUI = new UC_SongItem();
                    songUI.SetData(s, count++);

                    songUI.Width = flpSongsInAlbum.Width - 35;
                    songUI.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

                    songUI.OnPlayClick = (path) => {
                        this.OnSongSelected?.Invoke(path);
                    };

                    flpSongsInAlbum.Controls.Add(songUI);
                }
                flpSongsInAlbum.ResumeLayout();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                HienThiThongBaoTrongAlbum("Lỗi kết nối Database: Vui lòng kiểm tra lại máy chủ!");
            }
            catch (Exception ex)
            {
                HienThiThongBaoTrongAlbum("Đã xảy ra lỗi hệ thống: " + ex.Message);
            }
        }

        // Hàm phụ để hiển thị chữ thông báo giữa Panel cho đẹp
        private void HienThiThongBaoTrongAlbum(string message)
        {
            Label lblMsg = new Label();
            lblMsg.Text = message;
            lblMsg.ForeColor = Color.Gray;
            lblMsg.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            lblMsg.Dock = DockStyle.Fill; // Để nó nằm giữa panel
            flpSongsInAlbum.Controls.Add(lblMsg);
        }

        private void UC_Library_Load(object sender, EventArgs e)
        {
            LoadUserAlbums();
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            // 1. Ẩn các danh sách cũ đi
            flpAlbums.Visible = false;
            panelAlbumDetail.Visible = false;
            btnAddSongToAlbum.Visible = false;

            // 2. Tính toán tọa độ X, Y để đặt panelCreateAlbum vào chính giữa UC_Library
            int x = (this.Width - panelCreateAlbum.Width) / 2;
            int y = (this.Height - panelCreateAlbum.Height) / 2;
            panelCreateAlbum.Location = new Point(x, y);

            // 3. Hiển thị Panel lên trên cùng
            panelCreateAlbum.Visible = true;
            panelCreateAlbum.BringToFront();

            ucCreateAlbumArea.OnCancel = () => {
                LoadUserAlbums();
            };

            // --- ĐÃ SỬA LẠI CHÍNH XÁC THEO TẦNG BUS/DAL CỦA BẠN ---
            ucCreateAlbumArea.OnConfirm = (newAlbumName) => {
                try
                {
                    // Gọi hàm TaoAlbumMoi và chỉ truyền 2 tham số: Tên album và ID người dùng hiện tại
                    // ID của Album (ALB_mmss) sẽ tự động được sinh ra một cách an toàn ở tầng DAL
                    bool checkLuu = albumBUS.TaoAlbumMoi(newAlbumName, currentUserID);

                    if (checkLuu)
                    {
                        MessageBox.Show($"Tạo album '{newAlbumName}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Lưu thành công -> Đóng khung nhập và tự động quét lại MySQL để vẽ Album mới lên giao diện
                        LoadUserAlbums();
                    }
                    else
                    {
                        MessageBox.Show("Tạo album thất bại. Vui lòng kiểm tra lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi tạo Album: " + ex.Message, "Lỗi kết nối MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void btnAddSongToAlbum_Click(object sender, EventArgs e)
        {
            // Kiểm tra an toàn: Nếu chưa có Album nào được mở thực sự thì không làm gì cả
            if (string.IsNullOrEmpty(currentOpeningAlbumID))
            {
                MessageBox.Show("Không tìm thấy thông tin Album hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Khởi tạo Form popup chọn bài hát và truyền vào ID, Tên của Album đang mở
            Form_SelectSong frmSelect = new Form_SelectSong(currentOpeningAlbumID, currentOpeningAlbumName);

            // 2. Đăng ký hành động (Delegate): Khi người dùng click thêm bài hát bên Form nhỏ thành công,
            // nó sẽ kích hoạt Action này để ép UC_Library gọi lại hàm ShowAllSong.
            // Việc này giúp danh sách bài hát hiển thị phía sau tự động cập nhật ngay lập tức mà không cần tắt bật lại Album.
            frmSelect.OnSongAddedSuccess = () => {
                ShowAllSong(currentOpeningAlbumID, currentOpeningAlbumName);
            };

            // 3. Hiển thị Form dạng Dialog (Form con sẽ đè lên giữa Form chính, chặn tương tác phía sau cho đến khi đóng)
            frmSelect.ShowDialog();
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOpeningAlbumID)) return;

            // 1. Hiện hộp thoại hỏi lại cho chắc chắn, tránh người dùng bấm nhầm
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa album '{currentOpeningAlbumName}' không?\nToàn bộ danh sách nhạc trong album này sẽ bị xóa bỏ!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 2. Gọi tầng BUS thực hiện xóa
                    bool checkXoa = albumBUS.XoaAlbum(currentOpeningAlbumID);

                    if (checkXoa)
                    {
                        MessageBox.Show("Xóa album thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3. Xóa thành công -> Gọi hàm LoadUserAlbums để tự động chuyển vùng hiển thị
                        // về lại danh sách album chính và quét lại database để cập nhật giao diện mới
                        LoadUserAlbums();
                    }
                    else
                    {
                        MessageBox.Show("Xóa album thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi xóa Album: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}