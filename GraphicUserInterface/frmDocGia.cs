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
        public frmDocGia()
        {
            InitializeComponent();
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            this.dgvDocGia.DataSource = busDG.getDocGia();

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
            if(!isClose)
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
            if(!isClose)
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

            foreach(string column in  listProperties)
            {               
                if (column == "DiaChi")
                {
                    this.dgvDocGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                }
                else if (column == "SDT")
                {
                    this.dgvDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
                }
                else if(column == "Cmnd")
                {
                    this.dgvDocGia.Columns["CMND"].HeaderText = "Chứng Minh Thư";
                }
                else if(column == "NgaySinh")
                {
                    this.dgvDocGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                }
                else if(column == "NgayDK")
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
            else if(btnThemDocGia.Text == "Okay")
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

            
            btnThemDocGia.Enabled = false;
            btnXoaDocGia.Enabled = false;


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

                    if (busDG.updateDocGia(maDocGia, txtHoTenDocGia.Text, txtDiaChiDocGia.Text ,txtSDTDocGia.Text, txtCMNDDocGia.Text, dtmNgaySinhDocGia.Value, dtmNgayDKDocGia.Value))
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
            if(btnHuyThaoTacDocGia.Text == "Hủy")
            {
                if(btnThemDocGia.Text == "Xác Nhận")
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
            else if(btnHuyThaoTacDocGia.Text == "Xác Nhận")
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
                else if(btnSuaDocGia.Text == "Xác Nhận")
                {
                    btnSuaDocGia.Text = "Sửa";
                    btnThemDocGia.Enabled = true;
                    btnXoaDocGia.Enabled = true;
                }
                else if(btnXoaDocGia.Text == "Xác Nhận")
                {
                    btnXoaDocGia.Text = "Xóa";
                    btnSuaDocGia.Enabled = true;
                    btnThemDocGia.Enabled = true;
                }
                btnHuyThaoTacDocGia.Text = "Hủy";
                lblThongBaoDocGia.Text = "";
            }
        }




        //
        //Tab Kho Sach
        //
        private void mainbtnKhoSach_Click(object sender, EventArgs e)
        {
            this.pnltabKhoSach.BringToFront();
        }





        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (dgvDocGia.SelectedRows.Count > 0)
        //    {
        //        DialogResult result = MessageBox.Show("Khi bạn nhấn \"Yes\" đối tượng sẽ bị xóa vĩnh viễn.\nBạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);

        //        if (result == DialogResult.Yes)
        //        {
        //            DataGridViewRow row = dgvDocGia.CurrentRow;

        //            string maDocGia = row.Cells[0].Value.ToString();

        //            if (busDG.deleteDocGia(maDocGia))
        //            {
        //                MessageBox.Show("Xóa thành công !");
        //                dgvDocGia.DataSource = busDG.getDocGia();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa không thành công !");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một đối tượng !");
        //    }

        //}

        //private void btnFinishSearch_Click(object sender, EventArgs e)
        //{
        //    dgvDocGia.DataSource = busDG.getDocGia();
        //}

        //private void btnSearchFor_Click(object sender, EventArgs e)
        //{
        //    string findCondition = "";

        //    try
        //    {
        //        if (cboSearchFor.SelectedItem.ToString() == "Mã độc giả")
        //            findCondition = String.Format("MaDocGia = '{0}'", txtSearchFor.Text);
        //        else
        //        {
        //            if (cboSearchFor.SelectedItem.ToString() == "Tên độc giả")
        //                findCondition = String.Format("HoTen = N'{0}'", txtSearchFor.Text);
        //            else
        //            {
        //                if (cboSearchFor.SelectedItem.ToString() == "CMND")
        //                    findCondition = String.Format("CMND = '{0}'", txtSearchFor.Text);
        //                else
        //                {
        //                    if (cboSearchFor.SelectedItem.ToString() == "Số điện thoại")
        //                        findCondition = String.Format("SDT = '{0}'", txtSearchFor.Text);
        //                }
        //            }

        //        }

        //        dgvDocGia.DataSource = busDG.getDocGia(findCondition);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }

        //}

        //private void cboSearchFor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboSearchFor.SelectedIndex == 3)
        //    {
        //        txtSearchFor.Visible = true;
        //        txtSearchFor.Text = "Số điện thoại";
        //    }
        //    else if (cboSearchFor.SelectedIndex == 2)
        //    {
        //        txtSearchFor.Visible = true;
        //        txtSearchFor.Text = "CMND";
        //    }
        //    else if (cboSearchFor.SelectedIndex == 1)
        //    {
        //        txtSearchFor.Visible = true;
        //        txtSearchFor.Text = "Họ tên";
        //    }
        //    else if (cboSearchFor.SelectedIndex == 0)
        //    {
        //        txtSearchFor.Visible = true;
        //        txtSearchFor.Text = "Mã độc giả";
        //    }
        //}

        //private void clbThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}


    }
}
    

