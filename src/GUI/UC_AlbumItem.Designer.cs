namespace Kiemtragiuaki.GUI
{
    partial class UC_AlbumItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLetter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAlbumName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblLetter);
            this.guna2Panel1.Location = new System.Drawing.Point(38, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(80, 80);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = false;
            this.lblLetter.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.Location = new System.Drawing.Point(0, 28);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(93, 77);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.Text = "guna2HtmlLabel1";
            this.lblLetter.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = false;
            this.lblAlbumName.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumName.ForeColor = System.Drawing.Color.White;
            this.lblAlbumName.Location = new System.Drawing.Point(-13, 102);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(183, 58);
            this.lblAlbumName.TabIndex = 1;
            this.lblAlbumName.Text = "guna2HtmlLabel1";
            this.lblAlbumName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_AlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblAlbumName);
            this.Name = "UC_AlbumItem";
            this.Size = new System.Drawing.Size(160, 160);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLetter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAlbumName;
    }
}
