namespace Kiemtragiuaki.GUI
{
    partial class Form_SelectSong
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
            this.flpSelectSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSelectSongs
            // 
            this.flpSelectSongs.AutoScroll = true;
            this.flpSelectSongs.Location = new System.Drawing.Point(0, 0);
            this.flpSelectSongs.Name = "flpSelectSongs";
            this.flpSelectSongs.Size = new System.Drawing.Size(800, 450);
            this.flpSelectSongs.TabIndex = 0;
            // 
            // Form_SelectSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpSelectSongs);
            this.Name = "Form_SelectSong";
            this.Text = "Form_SelectSong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSelectSongs;
    }
}