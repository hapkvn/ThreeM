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
using Kiemtragiuaki.DTO;
namespace Kiemtragiuaki.GUI
{
    public partial class Form1 : Form
    {
        //ds
        private NAudio.Wave.WaveOutEvent outputDevice;
        private NAudio.Wave.AudioFileReader audioFile;

        

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

            // Lắng nghe sự kiện phát nhạc từ UC_Home
            home.OnSongSelected = (musicPath) => {
                PlayMusic(musicPath); // Hàm này trong Form1 của ông sẽ lo phần NAudio và PlayBar
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
                playBar.Value = (int)audioFile.CurrentTime.TotalSeconds;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeMusic = new Timer();
            timeMusic.Interval = 1000;
            timeMusic.Tick += timeMusic_Tick;
            playBar.MouseClick += playBar_MouseClick;
        }

        private void PlayMusic(string file)
        {
            try
            {
                // 1. Chuyển đổi tất cả thành dấu gạch chéo chuẩn của Windows
                string pathChuan = file.Replace("/", "\\");

                // 2. Kiểm tra thực tế file có tồn tại không trước khi nạp vào NAudio
                if (!System.IO.File.Exists(pathChuan))
                {
                    MessageBox.Show("Lỗi: Không tìm thấy file tại:\n" + pathChuan, "Sai đường dẫn");
                    return;
                }

                outputDevice?.Stop();
                outputDevice?.Dispose();
                audioFile?.Dispose();

                audioFile = new AudioFileReader(pathChuan); // Dùng pathChuan đã sửa
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();

                playBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                timeMusic.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }





        private void playBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                // Tính toán vị trí click
                double ratio = (double)e.X / (double)playBar.Width;
                double newPosition = ratio * audioFile.TotalTime.TotalSeconds;

                // Kiểm tra hợp lệ để tránh văng app
                if (newPosition >= 0 && newPosition <= audioFile.TotalTime.TotalSeconds)
                {
                    // Nhảy nhạc
                    audioFile.CurrentTime = TimeSpan.FromSeconds(newPosition);

                    // Cập nhật thanh bar ngay lập tức để thấy kết quả
                    playBar.Value = (int)newPosition;
                }
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
