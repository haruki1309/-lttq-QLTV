using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BusinessLogicLayer;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
using DataTransferObject;
>>>>>>> 6de0dae676d395e52d5e71084284e2d90f7d29c2

namespace GraphicUserInterface
{
    public partial class frmDocGia : Form
    {
        BUS_DocGia busDG = new BUS_DocGia();
        BUS_Sach busSach = new BUS_Sach();

        //Thu thu quan ly hien tai
        DTO_ThuThu dtoThuThu = new DTO_ThuThu();
        //get - set cho thuoc tinh Thu Thu
        public DTO_ThuThu DTO_ThuThu
        {
            get { return this.dtoThuThu; }
            set { this.dtoThuThu = value; }
        }
        //load du lieu tu db len cho thu thu da dang nhap
        void loadDataForThuThu()
        {
            BUS_ThuThu busThuThu = new BUS_ThuThu();
            string[] list = { "HoTen", "DiaChi", "SDT", "CMND", "Email", "NgayVL" };
            List<string> listProps = new List<string>(list);
            string condition = string.Format("MaThuThu = '{0}'", dtoThuThu.MaThuThu);
            DataTable dt = busThuThu.getThuThu(listProps, condition);

            dtoThuThu.HoTen = dt.Rows[0]["HoTen"].ToString();
            dtoThuThu.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            dtoThuThu.SoDT = dt.Rows[0]["SDT"].ToString();
            dtoThuThu.CMND = dt.Rows[0]["CMND"].ToString();
            dtoThuThu.Email = dt.Rows[0]["Email"].ToString();
            dtoThuThu.NgayVL = dt.Rows[0]["NgayVL"].ToString();
        }

        public frmDocGia()
        {
            InitializeComponent();
          
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            this.dgvDocGia.DataSource = busDG.getDocGia();
            this.pnltabDocGia.BringToFront();

            this.dgvDocGia.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
            this.dgvDocGia.Columns["HoTen"].HeaderText = "Họ Tên";
            this.dgvDocGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            this.dgvDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
            this.dgvDocGia.Columns["CMND"].HeaderText = "Chứng Minh Thư";
            this.dgvDocGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            this.dgvDocGia.Columns["NgayDK"].HeaderText = "Ngày Đăng Ký";

            this.txtHoTenDocGia.ReadOnly = true;
            this.txtDiaChiDocGia.ReadOnly = true;
            this.txtCMNDDocGia.ReadOnly = true;
            this.txtSDTDocGia.ReadOnly = true;
            this.dtmNgaySinhDocGia.Enabled = false;
            this.dtmNgayDKDocGia.Enabled = false;

            //Khoi tao du lieu cho Thu Thu da dang nhap
            this.loadDataForThuThu();

            //khoi tao du lieu cho tab Phieu Muon
            this.loadDataForCBMaDocGia();
            this.loadDataForCBMaSach();

        }

        //
        //TAB DOC GIA
        //

        private void mainbtnDocGia_Click(object sender, EventArgs e)
        {
            this.pnltabDocGia.BringToFront();
            dgvDocGia.DataSource = busDG.getDocGia();
        }

        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            this.pnlThongTinDocGia.BringToFront();
            this.pnlHightLightTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.pnlHightLightBoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
        }

        bool isClose = false; // dung cho ham TabBoLocClick va ham TabTimKiemClick      

        private void tabbtnTimKiem_Click(object sender, EventArgs e)
        {
            if (!isClose)
            {
                this.pnlSearchFor.BringToFront();
                this.pnlHightLightTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
                this.pnlHightLightBoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));

                isClose = true;
            }
            else
            {
                this.pnlThongTinDocGia.BringToFront();
                isClose = false;
            }
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {

        }

        //Chuc nang loc doc gia

        private void tabbtnBoLoc_Click(object sender, EventArgs e)
        {
            if (!isClose)
            {
                this.pnlBoLoc.BringToFront();
                this.pnlHightLightTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
                this.pnlHightLightBoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));

                isClose = true;
            }
            else
            {
                this.pnlThongTinDocGia.BringToFront();
                isClose = false;
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<string> listProperties = new List<string>();
            listProperties.Add("MaDocGia");
            listProperties.Add("HoTen");

            if (this.chkCMND.Checked)
            {
                listProperties.Add("Cmnd");
            }
            if (this.chkDiaChi.Checked)
            {
                listProperties.Add("DiaChi");
            }
            if (this.chkSDT.Checked)
            {
                listProperties.Add("SDT");
            }
            if (this.chkNgaySinh.Checked)
            {
                listProperties.Add("NgaySinh");
            }
            if (this.chkNgayDK.Checked)
            {
                listProperties.Add("NgayDK");
            }

            dgvDocGia.DataSource = busDG.getDocGia(listProperties);

            foreach (string column in listProperties)
            {
                if (column == "DiaChi")
                {
                    this.dgvDocGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                }
                else if (column == "SDT")
                {
                    this.dgvDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
                }
                else if (column == "Cmnd")
                {
                    this.dgvDocGia.Columns["CMND"].HeaderText = "Chứng Minh Thư";
                }
                else if (column == "NgaySinh")
                {
                    this.dgvDocGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                }
                else if (column == "NgayDK")
                {
                    this.dgvDocGia.Columns["NgayDK"].HeaderText = "Ngày Đăng Ký";
                }
            }
        }




        private void dgvDocGia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtHoTenDocGia.ReadOnly = true;
            this.txtDiaChiDocGia.ReadOnly = true;
            this.txtCMNDDocGia.ReadOnly = true;
            this.txtSDTDocGia.ReadOnly = true;
            this.dtmNgaySinhDocGia.Enabled = false;
            this.dtmNgayDKDocGia.Enabled = false;

            DataTable dt = busDG.getDocGia();
            txtHoTenDocGia.Text = dt.Rows[e.RowIndex]["HoTen"].ToString();
            txtDiaChiDocGia.Text = dt.Rows[e.RowIndex]["DiaChi"].ToString();
            txtCMNDDocGia.Text = dt.Rows[e.RowIndex]["CMND"].ToString();
            txtSDTDocGia.Text = dt.Rows[e.RowIndex]["SDT"].ToString();
            dtmNgaySinhDocGia.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgaySinh"].ToString());
            dtmNgayDKDocGia.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgayDK"].ToString());

            btnThemDocGia.Text = "Thêm";
            btnXoaDocGia.Text = "Xóa";
            btnSuaDocGia.Text = "Sửa";
            lblThongBaoDocGia.Text = "";
        }

        //ThemDocGia

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            btnXoaDocGia.Text = "Xóa";
            btnSuaDocGia.Text = "Sửa";

            btnHuyThaoTacDocGia.Enabled = true;
            btnSuaDocGia.Enabled = false;
            btnXoaDocGia.Enabled = false;

            if (btnThemDocGia.Text == "Thêm")
            {
                this.txtHoTenDocGia.Clear();
                this.txtDiaChiDocGia.Clear();
                this.txtCMNDDocGia.Clear();
                this.txtSDTDocGia.Clear();
                this.dtmNgaySinhDocGia.Value = DateTime.Today;
                this.dtmNgayDKDocGia.Value = DateTime.Today;

                this.txtHoTenDocGia.ReadOnly = false;
                this.txtDiaChiDocGia.ReadOnly = false;
                this.txtCMNDDocGia.ReadOnly = false;
                this.txtSDTDocGia.ReadOnly = false;
                this.dtmNgaySinhDocGia.Enabled = true;
                this.dtmNgayDKDocGia.Enabled = true;

                btnThemDocGia.Text = "Xác Nhận";
            }
            else if (btnThemDocGia.Text == "Xác Nhận")
            {

                if (txtHoTenDocGia.Text != "" && txtDiaChiDocGia.Text != "" && txtCMNDDocGia.Text != "" && txtSDTDocGia.Text != "" && dtmNgaySinhDocGia.Value != DateTime.Today)
                {
                    DataTable dt = busDG.getDocGia();

                    string prvMaDocGia = dt.Rows[dt.Rows.Count - 1]["MaDocGia"].ToString();

                    if (busDG.insertDocGia(prvMaDocGia, txtHoTenDocGia.Text, txtDiaChiDocGia.Text, txtSDTDocGia.Text, txtCMNDDocGia.Text, dtmNgaySinhDocGia.Value, dtmNgayDKDocGia.Value))
                    {
                        this.lblThongBaoDocGia.Text = "Thêm thành công";
                        dgvDocGia.DataSource = busDG.getDocGia();
                        btnThemDocGia.Text = "Okay";
                    }
                    else
                    {
                        this.lblThongBaoDocGia.Text = "Thêm không thành công !";
                        btnThemDocGia.Text = "Okay";
                    }

                    this.txtHoTenDocGia.ReadOnly = true;
                    this.txtDiaChiDocGia.ReadOnly = true;
                    this.txtCMNDDocGia.ReadOnly = true;
                    this.txtSDTDocGia.ReadOnly = true;
                    this.dtmNgaySinhDocGia.Enabled = false;
                    this.dtmNgayDKDocGia.Enabled = false;

                    btnHuyThaoTacDocGia.Enabled = false;
                    btnXoaDocGia.Enabled = true;
                    btnSuaDocGia.Enabled = true;
                }

                else
                {
                    lblThongBaoDocGia.Text = "Vui lòng nhập thông tin độc giả";
                }
            }
            else if (btnThemDocGia.Text == "Okay")
            {
                this.lblThongBaoDocGia.Text = "";
                btnThemDocGia.Text = "Thêm";
            }
        }

        //Sua thong tin doc gia        
        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {
            btnThemDocGia.Text = "Thêm";
            btnXoaDocGia.Text = "Xóa";

            if (btnSuaDocGia.Text == "Sửa")
            {
                if (dgvDocGia.SelectedRows.Count == 0)
                {
                    lblThongBaoDocGia.Text = "Vui lòng chọn độc giả";
                }
                else if (dgvDocGia.SelectedRows.Count > 0)
                {
                    this.txtHoTenDocGia.ReadOnly = false;
                    this.txtDiaChiDocGia.ReadOnly = false;
                    this.txtCMNDDocGia.ReadOnly = false;
                    this.txtSDTDocGia.ReadOnly = false;
                    this.dtmNgaySinhDocGia.Enabled = true;
                    this.dtmNgayDKDocGia.Enabled = true;

                    btnHuyThaoTacDocGia.Enabled = true;

                    btnThemDocGia.Enabled = false;
                    btnXoaDocGia.Enabled = false;

                    lblThongBaoDocGia.Text = "Bạn có chắn chắn sẽ sửa các độc giả\nnày chứ?";
                    btnSuaDocGia.Text = "Xác Nhận";
                }

            }
            else if (btnSuaDocGia.Text == "Xác Nhận")
            {
                if (dgvDocGia.SelectedRows.Count == 0)
                {
                    lblThongBaoDocGia.Text = "Vui lòng chọn độc giả";
                }
                else if (dgvDocGia.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvDocGia.CurrentRow;

                    string maDocGia = row.Cells[0].Value.ToString();

                    if (busDG.updateDocGia(maDocGia, txtHoTenDocGia.Text, txtDiaChiDocGia.Text, txtSDTDocGia.Text, txtCMNDDocGia.Text, dtmNgaySinhDocGia.Value, dtmNgayDKDocGia.Value))
                    {
                        this.lblThongBaoDocGia.Text = "Sửa thành công";
                        dgvDocGia.DataSource = busDG.getDocGia();
                        btnSuaDocGia.Text = "Sửa";
                    }
                    else
                    {
                        this.lblThongBaoDocGia.Text = "Sửa không thành công !";
                        btnSuaDocGia.Text = "Sửa";
                    }
                    this.txtHoTenDocGia.ReadOnly = true;
                    this.txtDiaChiDocGia.ReadOnly = true;
                    this.txtCMNDDocGia.ReadOnly = true;
                    this.txtSDTDocGia.ReadOnly = true;
                    this.dtmNgaySinhDocGia.Enabled = false;
                    this.dtmNgayDKDocGia.Enabled = false;

                    btnHuyThaoTacDocGia.Enabled = false;
                    btnXoaDocGia.Enabled = true;
                    btnThemDocGia.Enabled = true;
                }
            }


        }
        //Xoa doc gia       
        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            btnThemDocGia.Text = "Thêm";
            btnSuaDocGia.Text = "Sửa";



            if (btnXoaDocGia.Text == "Xóa")
            {
                if (dgvDocGia.SelectedRows.Count == 0)
                {
                    lblThongBaoDocGia.Text = "Vui lòng chọn độc giả";
                }
                else if (dgvDocGia.SelectedRows.Count > 0)
                {
                    lblThongBaoDocGia.Text = "Bạn có chắn chắn sẽ xóa các độc giả\nnày chứ?";
                    btnXoaDocGia.Text = "Xác Nhận";

                    btnSuaDocGia.Enabled = false;
                    btnThemDocGia.Enabled = false;

                    btnHuyThaoTacDocGia.Enabled = true;
                }
            }
            else if (btnXoaDocGia.Text == "Xác Nhận")
            {
                btnHuyThaoTacDocGia.Enabled = true;

                if (dgvDocGia.SelectedRows.Count == 0)
                {
                    lblThongBaoDocGia.Text = "Vui lòng chọn độc giả";
                }
                else if (dgvDocGia.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvDocGia.CurrentRow;

                    string maDocGia = row.Cells[0].Value.ToString();

                    if (busDG.deleteDocGia(maDocGia))
                    {
                        this.lblThongBaoDocGia.Text = "Xóa thành công";
                        dgvDocGia.DataSource = busDG.getDocGia();
                        btnXoaDocGia.Text = "Xóa";
                    }
                    else
                    {
                        this.lblThongBaoDocGia.Text = "Xóa không thành công !";
                        btnXoaDocGia.Text = "Xóa";
                    }
                    btnHuyThaoTacDocGia.Enabled = false;
                    btnSuaDocGia.Enabled = true;
                    btnThemDocGia.Enabled = true;
                }
            }
        }

        private void btnHuyThaoTacDocGia_Click(object sender, EventArgs e)
        {
            if (btnHuyThaoTacDocGia.Text == "Hủy")
            {
                if (btnThemDocGia.Text == "Xác Nhận")
                {
                    btnHuyThaoTacDocGia.Text = "Xác Nhận";
                    lblThongBaoDocGia.Text = "Xác nhận hủy thao tác thêm độc giả?";
                }
                else if (btnSuaDocGia.Text == "Xác Nhận")
                {
                    btnHuyThaoTacDocGia.Text = "Xác Nhận";
                    lblThongBaoDocGia.Text = "Xác nhận hủy thao tác sửa thông tin\nđộc giả?";
                }
                else if (btnXoaDocGia.Text == "Xác Nhận")
                {
                    btnHuyThaoTacDocGia.Text = "Xác Nhận";
                    lblThongBaoDocGia.Text = "Xác nhận hủy thao tác xóa độc giả?";
                }
            }
            else if (btnHuyThaoTacDocGia.Text == "Xác Nhận")
            {
                this.txtHoTenDocGia.ReadOnly = true;
                this.txtDiaChiDocGia.ReadOnly = true;
                this.txtCMNDDocGia.ReadOnly = true;
                this.txtSDTDocGia.ReadOnly = true;
                this.dtmNgaySinhDocGia.Enabled = false;
                this.dtmNgayDKDocGia.Enabled = false;

                btnHuyThaoTacDocGia.Enabled = false;

                if (btnThemDocGia.Text == "Xác Nhận")
                {
                    btnThemDocGia.Text = "Thêm";
                    btnSuaDocGia.Enabled = true;
                    btnXoaDocGia.Enabled = true;
                }
                else if (btnSuaDocGia.Text == "Xác Nhận")
                {
                    btnSuaDocGia.Text = "Sửa";
                    btnThemDocGia.Enabled = true;
                    btnXoaDocGia.Enabled = true;
                }
                else if (btnXoaDocGia.Text == "Xác Nhận")
                {
                    btnXoaDocGia.Text = "Xóa";
                    btnSuaDocGia.Enabled = true;
                    btnThemDocGia.Enabled = true;
                }
                btnHuyThaoTacDocGia.Text = "Hủy";
                lblThongBaoDocGia.Text = "";
            }
        }


        /*======================================================*/

        //
        //Tab Kho Sach
        //
        private void mainbtnKhoSach_Click(object sender, EventArgs e)
        {
            this.pnltabKhoSach.BringToFront();

            //foreach (Control ctr in pnlThongTinSach.Controls)
            //{
            //    ctr.Visible = true;
            //}

            pnlThongTinSach.AutoScroll = true;
            pnlThongTinSach.VerticalScroll.Visible = true;

            dgvSach.DataSource = busSach.getSach();
            dgvSach_RenameColumn();

            ResetControlSach();
        }


        // Reset trang thai cac Control
        private void ResetControlSach()
        {
            // Clear noi dung TextBox
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXB.Clear();
            txtNamXB.Clear();
            txtNhaPhatHanh.Clear();
            txtGiaTri.Clear();
            txtSoLuong.Clear();
            txtChuDe.Clear();
            txtTheLoai.Clear();
            dtmNgayNhap.Value = DateTime.Today;

            // Dat lai trang thai ReadOnly
            this.txtTenSach.ReadOnly = true;
            this.txtTacGia.ReadOnly = true;
            this.txtNamXB.ReadOnly = true;
            this.txtNXB.ReadOnly = true;
            this.txtNhaPhatHanh.ReadOnly = true;
            this.txtGiaTri.ReadOnly = true;
            this.txtSoLuong.ReadOnly = true;
            this.txtChuDe.ReadOnly = true;
            this.txtTheLoai.ReadOnly = true;
            this.dtmNgayNhap.Enabled = false;

            
            // Dat lai cac button Cap nhat
            Font fontButton = new Font("Sitka Display", 12, FontStyle.Bold);

            btnHuyCapNhatSach.Text = "Hủy";
            btnHuyCapNhatSach.Enabled = false;
            btnHuyCapNhatSach.Font = fontButton;

            btnThemSach.Text = "Thêm";
            btnThemSach.Enabled = true;
            btnThemSach.Font = fontButton;

            btnSuaSach.Text = "Sửa";
            btnSuaSach.Enabled = true;
            btnSuaSach.Font = fontButton;

            btnXoaSach.Text = "Xóa";
            btnXoaSach.Enabled = true;
            btnXoaSach.Font = fontButton;

            lblThongBaoSach.Text = "";
        }
<<<<<<< HEAD
        
        
=======

        private void SetConTrolInsertUpdateSach()
        {
            // Enable cac TextBox de nhap thong tin
            this.txtTenSach.ReadOnly = false;
            this.txtTacGia.ReadOnly = false;
            this.txtNamXB.ReadOnly = false;
            this.txtNXB.ReadOnly = false;
            this.txtNhaPhatHanh.ReadOnly = false;
            this.txtGiaTri.ReadOnly = false;
            this.txtSoLuong.ReadOnly = false;

            // Resize cac TextBox co san
            Size size = new Size(100, 28);

            txtTenSach.Size = size;
            txtTacGia.Size = size;
            txtNamXB.Size = size;
            txtNXB.Size = size;
            txtNhaPhatHanh.Size = size;
            txtGiaTri.Size = size;
            txtSoLuong.Size = size;

            // Rename cac TextBox nhap ID
            lblTacGia.Text = "Mã Tác Giả";
            lblNXB.Text = "Mã NXB";
            lblNhaPhatHanh.Text = "Mã Nhà Phát Hành";

            // Renew Font cac TextBox co san
            Font fontTextBox = new Font("Sitka Display", 10, FontStyle.Bold);

            txtTenSach.Font = fontTextBox;
            txtTacGia.Font = fontTextBox;
            txtNamXB.Font = fontTextBox;
            txtNXB.Font = fontTextBox;
            txtNhaPhatHanh.Font = fontTextBox;
            txtGiaTri.Font = fontTextBox;
            txtSoLuong.Font = fontTextBox;

            // Renew Font cac Label co san
            Font fontLabel = new Font("Sitka Heading", 10, FontStyle.Bold);

            lblTenSach.Font = fontLabel;
            lblTacGia.Font = fontLabel;
            lblNamXB.Font = fontLabel;
            lblNXB.Font = fontLabel;
            lblNhaPhatHanh.Font = fontLabel;
            lblGiaTri.Font = fontLabel;
            lblSoLuong.Font = fontLabel;

            // Relocated cac Lable va TextBox co san
            Point location = new Point(0, 18);
            lblTenSach.Location = location;

            location = new Point(121, 15);
            txtTenSach.Location = location;

            location = new Point(0, 55);
            lblTacGia.Location = location;

            location = new Point(121, 52);
            txtTacGia.Location = location;

            location = new Point(0, 92);
            lblNamXB.Location = location;

            location = new Point(121, 89);
            txtNamXB.Location = location;

            location = new Point(0, 130);
            lblNXB.Location = location;

            location = new Point(121, 127);
            txtNXB.Location = location;

            location = new Point(0, 167);
            lblNhaPhatHanh.Location = location;

            location = new Point(121, 164);
            txtNhaPhatHanh.Location = location;

            location = new Point(0, 202);
            lblGiaTri.Location = location;

            location = new Point(121, 199);
            txtGiaTri.Location = location;

            location = new Point(0, 237);
            lblSoLuong.Location = location;

            location = new Point(121, 234);
            txtSoLuong.Location = location;

            // Display cac TextBox moi de nhap day du thong tin             
            txtMaChuDe.Size = size;
            txtMaChuDe.Visible = true;

            txtMaTheLoai.Size = size;
            txtMaTheLoai.Visible = true;

            dtmNgayNhap.Size = size;
            dtmNgayNhap.Visible = true;

            // Display cac Label moi cho cac TextBox                
            lblMaChuDe.Visible = true;
            lblMaTheLoai.Visible = true;
            lblNgayNhap.Visible = true;

            // Clear cac TextBox de nhap thong tin
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXB.Clear();
            txtNXB.Clear();
            txtNhaPhatHanh.Clear();
            txtGiaTri.Clear();
            txtSoLuong.Clear();
            txtMaChuDe.Clear();
            txtMaTheLoai.Clear();
            dtmNgayNhap.Value = DateTime.Today;
        }


>>>>>>> 6de0dae676d395e52d5e71084284e2d90f7d29c2

        //=============== Them Sach ===============//
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            btnHuyCapNhatSach.Enabled = true;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;

            if (btnThemSach.Text == "Thêm")
            {
                this.txtTenSach.ReadOnly = false;
                this.txtTacGia.ReadOnly = false;
                this.txtNamXB.ReadOnly = false;
                this.txtNXB.ReadOnly = false;
                this.txtNhaPhatHanh.ReadOnly = false;
                this.txtGiaTri.ReadOnly = false;
                this.txtSoLuong.ReadOnly = false;
                this.txtChuDe.ReadOnly = false;
                this.txtTheLoai.ReadOnly = false;
                this.dtmNgayNhap.Enabled = true;

                btnThemSach.Text = "Xác nhận thêm";
                btnThemSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
<<<<<<< HEAD
                
=======

                SetConTrolInsertUpdateSach();
>>>>>>> 6de0dae676d395e52d5e71084284e2d90f7d29c2
            }
            else if (btnThemSach.Text == "Xác nhận thêm")
            {
                // Them Sach
                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNamXB.Text != "" && txtNamXB.Text != "" && txtNhaPhatHanh.Text != "" && txtChuDe.Text != "" && txtTheLoai.Text != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    // Tao ID cho Sach                    
                    int ID = 0;
                    string maSach = "";

                    try
                    {

                        ID = dgvSach.Rows.Count + 1;

                        if (0 <= ID && ID < 10)
                        {
                            maSach = string.Format("MS00{0}", ID.ToString());
                        }
                        else if (10 <= ID && ID < 100)
                        {
                            maSach = string.Format("MS0{0}", ID.ToString());
                        }
                        else if (100 <= ID && ID < 1000)
                        {
                            maSach = string.Format("MS{0}", ID.ToString());
                        }

                    }
                    catch (Exception) when (ID >= 1000)
                    {
                        lblThongBaoSach.Text = "Số lượng sách vượt quá\nkhả năng lưu trữ";
                    }

                    if (busSach.insertSach(maSach, txtTenSach.Text, txtTacGia.Text, Convert.ToInt32(txtNamXB.Text), txtNamXB.Text, txtNhaPhatHanh.Text, dtmNgayNhap.Value, txtChuDe.Text, txtTheLoai.Text, Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
                    {
                        lblThongBaoSach.Text = "Thêm thành công !";
                        btnThemSach.Text = "Hoàn tất";
                        btnThemSach.Font = new Font("Sitka Display", 12, FontStyle.Bold);

                        btnHuyCapNhatSach.Enabled = false;
                    }
                    else
                    {
                        lblThongBaoSach.Text = "Thêm không thành công !";
                    }
                }
                else
                {
                    lblThongBaoSach.Text = "Vui lòng nhập đầy đủ \ncác thông tin !";
                }

            }
            else if (btnThemSach.Text == "Hoàn tất")
            {
                ResetControlSach();

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }


        //============ Sua Sach ==============//
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            btnHuyCapNhatSach.Enabled = true;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;

            if (btnSuaSach.Text == "Sửa")
            {
                if (dgvSach.SelectedRows.Count == 0 || dgvSach.SelectedRows.Count > 1)
                {
                    lblThongBaoSach.Text = "Vui lòng chọn\nmột trường dữ liệu";
                }
                else
                {
                    this.txtTenSach.ReadOnly = false;
                    this.txtTacGia.ReadOnly = false;
                    this.txtNamXB.ReadOnly = false;
                    this.txtNXB.ReadOnly = false;
                    this.txtNhaPhatHanh.ReadOnly = false;
                    this.txtGiaTri.ReadOnly = false;
                    this.txtSoLuong.ReadOnly = false;
                    this.txtChuDe.ReadOnly = false;
                    this.txtTheLoai.ReadOnly = false;
                    this.dtmNgayNhap.Enabled = true;

                    lblThongBaoSach.Text = "Bạn có chắc chắn muốn sửa?";
                    btnSuaSach.Text = "Xác nhận sửa";
                    btnSuaSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
                }
            }
            else if (btnSuaSach.Text == "Xác nhận sửa")
            {
                
                DataGridViewRow row = dgvSach.CurrentRow;

                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNamXB.Text != "" && txtNamXB.Text != "" && txtNhaPhatHanh.Text != "" && txtChuDe.Text != "" && txtTheLoai.Text != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    if (busSach.updateSach(row.Cells["MaSach"].Value.ToString(), txtTenSach.Text, txtTacGia.Text, Convert.ToInt32(txtNamXB.Text), txtNamXB.Text, txtNhaPhatHanh.Text, dtmNgayNhap.Value, txtChuDe.Text, txtTheLoai.Text, Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
                    {
                        lblThongBaoSach.Text = "Sửa thành công !";
                        btnSuaSach.Text = "Hoàn tất";
                        btnSuaSach.Font = new Font("Sitka Display", 12, FontStyle.Bold);

                        btnHuyCapNhatSach.Enabled = false;
                    }
                    else
                    {
                        lblThongBaoSach.Text = "Sửa không thành công !";
                    }
                }
                else
                {
                    lblThongBaoSach.Text = "Vui lòng nhập đầy đủ \ncác thông tin !";
                }
            }
            else if (btnSuaSach.Text == "Hoàn tất")
            {
                ResetControlSach();

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }


        //============== Xoa Sach ==============//
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnHuyCapNhatSach.Enabled = true;

            if (btnXoaSach.Text == "Xóa")
            {
                if (dgvSach.SelectedRows.Count == 0 || dgvSach.SelectedRows.Count > 1)
                {
                    lblThongBaoSach.Text = "Vui lòng chọn\nmột trường dữ liệu";
                }
                else
                {
                    lblThongBaoSach.Text = "Bạn có chắc chắn\nmuốn xóa vĩnh viễn\ntrường dữ liệu này?";
                    btnXoaSach.Text = "Xác nhận xóa";
                    btnXoaSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
                }
            }
            else if (btnXoaSach.Text == "Xác nhận xóa")
            {
                DataGridViewRow row = dgvSach.CurrentRow;

                if (busSach.deleteSach(row.Cells[0].Value.ToString()))
                {
                    lblThongBaoSach.Text = "Xóa thành công !";

                    btnXoaSach.Text = "Hoàn tất";
                    btnXoaSach.Font = new Font("Sitka Display", 12, FontStyle.Bold);
                    btnHuyCapNhatSach.Enabled = false;
                }
                else
                {
                    lblThongBaoSach.Text = "Xóa không thành công !";
                }
            }
            else if (btnXoaSach.Text == "Hoàn tất")
            {
                ResetControlSach();

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }

        //=========== Huy tac vu Sach ==========//
        private void btnHuyCapNhatSach_Click(object sender, EventArgs e)
        {
            if (btnHuyCapNhatSach.Text == "Hủy")
            {
                lblThongBaoSach.Text = "Bạn có chắc chắn\nmuốn hủy tác vụ này?";
                btnHuyCapNhatSach.Text = "Xác nhận hủy";
                btnXoaSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
            }
            else if (btnHuyCapNhatSach.Text == "Xác nhận hủy")
            {
                ResetControlSach();

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }
        //=========== Tim kiem Sach ============//

        // Doi trang thai tab button
        private void tabbtnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (pnlTimKiemSach.Visible == false)
            {
                btnHuyCapNhatSach.Enabled = true;

                pnlLocSach.Visible = false;
                pnlTimKiemSach.Visible = true;
                pnlTimKiemSach.BringToFront();

                txtTimKiemSach.Clear();
                cboTimKiemSach.Text = "Tìm kiếm theo";

                pnlHighLightBoLocSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
                pnlHighLightTimKiemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            }
            else
            {
                pnlTimKiemSach.Visible = false;
                pnlLocSach.Visible = false;
                pnlHighLightTimKiemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));

                pnlCapNhatSach.BringToFront();
            }
        }

        // Thuc hien thao tac Tim kiem
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string condition;

            if (cboTimKiemSach.SelectedItem.ToString() == "Mã sách")
            {
                condition = string.Format("A.MaSach like '%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Tên sách")
            {
                condition = string.Format("A.TenSach like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Tác giả")
            {
                condition = string.Format("A.HoTen like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Năm xuất bản")
            {
                condition = string.Format("cast(A.NamXB as varchar(10)) like '%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Nhà xuất bản")
            {
                condition = string.Format("A.TenNXB like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Nhà phát hành")
            {
                condition = string.Format("A.TenNhaPhatHanh like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Chủ đề")
            {
                condition = string.Format("A.TenChuDe like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Thể loại")
            {
                condition = string.Format("A.TenTheLoai like N'%{0}%'", txtTimKiemSach.Text.ToString());
                dgvSach.DataSource = busSach.getSach(condition);
            }

            dgvSach_RenameColumn();
        }


        //============= Loc Sach ============//
        private void tabbtnBoLocSach_Click(object sender, EventArgs e)
        {
            if (pnlLocSach.Visible == false)
            {
                btnHuyCapNhatSach.Enabled = true;

                pnlTimKiemSach.Visible = false;
                pnlLocSach.Visible = true;
                pnlLocSach.BringToFront();

                chkChuDe.Checked = false;
                chkNhaPhatHanh.Checked = false;
                chkNXB.Checked = false;
                chkTacGia.Checked = false;
                chkTheLoai.Checked = false;

                pnlHighLightTimKiemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
                pnlHighLightBoLocSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            }
            else
            {
                pnlLocSach.Visible = false;
                pnlTimKiemSach.Visible = false;
                pnlHighLightBoLocSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));

<<<<<<< HEAD
                pnlCapNhatSach.BringToFront();                
=======
                pnlThongTinSach.BringToFront();
>>>>>>> 6de0dae676d395e52d5e71084284e2d90f7d29c2
            }

        }

        private void btnLocSach_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            if (chkTacGia.Checked)
            {
                list.Add("A.HoTen");
            }
            if (chkNXB.Checked)
            {
                list.Add("A.TenNXB");
            }
            if (chkNhaPhatHanh.Checked)
            {
                list.Add("A.TenNhaPhatHanh");
            }
            if (chkChuDe.Checked)
            {
                list.Add("A.TenChuDe");
            }
            if (chkTheLoai.Checked)
            {
                list.Add("A.TenTheLoai");
            }

            dgvSach.DataSource = busSach.LocSach(list);
            dgvSach_RenameColumn();
        }


        // =============== DataGridView Sach ===========//
        private void dgvSach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetControlSach();

            try
            {
                if (dgvSach.SelectedRows.Count == 1)
                {
                    txtTenSach.Text = dgvSach.CurrentRow.Cells["TenSach"].Value.ToString();
                    txtTacGia.Text = dgvSach.CurrentRow.Cells["HoTen"].Value.ToString();
                    txtNamXB.Text = dgvSach.CurrentRow.Cells["NamXB"].Value.ToString();
                    txtNXB.Text = dgvSach.CurrentRow.Cells["TenNXB"].Value.ToString();
                    txtNhaPhatHanh.Text = dgvSach.CurrentRow.Cells["TenNhaPhatHanh"].Value.ToString();
                    txtChuDe.Text = dgvSach.CurrentRow.Cells["TenChuDe"].Value.ToString();
                    txtTheLoai.Text = dgvSach.CurrentRow.Cells["TenTheLoai"].Value.ToString();
                    txtGiaTri.Text = dgvSach.CurrentRow.Cells["GiaTri"].Value.ToString();
                    txtSoLuong.Text = dgvSach.CurrentRow.Cells["SoLuong"].Value.ToString();                    
                    dtmNgayNhap.Value = Convert.ToDateTime(dgvSach.CurrentRow.Cells["NgayNhap"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvSach_RenameColumn()
        {
            foreach (DataGridViewColumn col in dgvSach.Columns)
            {
                if (col == dgvSach.Columns["MaSach"])
                    dgvSach.Columns["MaSach"].HeaderText = "Mã sách";
                else if (col == dgvSach.Columns["TenSach"])
                    dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                else if (col == dgvSach.Columns["HoTen"])
                    dgvSach.Columns["HoTen"].HeaderText = "Tác giả";
                else if (col == dgvSach.Columns["NamXB"])
                    dgvSach.Columns["NamXB"].HeaderText = "Năm xuất bản";
                else if (col == dgvSach.Columns["TenNXB"])
                    dgvSach.Columns["TenNXB"].HeaderText = "Nhà xuất bản";
                else if (col == dgvSach.Columns["TenNhaPhatHanh"])
                    dgvSach.Columns["TenNhaPhatHanh"].HeaderText = "Nhà phát hành";
                else if (col == dgvSach.Columns["NgayNhap"])
                    dgvSach.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                else if (col == dgvSach.Columns["TenChuDe"])
                    dgvSach.Columns["TenChuDe"].HeaderText = "Chủ đề";
                else if (col == dgvSach.Columns["TenTheLoai"])
                    dgvSach.Columns["TenTheLoai"].HeaderText = "Thể loại";
                else if (col == dgvSach.Columns["GiaTri"])
                    dgvSach.Columns["GiaTri"].HeaderText = "Giá trị";
                else if (col == dgvSach.Columns["SoLuong"])
                    dgvSach.Columns["SoLuong"].HeaderText = "Số lượng";
            }
        }


<<<<<<< HEAD
        //============= Auto Complete TextBox ==================//
        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtTenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenSach.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceSach = new List<string>();
            sourceSach = busSach.autoCompleteTextBox("TenSach", "Sach");

            foreach (string tenSach in sourceSach)
            {
                auto.Add(tenSach);
            }

            txtTenSach.AutoCompleteCustomSource = auto;
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtTacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTacGia.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceTacGia = new List<string>();
            sourceTacGia = busSach.autoCompleteTextBox("HoTen", "TacGia");

            foreach (string tenTG in sourceTacGia)
            {
                auto.Add(tenTG);
            }

            txtTacGia.AutoCompleteCustomSource = auto;
        }
        
        private void txtNXB_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtNXB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNXB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceNXB = new List<string>();
            sourceNXB = busSach.autoCompleteTextBox("TenNXB", "NXB");

            foreach (string tenNXB in sourceNXB)
            {
                auto.Add(tenNXB);
            }

            txtNhaPhatHanh.AutoCompleteCustomSource = auto;
        }

        private void txtNhaPhatHanh_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtNhaPhatHanh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNhaPhatHanh.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceNPH = new List<string>();
            sourceNPH = busSach.autoCompleteTextBox("TenNhaPhatHanh", "NhaPhatHanh");

            foreach (string tenNPH in sourceNPH)
            {
                auto.Add(tenNPH);
            }

            txtNhaPhatHanh.AutoCompleteCustomSource = auto;
        }

        private void txtChuDe_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtChuDe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtChuDe.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceChuDe = new List<string>();
            sourceChuDe = busSach.autoCompleteTextBox("TenChuDe", "ChuDe");

            foreach (string tenCD in sourceChuDe)
            {
                auto.Add(tenCD);
            }

            txtChuDe.AutoCompleteCustomSource = auto;
        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            txtTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTheLoai.AutoCompleteSource = AutoCompleteSource.CustomSource;

            List<string> sourceTheLoai = new List<string>();
            sourceTheLoai = busSach.autoCompleteTextBox("TenTheLoai", "TheLoai");

            foreach (string tenTL in sourceTheLoai)
            {
                auto.Add(tenTL);
            }

            txtTheLoai.AutoCompleteCustomSource = auto;
        }
        


=======
        // ==========================================================================
        //
        // CHO MUON SACH
        //
        BUS_PhieuMuon busPhieuMuon = new BUS_PhieuMuon();
        private void mainbtnChoMuonSach_Click(object sender, EventArgs e)
        {
            this.pnltabChoMuonSach.BringToFront();
            this.dgvCMSDSPhieuMuon.DataSource = busPhieuMuon.getPhieuMuon();
        }

        private void loadDataForCBMaDocGia()
        {
            List<string> column = new List<string>();
            column.Add("MaDocGia");
            column.Add("HoTen");
            DataTable dt = new DataTable();
            dt = busDG.getDocGia(column);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCMSNhapMaDocGia.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
            }
        }

        private void cbCMSNhapMaDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tenDocGia = "";
                string condition = string.Format("MaDocGia = '{0}'", cbCMSNhapMaDocGia.Text.Substring(0, 5));
                List<string> listProp = new List<string>();
                listProp.Add("HoTen");
                DataTable dt = busDG.getDocGia(listProp, condition);
                if (dt.Rows.Count != 0)
                {
                    tenDocGia = (" " + dt.Rows[0]["HoTen"].ToString());
                    lblCMSTenDocGia.Text = "Độc giả: ";
                    lblCMSTenDocGia.Text += tenDocGia;
                }

            }
        }

        private void btnCMSLapPM_Click(object sender, EventArgs e)
        {
            if(this.btnCMSLapPM.Text == "Lập Phiếu Mượn")
            {
                if (this.cbCMSNhapMaDocGia.Text != "" && this.lblCMSTenDocGia.Text != "Độc giả")
                {
                    this.lblCMSThongBao.Text = "";
                    string tenDocGia = "";
                    string ngayMuon = "";
                    string tenThuThu = "";
                    string condition = string.Format("MaDocGia = '{0}'", cbCMSNhapMaDocGia.Text.Substring(0, 5));
                    List<string> listProp = new List<string>();
                    listProp.Add("HoTen");
                    DataTable dt = busDG.getDocGia(listProp, condition);
                    if (dt.Rows.Count != 0)
                    {
                        tenDocGia = (" " + dt.Rows[0]["HoTen"].ToString());
                        lblPMTenDocGia.Text = "Độc giả: ";
                        lblPMTenDocGia.Text += tenDocGia;

                        ngayMuon = "  " + DateTime.Today.ToString().Substring(0, 10);
                        lblPMNgayMuon.Text = "Ngày Mượn: ";
                        lblPMNgayMuon.Text += ngayMuon;

                        tenThuThu = " " + dtoThuThu.HoTen;
                        lblPMThuThu.Text = "Thủ Thư: ";
                        lblPMThuThu.Text += tenThuThu;
                    }
                    this.pnlPMLapPhieuMuon.BringToFront();

                    btnCMSLapPM.Text = "Xác Nhận";
                }
                else
                {
                    this.lblCMSThongBao.Text = "Chưa nhập mã độc giả";
                }
            }
            else if(this.btnCMSLapPM.Text == "Xác Nhận")
            {
                if(dgvPMSach.Rows.Count > 1)
                {
                    BUS_PhieuMuon busPhieuMuon = new BUS_PhieuMuon();

                    DataTable dt = busPhieuMuon.getPhieuMuon();
                    string prvMaPhieuMuon = "null";
                    if (dt.Rows.Count > 0)
                    {
                        prvMaPhieuMuon = dt.Rows[dt.Rows.Count - 1]["MaPhieuMuon"].ToString();
                    }
                    if(busPhieuMuon.insertPhieuMuon(prvMaPhieuMuon, dtoThuThu.MaThuThu, cbCMSNhapMaDocGia.Text.Substring(0, 5), DateTime.Today, dgvPMSach.Rows.Count - 1))
                    {
                        lblCMSThongBao.Text = "Thêm phiếu mượn thành công";
                    }
                    dt = busPhieuMuon.getPhieuMuon();
                    
                    for (int i = 0; i < dgvPMSach.Rows.Count - 1; i++)
                    {
                        BUS_CTPM busCTPM = new BUS_CTPM();
                        string maSach = dgvPMSach.Rows[i].Cells["colMaSach"].Value.ToString();
                        string maPM = dt.Rows[dt.Rows.Count - 1]["MaPhieuMuon"].ToString();
                        string condition = string.Format("MaSach = '{0}'", maSach);
                        busCTPM.insertCTPM(maPM, maSach);
                        DataTable dt1 = busSach.getSach(condition);
                        int soLuong = int.Parse(dt1.Rows[0]["SoLuong"].ToString()) - 1;

                        busSach.updateSoluongSach(dt1.Rows[0]["MaSach"].ToString(), soLuong);
                    }
                    this.btnCMSLapPM.Text = "Lập Phiếu Mượn";
                }
                else
                {
                    this.lblCMSThongBao.Text = "Chưa chọn sách";
                }
            }
            
        }

        //Xu Ly phieu muon

        private void loadDataForCBMaSach()
        {
            List<string> column = new List<string>();
            column.Add("MaSach");
            column.Add("TenSach");
            DataTable dt = new DataTable();
            dt = busSach.getSach(column);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbPMNhapMaSach.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
            }
        }
      
        
        private void cbPMNhapMaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dgvPMSach.Rows.Count <= 3)
                {
                    string condition = string.Format("MaSach = '{0}'", cbPMNhapMaSach.Text.Substring(0, 5));
                    List<string> listProp = new List<string>();
                    listProp.Add("MaSach");
                    listProp.Add("TenSach");

                    string tenSach = busSach.getSach(listProp, condition).Rows[0]["TenSach"].ToString();
                    string maSach = busSach.getSach(listProp, condition).Rows[0]["MaSach"].ToString();

                    this.dgvPMSach.Rows.Add(maSach, tenSach);
                }
                else
                {

                }
                
            }
        }

        private void dgvPMSach_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                foreach(DataGridViewRow row in dgvPMSach.SelectedRows)
                {
                    dgvPMSach.Rows.Remove(row);
                }
                
            }
        }

        private void btnPMEsc_Click(object sender, EventArgs e)
        {
            this.pnlCMSDSPM.BringToFront();
            this.btnCMSLapPM.Text = "Lập Phiếu Mượn";
        }

        
>>>>>>> 6de0dae676d395e52d5e71084284e2d90f7d29c2
    }


}

