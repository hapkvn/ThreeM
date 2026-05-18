using Kiemtragiuaki.DTO;
using Kiemtragiuaki.BUS;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Kiemtragiuaki.GUI
{
    public partial class Form1 : Form
    {
        public static string selectedAlbumID = "";

        //ds
        private NAudio.Wave.WaveOutEvent outputDevice;
        private NAudio.Wave.AudioFileReader audioFile;

        private List<string> playlist = new List<string>();
        private int currentIndex = -1;

        private bool isRepeat = false;
        private Color repeatGreen = Color.FromArgb(30, 215, 96); 
        public Form1()
        {
            InitializeComponent();
            
        }





        private void renderPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;

            pnMain.Controls.Clear();

            pnMain.Controls.Add(page);

            page.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();

            // Sửa lại đoạn này để nhận 2 tham số (musicPath và categoryList)
            home.OnSongSelected = (musicPath, categoryList) => {
                // Cập nhật "kho dữ liệu" cho Form1
                this.playlist = categoryList;

                // Xác định vị trí bài đang phát trong danh sách mới này
                this.currentIndex = playlist.IndexOf(musicPath);

                // Phát nhạc
                PlayMusic(musicPath);
            };

            renderPage(home);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            UC_Library uc = new UC_Library();

            uc.OnSongSelected = (musicPath) => {
                PlayMusic(musicPath);
            };

            pnMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uc);




        }



        private void timeMusic_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                // Cập nhật vị trí thanh bar
                playBar.Value = (int)audioFile.CurrentTime.TotalSeconds;

                // Cập nhật nhãn thời gian hiện tại (Định dạng m:ss)
                lblCurrentTime.Text = audioFile.CurrentTime.ToString(@"m\:ss");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timeMusic = new Timer();
            timeMusic.Interval = 1000;
            timeMusic.Tick += timeMusic_Tick;
            playBar.MouseClick += playBar_MouseClick;

            UC_Home home = new UC_Home();

            home.OnSongSelected = (musicPath, categoryList) => {
                this.playlist = categoryList;
                this.currentIndex = playlist.IndexOf(musicPath);
                PlayMusic(musicPath);
            };

            renderPage(home);
        }

        private void PlayMusic(string file)
        {
            try
            {
                string pathChuan = file.Replace("/", "\\");
                if (!System.IO.File.Exists(pathChuan)) return;

                if (outputDevice != null)
                {
                    outputDevice.Stop(); // Dừng phát ngay lập tức
                    outputDevice.PlaybackStopped -= OnPlaybackStopped; // Hủy đăng ký tạm thời để tránh lặp vô hạn
                    outputDevice.Dispose();
                    outputDevice = null;
                }

                if (audioFile != null)
                {
                    audioFile.Dispose();
                    audioFile = null;
                }
                // ---------------------

                audioFile = new AudioFileReader(pathChuan);
                outputDevice = new WaveOutEvent();

                // Đăng ký lại sự kiện sau khi đã khởi tạo mới
                outputDevice.PlaybackStopped += OnPlaybackStopped;

                outputDevice.Init(audioFile);
                outputDevice.Play();

                pnBottom.Visible = true;

                playBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                lblTotalTime.Text = audioFile.TotalTime.ToString(@"m\:ss");
                timeMusic.Start();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi như trong image_a2f17e.png sẽ không còn xuất hiện nữa
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Sử dụng Invoke để tránh lỗi xung đột luồng (Thread) vì NAudio chạy luồng riêng
            this.Invoke(new Action(() =>
            {
                if (isRepeat)
                {
                    // Nếu đang bật Repeat: Phát lại bài hiện tại
                    PlayMusic(playlist[currentIndex]);
                }
                else
                {
                    // Nếu không bật Repeat: Tự động bấm nút Next để sang bài mới
                    btnNext_Click(null, null);
                }
            }));
        }


        private void playBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                double ratio = (double)e.X / (double)playBar.Width;
                double newPosition = ratio * audioFile.TotalTime.TotalSeconds;

                if (newPosition >= 0 && newPosition <= audioFile.TotalTime.TotalSeconds)
                {
                    audioFile.CurrentTime = TimeSpan.FromSeconds(newPosition);
                    playBar.Value = (int)newPosition;

                    // Cập nhật nhãn ngay lập tức khi vừa click tua
                    lblCurrentTime.Text = audioFile.CurrentTime.ToString(@"m\:ss");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa có danh sách thì thoát
            if (playlist == null || playlist.Count == 0) return;

            // Tăng index, nếu quá bài cuối thì về 0
            currentIndex++;
            if (currentIndex >= playlist.Count)
            {
                currentIndex = 0;
            }

            // Phát bài tiếp theo
            PlayMusic(playlist[currentIndex]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra danh sách có dữ liệu không
            if (playlist == null || playlist.Count == 0) return;

            // 2. Giảm vị trí bài hát hiện tại xuống 1
            currentIndex--;

            // 3. Nếu vị trí nhỏ hơn 0 (đang ở bài đầu mà bấm lùi)
            // thì quay về bài cuối cùng của danh sách
            if (currentIndex < 0)
            {
                currentIndex = playlist.Count - 1;
            }

            // 4. Phát nhạc bài ở vị trí mới
            PlayMusic(playlist[currentIndex]);
        }

        

        private void btnPause_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã có bài nhạc nào được nạp chưa
            if (outputDevice == null || audioFile == null) return;

            // 2. Kiểm tra trạng thái hiện tại
            if (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                // Nếu đang phát thì Tạm dừng
                outputDevice.Pause();

               
            }
            else if (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Paused ||
                     outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Stopped)
            {
                // Nếu đang dừng hoặc tạm nghỉ thì Phát tiếp
                outputDevice.Play();

               
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            // 1. Đảo trạng thái true <-> false
            isRepeat = !isRepeat;

            // 2. Thay đổi màu sắc hiển thị (giống image_aebc36.png)
            if (isRepeat)
            {
                btnRepeat.FillColor = repeatGreen;
                
            }
            else
            {
                btnRepeat.FillColor = Color.Transparent;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UC_Setting settingPage = new UC_Setting();
            renderPage(settingPage);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                Application.Restart();
            }
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new Quan_ly_nhac().ShowDialog();
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            new UserManagerForm().ShowDialog();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            new QuanLyTheLoaiForm().ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bool isAdminUser = Session.IsAdmin;

            btnAdmin.Visible = isAdminUser;
            btnUserManager.Visible = isAdminUser;
            btnTheLoai.Visible = isAdminUser;
        }
    }
}
       