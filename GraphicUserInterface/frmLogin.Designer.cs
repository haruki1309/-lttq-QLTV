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
            this.lblMaThuThu = new System.Windows.Forms.Label();
            this.tbx_MaThuThu = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cbxHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMaThuThu
            // 
            this.lblMaThuThu.AutoSize = true;
            this.lblMaThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThuThu.Location = new System.Drawing.Point(12, 15);
            this.lblMaThuThu.Name = "lblMaThuThu";
            this.lblMaThuThu.Size = new System.Drawing.Size(85, 17);
            this.lblMaThuThu.TabIndex = 0;
            this.lblMaThuThu.Text = "Mã Thủ Thư";
            // 
            // tbx_MaThuThu
            // 
            this.tbx_MaThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_MaThuThu.Location = new System.Drawing.Point(103, 12);
            this.tbx_MaThuThu.Name = "tbx_MaThuThu";
            this.tbx_MaThuThu.Size = new System.Drawing.Size(311, 23);
            this.tbx_MaThuThu.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(12, 52);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(68, 17);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_MatKhau.Location = new System.Drawing.Point(103, 49);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.PasswordChar = '*';
            this.tbx_MatKhau.Size = new System.Drawing.Size(311, 23);
            this.tbx_MatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(140, 115);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(153, 48);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cbxHienThiMatKhau
            // 
            this.cbxHienThiMatKhau.AutoSize = true;
            this.cbxHienThiMatKhau.Location = new System.Drawing.Point(103, 88);
            this.cbxHienThiMatKhau.Name = "cbxHienThiMatKhau";
            this.cbxHienThiMatKhau.Size = new System.Drawing.Size(115, 17);
            this.cbxHienThiMatKhau.TabIndex = 5;
            this.cbxHienThiMatKhau.Text = "Hiển Thị Mật Khẩu";
            this.cbxHienThiMatKhau.UseVisualStyleBackColor = true;
           
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 175);
            this.Controls.Add(this.cbxHienThiMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.tbx_MaThuThu);
            this.Controls.Add(this.lblMaThuThu);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaThuThu;
        private System.Windows.Forms.TextBox tbx_MaThuThu;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox tbx_MatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox cbxHienThiMatKhau;
    }
}

