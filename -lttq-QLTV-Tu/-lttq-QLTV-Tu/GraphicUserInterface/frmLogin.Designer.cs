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
            this.frmLoginLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlLoginHeader = new System.Windows.Forms.Panel();
            this.pnlLoginWelcome = new System.Windows.Forms.Panel();
            this.lblLoginTenThuThu = new System.Windows.Forms.Label();
            this.lblLoginHeaderWelcome = new System.Windows.Forms.Label();
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.pnlLoginThongTinDN = new System.Windows.Forms.Panel();
            this.btnLoginESC = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.pnlLoginLoading1 = new System.Windows.Forms.Panel();
            this.pnlLoginLoading2 = new System.Windows.Forms.Panel();
            this.lblLoginLoading = new System.Windows.Forms.Label();
            this.frmLoginLoading = new System.Windows.Forms.Timer(this.components);
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblLoginThongBao = new System.Windows.Forms.Label();
            this.pnlLoginWelcome.SuspendLayout();
            this.pnlLoginThongTinDN.SuspendLayout();
            this.pnlLoginLoading1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLoginLoadTimer
            // 
            this.frmLoginLoadTimer.Enabled = true;
            this.frmLoginLoadTimer.Tick += new System.EventHandler(this.frmLoginTimer_Tick);
            // 
            // pnlLoginHeader
            // 
            this.pnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.pnlLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginHeader.Name = "pnlLoginHeader";
            this.pnlLoginHeader.Size = new System.Drawing.Size(10, 487);
            this.pnlLoginHeader.TabIndex = 10;
            // 
            // pnlLoginWelcome
            // 
            this.pnlLoginWelcome.Controls.Add(this.lblLoginLoading);
            this.pnlLoginWelcome.Controls.Add(this.pnlLoginLoading1);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginTenThuThu);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginHeaderWelcome);
            this.pnlLoginWelcome.Controls.Add(this.lblLoginWelcome);
            this.pnlLoginWelcome.Location = new System.Drawing.Point(12, 0);
            this.pnlLoginWelcome.Name = "pnlLoginWelcome";
            this.pnlLoginWelcome.Size = new System.Drawing.Size(810, 487);
            this.pnlLoginWelcome.TabIndex = 12;
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
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.AutoSize = true;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Sitka Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.lblLoginWelcome.Location = new System.Drawing.Point(53, 35);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(330, 92);
            this.lblLoginWelcome.TabIndex = 0;
            this.lblLoginWelcome.Text = "MYLibrary";
            // 
            // pnlLoginThongTinDN
            // 
            this.pnlLoginThongTinDN.Controls.Add(this.lblLoginThongBao);
            this.pnlLoginThongTinDN.Controls.Add(this.lblAppName);
            this.pnlLoginThongTinDN.Controls.Add(this.btnLoginESC);
            this.pnlLoginThongTinDN.Controls.Add(this.txtMatKhau);
            this.pnlLoginThongTinDN.Controls.Add(this.txtTaiKhoan);
            this.pnlLoginThongTinDN.Controls.Add(this.btnDangNhap);
            this.pnlLoginThongTinDN.Controls.Add(this.lblTaiKhoan);
            this.pnlLoginThongTinDN.Controls.Add(this.lblMatKhau);
            this.pnlLoginThongTinDN.Location = new System.Drawing.Point(10, 0);
            this.pnlLoginThongTinDN.Name = "pnlLoginThongTinDN";
            this.pnlLoginThongTinDN.Size = new System.Drawing.Size(812, 487);
            this.pnlLoginThongTinDN.TabIndex = 13;
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
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
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
            // pnlLoginLoading1
            // 
            this.pnlLoginLoading1.BackColor = System.Drawing.Color.Gray;
            this.pnlLoginLoading1.Controls.Add(this.pnlLoginLoading2);
            this.pnlLoginLoading1.Location = new System.Drawing.Point(69, 427);
            this.pnlLoginLoading1.Name = "pnlLoginLoading1";
            this.pnlLoginLoading1.Size = new System.Drawing.Size(720, 3);
            this.pnlLoginLoading1.TabIndex = 11;
            // 
            // pnlLoginLoading2
            // 
            this.pnlLoginLoading2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.pnlLoginLoading2.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLoading2.Name = "pnlLoginLoading2";
            this.pnlLoginLoading2.Size = new System.Drawing.Size(10, 3);
            this.pnlLoginLoading2.TabIndex = 12;
            // 
            // lblLoginLoading
            // 
            this.lblLoginLoading.AutoSize = true;
            this.lblLoginLoading.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoginLoading.Location = new System.Drawing.Point(375, 433);
            this.lblLoginLoading.Name = "lblLoginLoading";
            this.lblLoginLoading.Size = new System.Drawing.Size(109, 30);
            this.lblLoginLoading.TabIndex = 12;
            this.lblLoginLoading.Text = "Loading . . .";
            // 
            // frmLoginLoading
            // 
            this.frmLoginLoading.Tick += new System.EventHandler(this.frmLoginLoading_Tick);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.lblAppName.Location = new System.Drawing.Point(6, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(181, 50);
            this.lblAppName.TabIndex = 18;
            this.lblAppName.Text = "MYLibrary";
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
            this.pnlLoginThongTinDN.ResumeLayout(false);
            this.pnlLoginThongTinDN.PerformLayout();
            this.pnlLoginLoading1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer frmLoginLoadTimer;
        private System.Windows.Forms.Panel pnlLoginHeader;
        private System.Windows.Forms.Panel pnlLoginWelcome;
        private System.Windows.Forms.Label lblLoginTenThuThu;
        private System.Windows.Forms.Label lblLoginHeaderWelcome;
        private System.Windows.Forms.Label lblLoginWelcome;
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
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblLoginThongBao;
    }
}

