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
using System.Data.SqlClient;
using DataTransferObject;


namespace GraphicUserInterface
{
    public partial class frmMain : Form
    {
        private Color grayBackColor = System.Drawing.Color.FromArgb(((int)((byte)54)), ((int)((byte)54)), ((int)((byte)50)));
        private Color orangeBackColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)104)), ((int)((byte)57)));


        BUS_DocGia busDG = new BUS_DocGia();
        BUS_Sach busSach = new BUS_Sach();
        //LOADING ...................
        private void tmrFrmMainLoad_Tick(object sender, EventArgs e)
        {
            this.Opacity *= 3;
            if (this.Opacity == .100)
            {
                tmrFrmMainLoad.Stop();
            }
        }
        private void LoadMainForm()
        {
            this.tmrFrmMainLoad.Start();
            pnlRunning.Visible = false;
        }


        //
        // Panel cac Button Control
        //
        //private List<Button> tabButton = new List<Button>();
        //private void TaoListTabButton()
        //{
        //    foreach (Button btn in pnlTabButton.Controls)
        //        tabButton.Add(btn);
        //}

        private void ChonMainButton(Button button)
        {
            foreach (Control btn in pnlMainButton.Controls)
            {
                if (btn == button)
                {
                    btn.BackColor = Color.DimGray;
                    pnlRunning.Visible = true;
                    pnlRunning.BackColor = orangeBackColor;
                    pnlRunning.Location = new Point(2, button.Location.Y);
                }
                else
                {
                    btn.BackColor = grayBackColor;
                }
            }
        }



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

        public frmMain()
        {
            InitializeComponent();

        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            this.dgvDocGia.DataSource = busDG.getDocGia();
            this.pnltabDocGia.BringToFront();
                     
            //Khoi tao du lieu cho Thu Thu da dang nhap
            this.loadDataForThuThu();



        }

        //
        //TAB DOC GIA
        //
        //Rename table DocGia
        void DGVDocGia_RenameColumn()
        {
            foreach (DataGridViewColumn col in dgvDocGia.Columns)
            {
                if (col == dgvDocGia.Columns["MaDocGia"])
                {
                    dgvDocGia.Columns["MaDocGia"].HeaderText = "Mã độc giả";
                }                   
                else if (col == dgvDocGia.Columns["HoTen"])
                {
                    dgvDocGia.Columns["HoTen"].HeaderText = "Họ tên";
                }                  
                else if (col == dgvDocGia.Columns["DiaChi"])
                {
                    dgvDocGia.Columns["DiaChi"].HeaderText = "Địa chỉ";
                }                   
                else if (col == dgvDocGia.Columns["SoDT"])
                {
                    dgvDocGia.Columns["SoDT"].HeaderText = "Số điện thoại";
                }                    
                else if (col == dgvDocGia.Columns["CMND"])
                {
                    dgvDocGia.Columns["CMND"].HeaderText = "Chứng minh thư";
                }
                else if (col == dgvDocGia.Columns["NgaySinh"])
                {
                    dgvDocGia.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                }
                else if (col == dgvDocGia.Columns["NgayDK"])
                {
                    dgvDocGia.Columns["NgayDK"].HeaderText = "Ngày đăng ký";
                }
            }
        }
        void SetupTabDocGia()
        {
            //Setup ten cho dgv
            DGVDocGia_RenameColumn();
            //Setup source cho dgv
            dgvDocGia.DataSource = busDG.getDocGia();
            //Xoa hang duoc chon
            dgvDocGia.ClearSelection();
            //disable thong tin
            this.txtHoTenDocGia.ReadOnly = true;
            this.txtDiaChiDocGia.ReadOnly = true;
            this.txtCMNDDocGia.ReadOnly = true;
            this.txtSDTDocGia.ReadOnly = true;
            this.dtmNgaySinhDocGia.Enabled = false;
            this.dtmNgayDKDocGia.Enabled = false;
        }

        private void mainbtnDocGia_Click(object sender, EventArgs e)
        {
            this.pnltabDocGia.BringToFront();
            SetupTabDocGia();
            ChonMainButton(mainbtnDocGia);
        }

        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            this.pnlThongTinDocGia.BringToFront();
            this.pnlHightLightTimKiem.BackColor = grayBackColor;
            this.pnlHightLightBoLoc.BackColor = grayBackColor;
        }

          

        private void tabbtnTimKiem_Click(object sender, EventArgs e)
        {
            if (pnlSearchFor.Visible == false)
            {
                pnlBoLoc.Visible = false;
                pnlSearchFor.Visible = true;
                pnlSearchFor.BringToFront();

                txtDGTimKiem.Clear();
                cboSearchFor.Text = "Tìm kiếm theo";

                pnlHightLightBoLoc.BackColor = grayBackColor;
                pnlHightLightTimKiem.BackColor = orangeBackColor;
            }
            else
            {
                pnlSearchFor.Visible = false;
                pnlBoLoc.Visible = false;
                pnlHightLightTimKiem.BackColor = grayBackColor;

                pnlThongTinDocGia.BringToFront();
            }
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {

        }

        //Chuc nang loc doc gia

        private void tabbtnBoLoc_Click(object sender, EventArgs e)
        {
            if (pnlBoLoc.Visible == false)
            {
               
                pnlSearchFor.Visible = false;
                pnlBoLoc.Visible = true;
                pnlBoLoc.BringToFront();

                pnlHightLightTimKiem.BackColor = grayBackColor;
                pnlHightLightBoLoc.BackColor = orangeBackColor;
            }
            else
            {
                pnlBoLoc.Visible = false;
                pnlSearchFor.Visible = false;
                pnlHightLightBoLoc.BackColor = grayBackColor;

                pnlThongTinDocGia.BringToFront();
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

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtHoTenDocGia.ReadOnly = true;
            this.txtDiaChiDocGia.ReadOnly = true;
            this.txtCMNDDocGia.ReadOnly = true;
            this.txtSDTDocGia.ReadOnly = true;
            this.dtmNgaySinhDocGia.Enabled = false;
            this.dtmNgayDKDocGia.Enabled = false;

            if(e.RowIndex > -1)
            {
                DataTable dt = busDG.getDocGia();
                txtHoTenDocGia.Text = dt.Rows[e.RowIndex]["HoTen"].ToString();
                txtDiaChiDocGia.Text = dt.Rows[e.RowIndex]["DiaChi"].ToString();
                txtCMNDDocGia.Text = dt.Rows[e.RowIndex]["CMND"].ToString();
                txtSDTDocGia.Text = dt.Rows[e.RowIndex]["SDT"].ToString();
                dtmNgaySinhDocGia.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgaySinh"].ToString());
                dtmNgayDKDocGia.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgayDK"].ToString());
            }
            else if(e.RowIndex == -1)
            {
                dgvDocGia.ClearSelection();
            }

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

            ChonMainButton(mainbtnKhoSach);

            ResetControlSach();
        }


        //=============== Them Sach ===============//
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            btnHuyCapNhatSach.Visible = true;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;

            if (btnThemSach.Text == "Thêm")
            {
                this.cboTenSach.Enabled = true;
                this.cboTacGia.Enabled = true;
                this.cboNamXB.Enabled = true;
                this.cboNXB.Enabled = true;
                this.cboNhaPhatHanh.Enabled = true;
                this.cboChuDe.Enabled = true;
                this.cboTheLoai.Enabled = true;
                this.txtGiaTri.ReadOnly = false;
                this.txtSoLuong.ReadOnly = false;
                this.dtmNgayNhap.Enabled = true;

                cboTenSach.ResetText();
                cboTacGia.ResetText();
                cboNamXB.ResetText();
                cboNXB.ResetText();
                cboNhaPhatHanh.ResetText();
                txtGiaTri.ResetText();
                txtSoLuong.ResetText();
                cboChuDe.ResetText();
                cboTheLoai.ResetText();
                dtmNgayNhap.Value = DateTime.Today;

                lblThongBaoSach.Location = new Point(2, 2);
                lblThongBaoSach.Text = "Vui lòng kiểm tra lại các thông tin.\nNếu bạn muốn thêm vào dữ liệu\nhoàn toàn mới, click vào nút thêm\nbên cạnh mỗi trường dữ liệu (nếu có)";
                btnThemSach.Text = "Xác nhận thêm";
                btnThemSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);

            }
            else if (btnThemSach.Text == "Xác nhận thêm")
            {
                // Them Sach
                if (cboTenSach.Text.ToString() != "" && cboTacGia.Text.ToString() != "" && cboNamXB.Text.ToString() != "" && cboNXB.Text.ToString() != "" && cboNhaPhatHanh.Text.ToString() != "" && cboChuDe.Text.ToString() != "" && cboTheLoai.Text.ToString() != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    string maSach = "";

                    if (busSach.insertSach(maSach, cboTenSach.Text.ToString(), cboTacGia.Text.ToString(), Convert.ToInt32(cboNamXB.Text.ToString()), cboNXB.Text.ToString(), cboNhaPhatHanh.Text.ToString(), dtmNgayNhap.Value, cboChuDe.Text.ToString(), cboTheLoai.Text.ToString(), Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
                    {
                        ResetControlSach();
                        lblThongBaoSach.Text = "Thêm thành công !";
                    }
                    else
                    {
                        ResetControlSach();
                        lblThongBaoSach.Text = "Thêm không thành công !";
                    }
                }
                else
                {
                    lblThongBaoSach.Text = "Vui lòng nhập đầy đủ \ncác thông tin !";
                }

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }


        //============ Sua Sach ==============//
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            btnHuyCapNhatSach.Visible = true;
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
                    this.cboTenSach.Enabled = true;
                    this.cboTacGia.Enabled = true;
                    this.cboNamXB.Enabled = true;
                    this.cboNXB.Enabled = true;
                    this.cboNhaPhatHanh.Enabled = true;
                    this.cboChuDe.Enabled = true;
                    this.cboTheLoai.Enabled = true;
                    this.txtGiaTri.ReadOnly = false;
                    this.txtSoLuong.ReadOnly = false;
                    this.dtmNgayNhap.Enabled = true;

                    lblThongBaoSach.Location = new Point(2, 2);
                    lblThongBaoSach.Text = "Vui lòng kiểm tra lại các thông tin.\nNếu bạn muốn thêm vào dữ liệu\nhoàn toàn mới, click vào nút thêm\nbên cạnh mỗi trường dữ liệu (nếu có)";

                    btnSuaSach.Text = "Xác nhận sửa";
                    btnSuaSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
                }
            }
            else if (btnSuaSach.Text == "Xác nhận sửa")
            {

                DataGridViewRow row = dgvSach.CurrentRow;

                if (cboTenSach.Text.ToString() != "" && cboTacGia.Text.ToString() != "" && cboNamXB.Text.ToString() != "" && cboNXB.Text.ToString() != "" && cboNhaPhatHanh.Text.ToString() != "" && cboChuDe.Text.ToString() != "" && cboTheLoai.Text.ToString() != "" && txtGiaTri.Text != "" && txtSoLuong.Text != "")
                {
                    if (busSach.updateSach(row.Cells["MaSach"].Value.ToString(), cboTenSach.Text.ToString(), cboTacGia.Text.ToString(), Convert.ToInt32(cboNamXB.Text.ToString()), cboNXB.Text.ToString(), cboNhaPhatHanh.Text.ToString(), dtmNgayNhap.Value, cboChuDe.Text.ToString(), cboTheLoai.Text.ToString(), Convert.ToDouble(txtGiaTri.Text), Convert.ToInt32(txtSoLuong.Text)))
                    {
                        ResetControlSach();
                        lblThongBaoSach.Text = "Sửa thành công !";
                    }
                    else
                    {
                        ResetControlSach();
                        lblThongBaoSach.Text = "Sửa không thành công !";
                    }
                }
                else
                {
                    lblThongBaoSach.Text = "Vui lòng nhập đầy đủ \ncác thông tin !";
                }

                dgvSach.DataSource = busSach.getSach();
                dgvSach_RenameColumn();
            }
        }


        //============== Xoa Sach ==============//
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            btnThemSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnHuyCapNhatSach.Visible = true;

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
                    ResetControlSach();
                    lblThongBaoSach.Text = "Xóa thành công !";
                }
                else
                {
                    ResetControlSach();
                    lblThongBaoSach.Text = "Xóa không thành công !";
                }

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
                btnHuyCapNhatSach.Font = new Font("Sitka Display", 10, FontStyle.Bold);
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
                btnHuyCapNhatSach.Visible = true;

                pnlLocSach.Visible = false;
                pnlTimKiemSach.Visible = true;
                pnlTimKiemSach.BringToFront();

                txtTimKiemSach.Clear();
                cboTimKiemSach.Text = "Tìm kiếm theo";

                pnlHighLightBoLocSach.BackColor = grayBackColor;
                pnlHighLightTimKiemSach.BackColor = orangeBackColor;
            }
            else
            {
                pnlTimKiemSach.Visible = false;
                pnlLocSach.Visible = false;
                pnlHighLightTimKiemSach.BackColor = grayBackColor;

                pnlCapNhatSach.BringToFront();
            }
        }

        // Thuc hien thao tac Tim kiem
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string condition;

            if (cboTimKiemSach.Text == "Tìm kiếm theo")
            {
                pnlTimKiemSach.Visible = false;
                lblThongBaoSach.Text = "Không thể tìm kiếm.\nVui lòng chọn\nmột điều kiện tìm kiếm.";
            }
            else if (cboTimKiemSach.SelectedItem.ToString() == "Mã sách")
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
                condition = string.Format("A.TenTacGia like N'%{0}%'", txtTimKiemSach.Text.ToString());
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
                btnHuyCapNhatSach.Visible = true;

                pnlTimKiemSach.Visible = false;
                pnlLocSach.Visible = true;
                pnlLocSach.BringToFront();

                chkChuDe.Checked = false;
                chkNhaPhatHanh.Checked = false;
                chkNXB.Checked = false;
                chkTacGia.Checked = false;
                chkTheLoai.Checked = false;

                pnlHighLightTimKiemSach.BackColor = grayBackColor;
                pnlHighLightBoLocSach.BackColor = orangeBackColor;
            }
            else
            {
                pnlLocSach.Visible = false;
                pnlTimKiemSach.Visible = false;
                pnlHighLightBoLocSach.BackColor = grayBackColor;

                pnlThongTinSach.BringToFront();
            }

        }

        private void btnLocSach_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            if (chkTacGia.Checked)
            {
                list.Add("A.TenTacGia");
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


        private void dgvSach_RenameColumn()
        {
            foreach (DataGridViewColumn col in dgvSach.Columns)
            {
                if (col == dgvSach.Columns["MaSach"])
                    dgvSach.Columns["MaSach"].HeaderText = "Mã sách";
                else if (col == dgvSach.Columns["TenSach"])
                    dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                else if (col == dgvSach.Columns["TenTacGia"])
                    dgvSach.Columns["TenTacGia"].HeaderText = "Tác giả";
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

        private void dgvSach_Click(object sender, EventArgs e)
        {
            pnlLocSach.Visible = false;
            pnlTimKiemSach.Visible = false;
            pnlHighLightBoLocSach.BackColor = grayBackColor;
            pnlHighLightTimKiemSach.BackColor = grayBackColor;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetControlSach();

            try
            {
                if(e.RowIndex > -1)
                {
                    cboTenSach.Text = dgvSach.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                    cboTacGia.Text = dgvSach.Rows[e.RowIndex].Cells["TenTacGia"].Value.ToString();
                    cboNamXB.Text = dgvSach.Rows[e.RowIndex].Cells["NamXB"].Value.ToString();
                    cboNXB.Text = dgvSach.Rows[e.RowIndex].Cells["TenNXB"].Value.ToString();
                    cboNhaPhatHanh.Text = dgvSach.Rows[e.RowIndex].Cells["TenNhaPhatHanh"].Value.ToString();
                    cboChuDe.Text = dgvSach.Rows[e.RowIndex].Cells["TenChuDe"].Value.ToString();
                    cboTheLoai.Text = dgvSach.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString();
                    txtGiaTri.Text = dgvSach.Rows[e.RowIndex].Cells["GiaTri"].Value.ToString();
                    txtSoLuong.Text = dgvSach.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                    dtmNgayNhap.Value = Convert.ToDateTime(dgvSach.Rows[e.RowIndex].Cells["NgayNhap"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //============ ComboBox =============//
        private void GetDataComboBox(ComboBox name, string columnName, string tableName)
        {
            List<string> comboBoxSource = new List<string>();
            comboBoxSource = busSach.getDataComboBox(columnName, tableName);

            foreach (string source in comboBoxSource)
            {
                name.Items.Add(source);
            }
        }

        // ========= Them Du lieu chua co ==========//

        // Them Tac gia
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if (busSach.insertTable(cboTacGia.Text, "@TenTacGia", "ThemTacGia"))
            {
                cboTacGia.Items.Clear();
                GetDataComboBox(cboTacGia, "TenTacGia", "TacGia");
            }
        }

        private void cboTacGia_Leave(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string tenTG in cboTacGia.Items)
            {
                if (tenTG == cboTacGia.Text)
                    count++;
            }

            if (count == 0)
                btnThemTacGia.Visible = true;
            else
                btnThemTacGia.Visible = false;
        }

        private void cboTacGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = 0;

                foreach (string tenTG in cboTacGia.Items)
                {
                    if (tenTG == cboTacGia.Text)
                        count++;
                }

                if (count == 0)
                    btnThemTacGia.Visible = true;
                else
                    btnThemTacGia.Visible = false;
            }
        }
        // Them NXB
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            if (busSach.insertTable(cboNXB.Text, "@TenNXB", "ThemNXB"))
            {
                cboNXB.Items.Clear();
                GetDataComboBox(cboNXB, "TenNXB", "NXB");
            }
        }

        private void cboNXB_Leave(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string tenNXB in cboNXB.Items)
            {
                if (tenNXB == cboNXB.Text)
                    count++;
            }

            if (count == 0)
                btnThemNXB.Visible = true;
            else
                btnThemNXB.Visible = false;
        }

        private void cboNXB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = 0;

                foreach (string tenNXB in cboNXB.Items)
                {
                    if (tenNXB == cboNXB.Text)
                        count++;
                }

                if (count == 0)
                    btnThemNXB.Visible = true;
                else
                    btnThemNXB.Visible = false;
            }
        }

        // Them Nha phat hanh
        private void btnThemNhaPhatHanh_Click(object sender, EventArgs e)
        {
            if (busSach.insertTable(cboNhaPhatHanh.Text, "@TenNPH", "ThemNhaPhatHanh"))
            {
                cboTenSach.Items.Clear();
                GetDataComboBox(cboNhaPhatHanh, "TenNhaPhatHanh", "NhaPhatHanh");
            }
        }

        private void cboNhaPhatHanh_Leave(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string tenNPH in cboNhaPhatHanh.Items)
            {
                if (tenNPH == cboNhaPhatHanh.Text)
                    count++;
            }

            if (count == 0)
                btnThemNhaPhatHanh.Visible = true;
            else
                btnThemNhaPhatHanh.Visible = false;
        }

        private void cboNhaPhatHanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = 0;

                foreach (string tenNPH in cboNhaPhatHanh.Items)
                {
                    if (tenNPH == cboNhaPhatHanh.Text)
                        count++;
                }

                if (count == 0)
                    btnThemNhaPhatHanh.Visible = true;
                else
                    btnThemNhaPhatHanh.Visible = false;
            }
        }

        // Them Chu de
        private void btnThemChuDe_Click(object sender, EventArgs e)
        {
            if (busSach.insertTable(cboChuDe.Text, "@TenCD", "ThemChuDe"))
            {
                cboChuDe.Items.Clear();
                GetDataComboBox(cboChuDe, "TenChuDe", "ChuDe");
            }
        }

        private void cboChuDe_Leave(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string tenCD in cboChuDe.Items)
            {
                if (tenCD == cboChuDe.Text)
                    count++;
            }

            if (count == 0)
                btnThemChuDe.Visible = true;
            else
                btnThemChuDe.Visible = false;
        }

        private void cboChuDe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = 0;

                foreach (string tenCD in cboChuDe.Items)
                {
                    if (tenCD == cboChuDe.Text)
                        count++;
                }

                if (count == 0)
                    btnThemChuDe.Visible = true;
                else
                    btnThemChuDe.Visible = false;
            }
        }

        // Them The loai
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (busSach.insertTable(cboTheLoai.Text, "@TenTL", "ThemTheLoai"))
            {
                cboTheLoai.Items.Clear();
                GetDataComboBox(cboTheLoai, "TenTheLoai", "TheLoai");
            }
        }

        private void cboTheLoai_Leave(object sender, EventArgs e)
        {
            int count = 0;

            foreach (string tenTL in cboTheLoai.Items)
            {
                if (tenTL == cboTheLoai.Text)
                    count++;
            }

            if (count == 0)
                btnThemTheLoai.Visible = true;
            else
                btnThemTheLoai.Visible = false;
        }

        private void cboTheLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = 0;

                foreach (string tenTL in cboTheLoai.Items)
                {
                    if (tenTL == cboTheLoai.Text)
                        count++;
                }

                if (count == 0)
                    btnThemTheLoai.Visible = true;
                else
                    btnThemTheLoai.Visible = false;
            }
        }

        // =================== Xu ly event ngoai ================//

        // Tat tab Tim kiem va Loc
        private void pnltabKhoSach_Click(object sender, EventArgs e)
        {
            pnlLocSach.Visible = false;
            pnlTimKiemSach.Visible = false;
            pnlHighLightBoLocSach.BackColor = grayBackColor;
            pnlHighLightTimKiemSach.BackColor = grayBackColor;
        }

        private void pnlCapNhatSach_Click(object sender, EventArgs e)
        {
            pnlLocSach.Visible = false;
            pnlTimKiemSach.Visible = false;
            pnlHighLightBoLocSach.BackColor = grayBackColor;
            pnlHighLightTimKiemSach.BackColor = grayBackColor;
        }

        private void pnlThongTinSach_Click(object sender, EventArgs e)
        {
            pnlLocSach.Visible = false;
            pnlTimKiemSach.Visible = false;
            pnlHighLightBoLocSach.BackColor = grayBackColor;
            pnlHighLightTimKiemSach.BackColor = grayBackColor;
        }

        // Reset trang thai cac Control
        private void ResetControlSach()
        {
            dgvSach.ClearSelection();

            // Clear noi dung TextBox
            cboTenSach.ResetText();
            cboTacGia.ResetText();
            cboNamXB.ResetText();
            cboNXB.ResetText();
            cboNhaPhatHanh.ResetText();
            txtGiaTri.ResetText();
            txtSoLuong.ResetText();
            cboChuDe.ResetText();
            cboTheLoai.ResetText();
            dtmNgayNhap.Value = DateTime.Today;

            // Unvisible cac label Them du lieu            
            btnThemTacGia.Visible = false;
            btnThemNXB.Visible = false;
            btnThemNhaPhatHanh.Visible = false;
            btnThemChuDe.Visible = false;
            btnThemTheLoai.Visible = false;

            // Dat lai trang thai ReadOnly
            cboTenSach.Enabled = false;
            cboTacGia.Enabled = false;
            cboNamXB.Enabled = false;
            cboNXB.Enabled = false;
            cboNhaPhatHanh.Enabled = false;
            cboChuDe.Enabled = false;
            cboTheLoai.Enabled = false;
            txtGiaTri.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            dtmNgayNhap.Enabled = false;

            // Lay lai data cho Combo Box
            cboTenSach.Items.Clear();
            GetDataComboBox(cboTenSach, "TenSach", "Sach");

            cboTacGia.Items.Clear();
            GetDataComboBox(cboTacGia, "TenTacGia", "TacGia");

            cboNamXB.Items.Clear();
            GetDataComboBox(cboNamXB, "NamXB", "Sach");

            cboNXB.Items.Clear();
            GetDataComboBox(cboNXB, "TenNXB", "NXB");

            cboNhaPhatHanh.Items.Clear();
            GetDataComboBox(cboNhaPhatHanh, "TenNhaPhatHanh", "NhaPhatHanh");

            cboChuDe.Items.Clear();
            GetDataComboBox(cboChuDe, "TenChuDe", "ChuDe");

            cboTheLoai.Items.Clear();
            GetDataComboBox(cboTheLoai, "TenTheLoai", "TheLoai");

            // Tat tab Tim kiem va Loc
            pnlLocSach.Visible = false;
            pnlTimKiemSach.Visible = false;
            pnlHighLightBoLocSach.BackColor = grayBackColor;
            pnlHighLightTimKiemSach.BackColor = grayBackColor;

            // Dat lai cac button Cap nhat
            Font fontButton = new Font("Sitka Display", 12, FontStyle.Bold);

            btnHuyCapNhatSach.Text = "Hủy";
            btnHuyCapNhatSach.Visible = false;
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

            lblThongBaoSach.Location = new Point(19, 17);
            lblThongBaoSach.Text = "";
        }
        // ==========================================================================
        //
        // CHO MUON SACH
        //
        BUS_PhieuMuon busPhieuMuon = new BUS_PhieuMuon();
        private void mainbtnChoMuonSach_Click(object sender, EventArgs e)
        {
            this.pnltabChoMuonSach.BringToFront();
            this.dgvCMSDSPhieuMuon.DataSource = busPhieuMuon.getPhieuMuon();
            ChonMainButton(mainbtnChoMuonSach);

            Button sentBtn = (Button)sender;

            //khoi tao du lieu cho tab Phieu Muon
            this.loadDataForCBMaDocGia(sentBtn.Text);
            this.loadDataForCBMaSach();
        }

        private void loadDataForCBMaDocGia(string nameBtn)
        {
            List<string> column = new List<string>();
            column.Add("MaDocGia");
            column.Add("HoTen");
            DataTable dt = new DataTable();


            if (nameBtn == "Cho Mượn Sách")
            {
                dt = busDG.getDocGia(column);

                //cboNTSNhapMaDocGia.Items.Clear();
                cbCMSNhapMaDocGia.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbCMSNhapMaDocGia.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
                }
            }
            else if (nameBtn == "Nhận Trả Sách")
            {
                dt = busDG.getDocGia(column);

                //cbCMSNhapMaDocGia.Items.Clear();
                cboNTSNhapMaDocGia.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cboNTSNhapMaDocGia.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
                }
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
                dgvCMSSachDangMuon.DataSource = busDG.GetSachDangMuon(cbCMSNhapMaDocGia.Text.Substring(0, 5));
            }
        }

        private void btnCMSLapPM_Click(object sender, EventArgs e)
        {
            if (this.btnCMSLapPM.Text == "Lập Phiếu Mượn")
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
            else if (this.btnCMSLapPM.Text == "Xác Nhận")
            {
                if (dgvPMSach.Rows.Count > 1)
                {
                    BUS_PhieuMuon busPhieuMuon = new BUS_PhieuMuon();

                    DataTable dt = busPhieuMuon.getPhieuMuon();
                    string prvMaPhieuMuon = "null";
                    if (dt.Rows.Count > 0)
                    {
                        prvMaPhieuMuon = dt.Rows[dt.Rows.Count - 1]["MaPhieuMuon"].ToString();
                    }
                    if (busPhieuMuon.insertPhieuMuon(prvMaPhieuMuon, dtoThuThu.MaThuThu, cbCMSNhapMaDocGia.Text.Substring(0, 5), DateTime.Today, dgvPMSach.Rows.Count - 1))
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
                    dgvCMSSachDangMuon.DataSource = busDG.GetSachDangMuon(cbCMSNhapMaDocGia.Text.Substring(0, 5));
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
                if (dgvPMSach.Rows.Count <= 3)
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
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvPMSach.SelectedRows)
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


        // ==========================================================================
        //
        // NHAN TRA SACH
        //


        BUS_PhieuTra busPhieuTra = new BUS_PhieuTra();

        private void mainbtnNhanTraSach_Click(object sender, EventArgs e)
        {
            this.pnltabNhanTraSach.BringToFront();
            this.dgvPTDanhSachPhieuTra.DataSource = busPhieuTra.getFullPhieuTra();
            ChonMainButton(mainbtnNhanTraSach);

            Button sentBtn = (Button)sender;
            this.loadDataForCBMaDocGia(sentBtn.Text);


        }
        private void PTloadDataForCBMaSach()
        {
            List<string> column = new List<string>();
            column.Add("MaSach");
            column.Add("TenSach");
            DataTable dt = new DataTable();

            for (int i = 0; i < dgvNTSSachDangMuon.Rows.Count - 1; i++)
            {
                string condition = string.Format("MaSach = '{0}'", dgvNTSSachDangMuon.Rows[i].Cells["MaSach"].Value.ToString());
                dt = busSach.getSach(column, condition);
                cboPTNhapMaSach.Items.Add(dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString());
            }
        }
        private void PTLoadDataForCBTinhTrang()
        {
            DataTable dt = new DataTable();
            BUS_TinhTrang busTinhTrang = new BUS_TinhTrang();
            dt = busTinhTrang.GetTinhTrang();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboPTTinhTrangSach.Items.Add(dt.Rows[i]["TenTinhTrang"].ToString());
            }
        }

        private void cboNTSNhapMaDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tenDocGia = "";
                string condition = string.Format("MaDocGia = '{0}'", cboNTSNhapMaDocGia.Text.Substring(0, 5));
                List<string> listProp = new List<string>();
                listProp.Add("HoTen");
                DataTable dt = busDG.getDocGia(listProp, condition);
                if (dt.Rows.Count != 0)
                {
                    tenDocGia = (" " + dt.Rows[0]["HoTen"].ToString());
                    lblNTSTenDG.Text = "Độc giả: ";
                    lblNTSTenDG.Text += tenDocGia;
                }
                dgvNTSSachDangMuon.DataSource = busDG.GetSachDangMuon(cboNTSNhapMaDocGia.Text.Substring(0, 5));
            }
        }

        private void btnNTSLapPhieuTra_Click(object sender, EventArgs e)
        {
            if (this.btnNTSLapPhieuTra.Text == "Lập Phiếu Trả")
            {
                if (this.cboNTSNhapMaDocGia.Text != "" && this.lblNTSTenDG.Text != "Độc giả")
                {
                    PTloadDataForCBMaSach();
                    PTLoadDataForCBTinhTrang();

                    this.lblNTSThongBao.Text = "";
                    string tenDocGia = "";
                    string ngayTra = "";
                    string tenThuThu = "";
                    string condition = string.Format("MaDocGia = '{0}'", cboNTSNhapMaDocGia.Text.Substring(0, 5));
                    List<string> listProp = new List<string>();
                    listProp.Add("HoTen");
                    DataTable dt = busDG.getDocGia(listProp, condition);
                    if (dt.Rows.Count != 0)
                    {
                        tenDocGia = (" " + dt.Rows[0]["HoTen"].ToString());
                        lblPTTenDocGia.Text = "Độc giả: ";
                        lblPTTenDocGia.Text += tenDocGia;

                        ngayTra = "  " + DateTime.Today.ToString().Substring(0, 10);
                        lblPTNgayTra.Text = "Ngày Trả: ";
                        lblPTNgayTra.Text += ngayTra;

                        tenThuThu = " " + dtoThuThu.HoTen;
                        lblPTThuThu.Text = "Thủ Thư: ";
                        lblPTThuThu.Text += tenThuThu;
                    }
                    this.pnlPTPhieuTra.BringToFront();

                    btnNTSLapPhieuTra.Text = "Xác Nhận";
                }
                else
                {
                    this.lblNTSThongBao.Text = "Chưa nhập mã độc giả";
                }
            }
            else if (this.btnNTSLapPhieuTra.Text == "Xác Nhận")
            {
                if (dgvPTDSSach.Rows.Count > 1)
                {
                    BUS_PhieuTra busPhieuTra = new BUS_PhieuTra();

                    DataTable dt = busPhieuTra.getPhieuTra();
                    string prvMaPhieuTra = "null";
                    if (dt.Rows.Count > 0)
                    {
                        prvMaPhieuTra = dt.Rows[dt.Rows.Count - 1]["MaPhieuTra"].ToString();
                    }

                    if (busPhieuTra.insertPhieuTra(prvMaPhieuTra, dtoThuThu.MaThuThu, cboNTSNhapMaDocGia.Text.Substring(0, 5), DateTime.Today, dgvPTDSSach.Rows.Count - 1))
                    {
                        lblNTSThongBao.Text = "Thêm phiếu trả thành công";

                    }



                    dt = busPhieuTra.getPhieuTra();

                    for (int i = 0; i < dgvPTDSSach.Rows.Count - 1; i++)
                    {
                        BUS_CTPT busCTPT = new BUS_CTPT();
                        string maSach = dgvPTDSSach.Rows[i].Cells[0].Value.ToString();
                        string maPhieuTra = dt.Rows[dt.Rows.Count - 1]["MaPhieuTra"].ToString();

                        DataTable dtTinhTrang = new DataTable();
                        BUS_TinhTrang busTinhTrang = new BUS_TinhTrang();
                        string conditionTinhTrang = string.Format(" TenTinhTrang = N'{0}'", dgvPTDSSach.Rows[i].Cells[1].Value.ToString());
                        dt = busTinhTrang.GetTinhTrang(conditionTinhTrang);
                        string maTinhTrang = dt.Rows[0][0].ToString();

                        string conditionSach = string.Format("MaSach = '{0}'", maSach);


                        busCTPT.insertCTPT(maPhieuTra, maSach, maTinhTrang);



                        DataTable dtSach = busSach.getSach(conditionSach);
                        if (dgvPTDSSach.Rows[i].Cells[1].Value.ToString() == "Tốt")
                        {
                            int soLuong = int.Parse(dtSach.Rows[0]["SoLuong"].ToString()) + 1;
                            busSach.updateSoluongSach(dtSach.Rows[0]["MaSach"].ToString(), soLuong);
                        }
                        else if (dgvPTDSSach.Rows[i].Cells[1].Value.ToString() == "Hỏng nhẹ")
                        {
                            int soLuong = int.Parse(dtSach.Rows[0]["SoLuong"].ToString()) + 1;
                            busSach.updateSoluongSach(dtSach.Rows[0]["MaSach"].ToString(), soLuong);
                        }

                    }
                    this.dgvNTSSachDangMuon.DataSource = busDG.GetSachDangMuon(cboNTSNhapMaDocGia.Text.Substring(0, 5));
                    this.btnNTSLapPhieuTra.Text = "Lập Phiếu Trả";
                }
                else
                {
                    this.lblCMSThongBao.Text = "Chưa chọn sách";
                }
            }


        }

        private void btnPTEsc_Click(object sender, EventArgs e)
        {
            this.pnlDSPhieuTra.BringToFront();
            this.dgvPTDanhSachPhieuTra.DataSource = busPhieuTra.getFullPhieuTra();

        }

        private void cboPTNhapMaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboPTTinhTrangSach.Focus();
            }
        }

        private void cboPTTinhTrangSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboPTTinhTrangSach.Text != "" && cboPTNhapMaSach.Text != "")
                {
                    if (dgvPTDSSach.Rows.Count <= cboPTNhapMaSach.Items.Count)
                    {
                        string maSach = cboPTNhapMaSach.Text.Substring(0, 5);
                        string tenSach = cboPTNhapMaSach.Text.Substring(7);
                        string tinhTrang = cboPTTinhTrangSach.Text;
                        dgvPTDSSach.Rows.Add(maSach, tinhTrang, tenSach);
                    }

                    cboPTNhapMaSach.Focus();
                    cboPTTinhTrangSach.Text = "";
                    cboPTNhapMaSach.Text = "";
                }
            }
        }

        
    }
}