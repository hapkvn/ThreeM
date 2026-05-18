namespace Kiemtragiuaki.GUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.Minizime = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Max = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.pnBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRepeat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPause = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.playBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timeMusic = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTheLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.Minizime);
            this.pnTop.Controls.Add(this.Max);
            this.pnTop.Controls.Add(this.Close);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(200, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1000, 44);
            this.pnTop.TabIndex = 2;
            // 
            // Minizime
            // 
            this.Minizime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minizime.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minizime.FillColor = System.Drawing.Color.Transparent;
            this.Minizime.HoverState.FillColor = System.Drawing.Color.Gray;
            this.Minizime.IconColor = System.Drawing.Color.White;
            this.Minizime.Location = new System.Drawing.Point(812, 12);
            this.Minizime.Margin = new System.Windows.Forms.Padding(4);
            this.Minizime.Name = "Minizime";
            this.Minizime.Size = new System.Drawing.Size(45, 29);
            this.Minizime.TabIndex = 2;
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.Max.FillColor = System.Drawing.Color.Transparent;
            this.Max.HoverState.FillColor = System.Drawing.Color.Gray;
            this.Max.IconColor = System.Drawing.Color.White;
            this.Max.Location = new System.Drawing.Point(880, 12);
            this.Max.Margin = new System.Windows.Forms.Padding(4);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(45, 29);
            this.Max.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.FillColor = System.Drawing.Color.Transparent;
            this.Close.HoverState.FillColor = System.Drawing.Color.Gray;
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(943, 12);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 29);
            this.Close.TabIndex = 0;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnMain.Location = new System.Drawing.Point(200, 44);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1000, 594);
            this.pnMain.TabIndex = 3;
            this.pnMain.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(430, 73);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(44, 16);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.Text = "label1";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(797, 73);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(44, 16);
            this.lblTotalTime.TabIndex = 5;
            this.lblTotalTime.Text = "label2";
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.lblTotalTime);
            this.pnBottom.Controls.Add(this.lblCurrentTime);
            this.pnBottom.Controls.Add(this.btnRepeat);
            this.pnBottom.Controls.Add(this.btnPause);
            this.pnBottom.Controls.Add(this.btnPrev);
            this.pnBottom.Controls.Add(this.btnNext);
            this.pnBottom.Controls.Add(this.playBar);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnBottom.Location = new System.Drawing.Point(0, 638);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1200, 100);
            this.pnBottom.TabIndex = 0;
            this.pnBottom.Visible = false;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRepeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRepeat.FillColor = System.Drawing.Color.Transparent;
            this.btnRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Image = global::Kiemtragiuaki.Properties.Resources.repeat_button;
            this.btnRepeat.Location = new System.Drawing.Point(728, 15);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRepeat.Size = new System.Drawing.Size(52, 53);
            this.btnRepeat.TabIndex = 3;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Image = global::Kiemtragiuaki.Properties.Resources.right_arrow__1_;
            this.btnPause.Location = new System.Drawing.Point(571, 15);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPause.Size = new System.Drawing.Size(52, 53);
            this.btnPause.TabIndex = 2;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = global::Kiemtragiuaki.Properties.Resources.ui;
            this.btnPrev.Location = new System.Drawing.Point(490, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.Size = new System.Drawing.Size(52, 53);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::Kiemtragiuaki.Properties.Resources.next_button;
            this.btnNext.Location = new System.Drawing.Point(648, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(52, 53);
            this.btnNext.TabIndex = 0;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // playBar
            // 
            this.playBar.BorderRadius = 6;
            this.playBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.playBar.Location = new System.Drawing.Point(480, 73);
            this.playBar.Margin = new System.Windows.Forms.Padding(2);
            this.playBar.Name = "playBar";
            this.playBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.playBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.playBar.Size = new System.Drawing.Size(300, 16);
            this.playBar.TabIndex = 0;
            this.playBar.Text = "guna2ProgressBar1";
            this.playBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.playBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playBar_MouseClick);
            // 
            // timeMusic
            // 
            this.timeMusic.Enabled = true;
            this.timeMusic.Interval = 1000;
            this.timeMusic.Tick += new System.EventHandler(this.timeMusic_Tick);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnTop;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnLeft;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.btnTheLoai);
            this.pnLeft.Controls.Add(this.btnUserManager);
            this.pnLeft.Controls.Add(this.btnAdmin);
            this.pnLeft.Controls.Add(this.btnLogOut);
            this.pnLeft.Controls.Add(this.guna2HtmlLabel1);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.pnLeft.Controls.Add(this.btnList);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.pnLeft.Size = new System.Drawing.Size(200, 638);
            this.pnLeft.TabIndex = 1;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.BorderRadius = 10;
            this.btnTheLoai.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnTheLoai.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTheLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTheLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTheLoai.FillColor = System.Drawing.Color.Transparent;
            this.btnTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnTheLoai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTheLoai.Location = new System.Drawing.Point(12, 342);
            this.btnTheLoai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(188, 39);
            this.btnTheLoai.TabIndex = 8;
            this.btnTheLoai.Text = "Quản lý Thể loại";
            this.btnTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.BorderRadius = 10;
            this.btnUserManager.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnUserManager.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnUserManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserManager.FillColor = System.Drawing.Color.Transparent;
            this.btnUserManager.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUserManager.ForeColor = System.Drawing.Color.White;
            this.btnUserManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUserManager.Location = new System.Drawing.Point(12, 298);
            this.btnUserManager.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(152, 39);
            this.btnUserManager.TabIndex = 7;
            this.btnUserManager.Text = "Cấp quyền";
            this.btnUserManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BorderRadius = 10;
            this.btnAdmin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAdmin.Location = new System.Drawing.Point(12, 254);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(152, 39);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Quản lý nhạc";
            this.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 10;
            this.btnLogOut.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnLogOut.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogOut.Location = new System.Drawing.Point(12, 210);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(152, 39);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 18);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(212, 60);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "<b><span style=\"color: #1DB954;\">My Music\r\n</span> </b>";
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 10;
            this.btnSetting.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnSetting.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSetting.Location = new System.Drawing.Point(12, 167);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(127, 38);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnList
            // 
            this.btnList.BorderRadius = 10;
            this.btnList.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnList.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnList.FillColor = System.Drawing.Color.Transparent;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnList.Location = new System.Drawing.Point(12, 124);
            this.btnList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(142, 38);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Thư Viện";
            this.btnList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 10;
            this.btnHome.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.Location = new System.Drawing.Point(12, 86);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnTop.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox Max;
        private Guna.UI2.WinForms.Guna2ControlBox Minizime;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Panel pnBottom;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private Guna.UI2.WinForms.Guna2CircleButton btnRepeat;
        private Guna.UI2.WinForms.Guna2CircleButton btnPause;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2ProgressBar playBar;
        private System.Windows.Forms.Timer timeMusic;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnUserManager;
        private Guna.UI2.WinForms.Guna2Button btnTheLoai;
    }
}

