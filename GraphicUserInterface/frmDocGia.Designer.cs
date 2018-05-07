namespace GraphicUserInterface
{
    partial class frmDocGia
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxHoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.clbThuocTinh = new System.Windows.Forms.CheckedListBox();
            this.btnSearchFor = new System.Windows.Forms.Button();
            this.btnFinishSearch = new System.Windows.Forms.Button();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.cboSearchFor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(37, 198);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 21);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(126, 134);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(207, 20);
            this.dtpNgaySinh.TabIndex = 24;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDK.Location = new System.Drawing.Point(126, 162);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(207, 20);
            this.dtpNgayDK.TabIndex = 23;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCMND.Location = new System.Drawing.Point(126, 108);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(207, 20);
            this.tbxCMND.TabIndex = 21;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSDT.Location = new System.Drawing.Point(126, 79);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(207, 20);
            this.tbxSDT.TabIndex = 20;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChi.Location = new System.Drawing.Point(126, 50);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(207, 20);
            this.tbxDiaChi.TabIndex = 19;
            // 
            // tbxHoten
            // 
            this.tbxHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoten.Location = new System.Drawing.Point(126, 21);
            this.tbxHoten.Name = "tbxHoten";
            this.tbxHoten.Size = new System.Drawing.Size(207, 20);
            this.tbxHoten.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày Đăng Ký:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ Tên:";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(5, 10);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.Size = new System.Drawing.Size(659, 511);
            this.dgvDocGia.TabIndex = 2;
            this.dgvDocGia.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocGia_RowHeaderMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 21);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(231, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 21);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(253, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(79, 21);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // clbThuocTinh
            // 
            this.clbThuocTinh.BackColor = System.Drawing.Color.White;
            this.clbThuocTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbThuocTinh.CheckOnClick = true;
            this.clbThuocTinh.ColumnWidth = 75;
            this.clbThuocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbThuocTinh.FormattingEnabled = true;
            this.clbThuocTinh.Items.AddRange(new object[] {
            "Địa chỉ",
            "SĐT",
            "CMND",
            "Ngày  sinh",
            "Ngày ĐK"});
            this.clbThuocTinh.Location = new System.Drawing.Point(3, 3);
            this.clbThuocTinh.MultiColumn = true;
            this.clbThuocTinh.Name = "clbThuocTinh";
            this.clbThuocTinh.Size = new System.Drawing.Size(243, 30);
            this.clbThuocTinh.TabIndex = 5;
            this.clbThuocTinh.SelectedIndexChanged += new System.EventHandler(this.clbThuocTinh_SelectedIndexChanged);
            // 
            // btnSearchFor
            // 
            this.btnSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFor.Location = new System.Drawing.Point(253, 3);
            this.btnSearchFor.Name = "btnSearchFor";
            this.btnSearchFor.Size = new System.Drawing.Size(79, 21);
            this.btnSearchFor.TabIndex = 4;
            this.btnSearchFor.Text = "Tìm kiếm";
            this.btnSearchFor.UseVisualStyleBackColor = true;
            this.btnSearchFor.Click += new System.EventHandler(this.btnSearchFor_Click);
            // 
            // btnFinishSearch
            // 
            this.btnFinishSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishSearch.Location = new System.Drawing.Point(256, 131);
            this.btnFinishSearch.Name = "btnFinishSearch";
            this.btnFinishSearch.Size = new System.Drawing.Size(79, 21);
            this.btnFinishSearch.TabIndex = 7;
            this.btnFinishSearch.Text = "Hoàn tất";
            this.btnFinishSearch.UseVisualStyleBackColor = true;
            this.btnFinishSearch.Click += new System.EventHandler(this.btnFinishSearch_Click);
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFor.Location = new System.Drawing.Point(3, 30);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(174, 20);
            this.txtSearchFor.TabIndex = 6;
            this.txtSearchFor.Visible = false;
            // 
            // cboSearchFor
            // 
            this.cboSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchFor.FormattingEnabled = true;
            this.cboSearchFor.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả",
            "CMND",
            "Số điện thoại"});
            this.cboSearchFor.Location = new System.Drawing.Point(3, 3);
            this.cboSearchFor.Name = "cboSearchFor";
            this.cboSearchFor.Size = new System.Drawing.Size(121, 21);
            this.cboSearchFor.TabIndex = 5;
            this.cboSearchFor.Text = "Tìm kiếm theo";
            this.cboSearchFor.SelectedIndexChanged += new System.EventHandler(this.cboSearchFor_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(669, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 127);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sách";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpNgaySinh);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.dtpNgayDK);
            this.groupBox4.Controls.Add(this.tbxCMND);
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Controls.Add(this.tbxSDT);
            this.groupBox4.Controls.Add(this.tbxDiaChi);
            this.groupBox4.Controls.Add(this.tbxHoten);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(669, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 232);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin độc giả";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFinishSearch);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(670, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 160);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lọc và Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.clbThuocTinh);
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboSearchFor);
            this.panel2.Controls.Add(this.btnSearchFor);
            this.panel2.Controls.Add(this.txtSearchFor);
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 55);
            this.panel2.TabIndex = 1;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 528);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvDocGia);
            this.Name = "frmDocGia";
            this.Text = "Độc Giả";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckedListBox clbThuocTinh;
        private System.Windows.Forms.Button btnSearchFor;
        private System.Windows.Forms.Button btnFinishSearch;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.ComboBox cboSearchFor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}