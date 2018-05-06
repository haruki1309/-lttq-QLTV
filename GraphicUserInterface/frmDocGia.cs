using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = busDG.getDocGia();
        }

        private void dgvDocGia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = busDG.getDocGia();
            tbxHoten.Text = dt.Rows[e.RowIndex]["HoTen"].ToString();
            tbxDiaChi.Text = dt.Rows[e.RowIndex]["DiaChi"].ToString();
            tbxCMND.Text = dt.Rows[e.RowIndex]["CMND"].ToString();
            tbxSDT.Text = dt.Rows[e.RowIndex]["SDT"].ToString();          
            dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgaySinh"].ToString());                      
            dtpNgayDK.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgayDK"].ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.SelectedRows.Count > 0)
            {
                if (tbxHoten.Text != "" && tbxDiaChi.Text != "" && tbxSDT.Text !="" && tbxCMND.Text != "")
                {
                    DataGridViewRow row = dgvDocGia.CurrentRow;

                    DTO_DocGia dtoDocGia = new DTO_DocGia(row.Cells[0].Value.ToString(), tbxHoten.Text, tbxDiaChi.Text, tbxSDT.Text, tbxCMND.Text, dtpNgaySinh.Value, dtpNgayDK.Value);

                    if(busDG.updateDocGia(dtoDocGia))
                    {
                        MessageBox.Show("Sửa thành công !");
                        dgvDocGia.DataSource = busDG.getDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công !");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Khi bạn nhấn \"Yes\" đối tượng sẽ bị xóa vĩnh viễn.\nBạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvDocGia.CurrentRow;

                    string maDocGia = row.Cells[0].Value.ToString();

                    if (busDG.deleteDocGia(maDocGia))
                    {
                        MessageBox.Show("Xóa thành công !");
                        dgvDocGia.DataSource = busDG.getDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đối tượng !");
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (grpTimKiemDocGia.Visible == false)
                grpTimKiemDocGia.Visible = true;
            else
            {
                string findCondition = "";

                //if (cboFindFor.SelectedItem.ToString() == "Mã độc giả")
                //    findCondition = String.Format("MaDocGia = '{0}'", txtFindID.Text);
                //else
                //{
                //    if (cboFindFor.SelectedItem.ToString() == "Họ tên")
                //        findCondition = String.Format("HoTen = '{0}'", txtFindName.Text);
                //    else
                //    {
                //        if (cboFindFor.SelectedItem.ToString() == "CMND")
                //            findCondition = String.Format("CMND = '{0}'", txtFindPersonalID.Text);
                //        else
                //        {
                //            if (cboFindFor.SelectedItem.ToString() == "Số điện thoại")
                //                findCondition = String.Format("SDT = '{0}'", txtFindPhoneNumber.Text);
                //        }
                //    }

                //}



                if (cboFindFor.SelectedItem.ToString() == "Mã độc giả")
                    findCondition = String.Format("MaDocGia = '{0}'", txtFindID.Text);
                
                    if (cboFindFor.SelectedItem.ToString() == "Họ tên")
                        findCondition = String.Format("HoTen = N'{0}'", txtFindName.Text);
                    
                        if (cboFindFor.SelectedItem.ToString() == "CMND")
                            findCondition = String.Format("CMND = '{0}'", txtFindPersonalID.Text);
                        
                            if (cboFindFor.SelectedItem.ToString() == "Số điện thoại")
                                findCondition = String.Format("SDT = '{0}'", txtFindPhoneNumber.Text);
                        
                    

                



                dgvDocGia.DataSource = busDG.getDocGia(findCondition);

            }
        }

        private void cboFindFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point p = new Point(6, 59);

            if (cboFindFor.SelectedIndex == 3)
            {
                txtFindPhoneNumber.Location = p;
                txtFindPhoneNumber.Visible = true;

                txtFindID.Visible = false;
                txtFindPersonalID.Visible = false;
                txtFindName.Visible = false;
            }
            else if (cboFindFor.SelectedIndex == 2)
            {
                txtFindPersonalID.Location = p;
                txtFindPersonalID.Visible = true;

                txtFindID.Visible = false;
                txtFindName.Visible = false;
                txtFindPhoneNumber.Visible = false;
            }
            else if (cboFindFor.SelectedIndex == 1)
            {
                txtFindName.Location = p;
                txtFindName.Visible = true;

                txtFindID.Visible = false;
                txtFindPersonalID.Visible = false;
                txtFindPhoneNumber.Visible = false;
            }
            else if (cboFindFor.SelectedIndex == 0)
            {
                txtFindID.Location = p;

                txtFindID.Visible = true;
                txtFindName.Visible = false;
                txtFindPersonalID.Visible = false;
                txtFindPhoneNumber.Visible = false;            
            }
        }
    }
}
