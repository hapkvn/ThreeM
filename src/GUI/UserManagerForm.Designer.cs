namespace Kiemtragiuaki.GUI
{
    partial class UserManagerForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.btnSetAdmin = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1192, 250);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnSetUser);
            this.panel1.Controls.Add(this.btnSetAdmin);
            this.panel1.Controls.Add(this.cboRole);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 271);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(712, 174);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteUser.TabIndex = 8;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnSetUser
            // 
            this.btnSetUser.BackColor = System.Drawing.Color.Lime;
            this.btnSetUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUser.Location = new System.Drawing.Point(712, 102);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(123, 36);
            this.btnSetUser.TabIndex = 7;
            this.btnSetUser.Text = "Hạ User";
            this.btnSetUser.UseVisualStyleBackColor = false;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // btnSetAdmin
            // 
            this.btnSetAdmin.BackColor = System.Drawing.Color.Lime;
            this.btnSetAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAdmin.Location = new System.Drawing.Point(712, 36);
            this.btnSetAdmin.Name = "btnSetAdmin";
            this.btnSetAdmin.Size = new System.Drawing.Size(123, 36);
            this.btnSetAdmin.TabIndex = 6;
            this.btnSetAdmin.Text = "Cấp Admin";
            this.btnSetAdmin.UseVisualStyleBackColor = false;
            this.btnSetAdmin.Click += new System.EventHandler(this.btnSetAdmin_Click);
            // 
            // cboRole
            // 
            this.cboRole.Location = new System.Drawing.Point(145, 182);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(302, 22);
            this.cboRole.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(145, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(302, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(145, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(302, 22);
            this.txtUserID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UserManagerForm";
            this.Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cboRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.Button btnSetAdmin;
    }
}