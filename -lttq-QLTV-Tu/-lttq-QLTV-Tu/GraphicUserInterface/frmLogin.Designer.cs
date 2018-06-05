namespace GraphicUserInterface
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.frmLoginLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlLoginWelcome = new System.Windows.Forms.Panel();
            this.picCopyrightLoading = new System.Windows.Forms.PictureBox();
            this.picLoginLoading = new System.Windows.Forms.PictureBox();
            this.lblLoginLoading = new System.Windows.Forms.Label();
            this.pnlLoginLoading1 = new System.Windows.Forms.Panel();
            this.pnlLoginLoading2 = new System.Windows.Forms.Panel();
            this.lblLoginTenThuThu = new System.Windows.Forms.Label();
            this.lblLoginHeaderWelcome = new System.Windows.Forms.Label();
            this.pnlLoginThongTinDN = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picCopyrightLogin = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.lblLoginThongBao = new System.Windows.Forms.Label();
            this.btnLoginESC = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.frmLoginLoading = new System.Windows.Forms.Timer(this.components);
            this.pnlLoginHeader = new System.Windows.Forms.Panel();
            this.pnlLoginWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyrightLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLoading)).BeginInit();
            this.pnlLoginLoading1.SuspendLayout();
            this.pnlLoginThongTinDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyrightLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // frmLoginLoadTimer
            // 
            this.frmLoginLoadTimer.Enabled = true;
            this.frmLoginLoadTimer.Tick += new System.EventHandler(this.frmLoginTimer_Tick);
            // 
            // pnlLoginWelcome
            // 
            this.pnlLoginWelcome.Controls.Add(this.picCopyrightLoading);
            this.pnlLoginWelcome.Controls.Add(this.picLoginLoading);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginLoading);
            this.pnlLoginWelcome.Controls.Add(this.pnlLoginLoading1);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginTenThuThu);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginHeaderWelcome);
            this.pnlLoginWelcome.Location = new System.Drawing.Point(12, 0);
            this.pnlLoginWelcome.Name = "pnlLoginWelcome";
            this.pnlLoginWelcome.Size = new System.Drawing.Size(810, 487);
            this.pnlLoginWelcome.TabIndex = 12;
            // 
            // picCopyrightLoading
            // 
            this.picCopyrightLoading.Image = ((System.Drawing.Image)(resources.GetObject("picCopyrightLoading.Image")));
            this.picCopyrightLoading.Location = new System.Drawing.Point(323, 429);
            this.picCopyrightLoading.Name = "picCopyrightLoading";
            this.picCopyrightLoading.Size = new System.Drawing.Size(150, 28);
            this.picCopyrightLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCopyrightLoading.TabIndex = 25;
            this.picCopyrightLoading.TabStop = false;
            // 
            // picLoginLoading
            // 
            this.picLoginLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoginLoading.Image")));
            this.picLoginLoading.Location = new System.Drawing.Point(60, 31);
            this.picLoginLoading.Name = "picLoginLoading";
            this.picLoginLoading.Size = new System.Drawing.Size(344, 103);
            this.picLoginLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginLoading.TabIndex = 24;
            this.picLoginLoading.TabStop = false;
            // 
            // lblLoginLoading
            // 
            this.lblLoginLoading.AutoSize = true;
            this.lblLoginLoading.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoginLoading.Location = new System.Drawing.Point(347, 390);
            this.lblLoginLoading.Name = "lblLoginLoading";
            this.lblLoginLoading.Size = new System.Drawing.Size(109, 30);
            this.lblLoginLoading.TabIndex = 12;
            this.lblLoginLoading.Text = "Loading . . .";
            // 
            // pnlLoginLoading1
            // 
            this.pnlLoginLoading1.BackColor = System.Drawing.Color.Gray;
            this.pnlLoginLoading1.Controls.Add(this.pnlLoginLoading2);
            this.pnlLoginLoading1.Location = new System.Drawing.Point(41, 374);
            this.pnlLoginLoading1.Name = "pnlLoginLoading1";
            this.pnlLoginLoading1.Size = new System.Drawing.Size(720, 3);
            this.pnlLoginLoading1.TabIndex = 11;
            // 
            // pnlLoginLoading2
            // 
            this.pnlLoginLoading2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.pnlLoginLoading2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginLoading2.BackgroundImage")));
            this.pnlLoginLoading2.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLoading2.Name = "pnlLoginLoading2";
            this.pnlLoginLoading2.Size = new System.Drawing.Size(10, 3);
            this.pnlLoginLoading2.TabIndex = 12;
            // 
            // lblLoginTenThuThu
            // 
            this.lblLoginTenThuThu.AutoSize = true;
            this.lblLoginTenThuThu.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTenThuThu.ForeColor = System.Drawing.Color.White;
            this.lblLoginTenThuThu.Location = new System.Drawing.Point(62, 179);
            this.lblLoginTenThuThu.Name = "lblLoginTenThuThu";
            this.lblLoginTenThuThu.Size = new System.Drawing.Size(0, 42);
            this.lblLoginTenThuThu.TabIndex = 2;
            // 
            // lblLoginHeaderWelcome
            // 
            this.lblLoginHeaderWelcome.AutoSize = true;
            this.lblLoginHeaderWelcome.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeaderWelcome.ForeColor = System.Drawing.Color.White;
            this.lblLoginHeaderWelcome.Location = new System.Drawing.Point(62, 137);
            this.lblLoginHeaderWelcome.Name = "lblLoginHeaderWelcome";
            this.lblLoginHeaderWelcome.Size = new System.Drawing.Size(153, 42);
            this.lblLoginHeaderWelcome.TabIndex = 1;
            this.lblLoginHeaderWelcome.Text = "WELCOME";
            // 
            // pnlLoginThongTinDN
            // 
            this.pnlLoginThongTinDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginThongTinDN.Controls.Add(this.picLogo);
            this.pnlLoginThongTinDN.Controls.Add(this.picCopyrightLogin);
            this.pnlLoginThongTinDN.Controls.Add(this.picLogin);
            this.pnlLoginThongTinDN.Controls.Add(this.lblLoginThongBao);
            this.pnlLoginThongTinDN.Controls.Add(this.btnLoginESC);
            this.pnlLoginThongTinDN.Controls.Add(this.txtMatKhau);
            this.pnlLoginThongTinDN.Controls.Add(this.txtTaiKhoan);
            this.pnlLoginThongTinDN.Controls.Add(this.btnDangNhap);
            this.pnlLoginThongTinDN.Controls.Add(this.lblTaiKhoan);
            this.pnlLoginThongTinDN.Controls.Add(this.lblMatKhau);
            this.pnlLoginThongTinDN.Location = new System.Drawing.Point(12, 0);
            this.pnlLoginThongTinDN.Name = "pnlLoginThongTinDN";
            this.pnlLoginThongTinDN.Size = new System.Drawing.Size(810, 487);
            this.pnlLoginThongTinDN.TabIndex = 13;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 442);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // picCopyrightLogin
            // 
            this.picCopyrightLogin.Image = ((System.Drawing.Image)(resources.GetObject("picCopyrightLogin.Image")));
            this.picCopyrightLogin.Location = new System.Drawing.Point(53, 454);
            this.picCopyrightLogin.Name = "picCopyrightLogin";
            this.picCopyrightLogin.Size = new System.Drawing.Size(150, 24);
            this.picCopyrightLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCopyrightLogin.TabIndex = 23;
            this.picCopyrightLogin.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(4, 3);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(344, 103);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 22;
            this.picLogin.TabStop = false;
            // 
            // lblLoginThongBao
            // 
            this.lblLoginThongBao.AutoSize = true;
            this.lblLoginThongBao.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoginThongBao.ForeColor = System.Drawing.Color.Transparent;
            this.lblLoginThongBao.Location = new System.Drawing.Point(502, 283);
            this.lblLoginThongBao.Name = "lblLoginThongBao";
            this.lblLoginThongBao.Size = new System.Drawing.Size(0, 19);
            this.lblLoginThongBao.TabIndex = 19;
            // 
            // btnLoginESC
            // 
            this.btnLoginESC.FlatAppearance.BorderSize = 0;
            this.btnLoginESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginESC.ForeColor = System.Drawing.Color.White;
            this.btnLoginESC.Location = new System.Drawing.Point(785, 3);
            this.btnLoginESC.Name = "btnLoginESC";
            this.btnLoginESC.Size = new System.Drawing.Size(24, 24);
            this.btnLoginESC.TabIndex = 17;
            this.btnLoginESC.Text = "X";
            this.btnLoginESC.UseVisualStyleBackColor = true;
            this.btnLoginESC.Click += new System.EventHandler(this.btnLoginESC_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(506, 249);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(293, 31);
            this.txtMatKhau.TabIndex = 15;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(506, 168);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(293, 31);
            this.txtTaiKhoan.TabIndex = 13;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(506, 362);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(293, 48);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTaiKhoan.Location = new System.Drawing.Point(478, 137);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(99, 28);
            this.lblTaiKhoan.TabIndex = 12;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblMatKhau.Location = new System.Drawing.Point(478, 218);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(95, 28);
            this.lblMatKhau.TabIndex = 14;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // frmLoginLoading
            // 
            this.frmLoginLoading.Tick += new System.EventHandler(this.frmLoginLoading_Tick);
            // 
            // pnlLoginHeader
            // 
            this.pnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.pnlLoginHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginHeader.BackgroundImage")));
            this.pnlLoginHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginHeader.Name = "pnlLoginHeader";
            this.pnlLoginHeader.Size = new System.Drawing.Size(10, 487);
            this.pnlLoginHeader.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(823, 487);
            this.Controls.Add(this.pnlLoginThongTinDN);
            this.Controls.Add(this.pnlLoginWelcome);
            this.Controls.Add(this.pnlLoginHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginWelcome.ResumeLayout(false);
            this.pnlLoginWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyrightLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLoading)).EndInit();
            this.pnlLoginLoading1.ResumeLayout(false);
            this.pnlLoginThongTinDN.ResumeLayout(false);
            this.pnlLoginThongTinDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyrightLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer frmLoginLoadTimer;
        private System.Windows.Forms.Panel pnlLoginHeader;
        private System.Windows.Forms.Panel pnlLoginWelcome;
        private System.Windows.Forms.Label lblLoginTenThuThu;
        private System.Windows.Forms.Label lblLoginHeaderWelcome;
        private System.Windows.Forms.Panel pnlLoginThongTinDN;
        private System.Windows.Forms.Button btnLoginESC;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblLoginLoading;
        private System.Windows.Forms.Panel pnlLoginLoading1;
        private System.Windows.Forms.Panel pnlLoginLoading2;
        private System.Windows.Forms.Timer frmLoginLoading;
        private System.Windows.Forms.Label lblLoginThongBao;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picLoginLoading;
        private System.Windows.Forms.PictureBox picCopyrightLoading;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picCopyrightLogin;
    }
}

