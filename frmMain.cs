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
    public partial class frmMain : Form
    {
        BUS_DocGia busDG = new BUS_DocGia();
        
        public frmMain()
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
    }
}
