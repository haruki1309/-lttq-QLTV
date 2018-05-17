using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace GraphicUserInterface
{
    public partial class frmDocGia : Form
    {
        BUS_DocGia busDG = new BUS_DocGia();
        BUS_Sach busSach = new BUS_Sach();


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
            txtNXB.Clear();
            txtNhaPhatHanh.Clear();
            txtGiaTri.Clear();
            txtSoLuong.Clear();
            txtMaChuDe.Clear();
            txtMaTheLoai.Clear();
            dtmNgayNhap.Value = DateTime.Today;

            // Dat lai trang thai ReadOnly va Visible
            this.txtTenSach.ReadOnly = true;
            this.txtTacGia.ReadOnly = true;
            this.txtNamXB.ReadOnly = true;
            this.txtNXB.ReadOnly = true;
            this.txtNhaPhatHanh.ReadOnly = true;
            this.txtGiaTri.ReadOnly = true;
            this.txtSoLuong.ReadOnly = true;

            lblMaChuDe.Visible = false;
            lblMaTheLoai.Visible = false;
            lblNgayNhap.Visible = false;

            txtMaChuDe.Visible = false;
            dtmNgayNhap.Visible = false;
            txtMaTheLoai.Visible = false;

            // Dat lai size cho cac TextBox
            Size size = new Size(231, 28);

            txtTenSach.Size = size;
            txtTacGia.Size = size;
            txtNamXB.Size = size;
            txtNXB.Size = size;
            txtNhaPhatHanh.Size = size;
            txtGiaTri.Size = size;
            txtSoLuong.Size = size;

            // Dat lai Text cho cac Label
            lblTacGia.Text = "Tác Giả";
            lblNXB.Text = "Nhà Xuất Bản";
            lblNhaPhatHanh.Text = "Nhà Phát Hành";

            // Dat lai Font cho TextBox
            Font fontTextBox = new Font("Sitka Display", 12, FontStyle.Bold);

            txtTenSach.Font = fontTextBox;
            txtTacGia.Font = fontTextBox;
            txtNamXB.Font = fontTextBox;
            txtNXB.Font = fontTextBox;
            txtNhaPhatHanh.Font = fontTextBox;
            txtGiaTri.Font = fontTextBox;
            txtSoLuong.Font = fontTextBox;

            // Dat lai Font cho Lable
            Font fontLabel = new Font("Sitka Heading", 12, FontStyle.Bold);

            lblTenSach.Font = fontLabel;
            lblTacGia.Font = fontLabel;
            lblNamXB.Font = fontLabel;
            lblNXB.Font = fontLabel;
            lblNhaPhatHanh.Font = fontLabel;
            lblGiaTri.Font = fontLabel;
            lblSoLuong.Font = fontLabel;

            // Dat lai vi tri cac Lable va TextBox
            Point location = new Point(86, 18);
            lblTenSach.Location = location;

            location = new Point(165, 15);
            txtTenSach.Location = location;

            location = new Point(92, 55);
            lblTacGia.Location = location;

            location = new Point(165, 52);
            txtTacGia.Location = location;

            location = new Point(48, 92);
            lblNamXB.Location = location;

            location = new Point(165, 89);
            txtNamXB.Location = location;

            location = new Point(53, 130);
            lblNXB.Location = location;

            location = new Point(165, 127);
            txtNXB.Location = location;

            location = new Point(43, 167);
            lblNhaPhatHanh.Location = location;

            location = new Point(165, 164);
            txtNhaPhatHanh.Location = location;

            location = new Point(99, 202);
            lblGiaTri.Location = location;

            location = new Point(165, 199);
            txtGiaTri.Location = location;

            location = new Point(81, 237);
            lblSoLuong.Location = location;

            location = new Point(165, 234);
            txtSoLuong.Location = location;

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

        

        //=============== Them Sach ===============//
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            btnHuyCapNhatSach.Enabled = true;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;

            if (btnThemSach.Text == "Thêm")
            {
                btnThemSach.Text = "Xác nhận thêm";
                btnThemSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
                
                SetConTrolInsertUpdateSach();
            }
            else if (btnThemSach.Text == "Xác nhận thêm")
            {             
                // Them Sach
                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNamXB.Text != "" && txtNXB.Text != "" && txtNhaPhatHanh.Text != "" && txtMaChuDe.Text != "" && txtMaTheLoai.Text != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    // Tao ID cho Sach                    
                    int ID = 0;                   
                    string maSach = "";

                    try
                    {

                        ID = dgvSach.Rows.Count - 1;

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

                    if (busSach.insertSach(maSach, txtTenSach.Text, txtTacGia.Text, Convert.ToInt32(txtNamXB.Text), txtNXB.Text, txtNhaPhatHanh.Text, dtmNgayNhap.Value, txtMaChuDe.Text, txtMaTheLoai.Text, Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
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
                    SetConTrolInsertUpdateSach();

                    lblThongBaoSach.Text = "Bạn có chắc chắn muốn sửa?";
                    btnSuaSach.Text = "Xác nhận sửa";
                    btnSuaSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
                }
            }
            else if (btnSuaSach.Text == "Xác nhận sửa")
            {
                DataGridViewRow row = dgvSach.CurrentRow;

                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNamXB.Text != "" && txtNXB.Text != "" && txtNhaPhatHanh.Text != "" && txtMaChuDe.Text != "" && txtMaTheLoai.Text != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    if (busSach.updateSach(row.Cells[0].Value.ToString(), txtTenSach.Text, txtTacGia.Text, Convert.ToInt32(txtNamXB.Text), txtNXB.Text, txtNhaPhatHanh.Text, dtmNgayNhap.Value, txtMaChuDe.Text, txtMaTheLoai.Text, Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
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

            if(btnXoaSach.Text == "Xóa")
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

                if(busSach.deleteSach(row.Cells[0].Value.ToString()))
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
            if(btnHuyCapNhatSach.Text == "Hủy")
            {
                lblThongBaoSach.Text = "Bạn có chắc chắn\nmuốn hủy tác vụ này?";
                btnHuyCapNhatSach.Text = "Xác nhận hủy";
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

                pnlThongTinSach.BringToFront();
            }
        }

        // Thuc hien thao tac Tim kiem
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string condition;

            if (cboTimKiemSach.SelectedItem.ToString() == "Mã sách")
            {
                condition = string.Format("A.MaSach = '{0}'", txtTimKiemSach.Text.ToString());
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
                condition = string.Format("cast(A.NamXB as varchar(10)) = '{0}'", txtTimKiemSach.Text.ToString());
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

                pnlThongTinSach.BringToFront();                
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
            if(chkTheLoai.Checked)
            {
                list.Add("A.TenTheLoai");
            }

            dgvSach.DataSource = busSach.getSach(list);
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
                    txtGiaTri.Text = dgvSach.CurrentRow.Cells["GiaTri"].Value.ToString();
                    txtSoLuong.Text = dgvSach.CurrentRow.Cells["SoLuong"].Value.ToString();
                }
            }
            catch (Exception)
            {

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
    }
}

    

