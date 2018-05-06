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

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = busDG.getDocGia();
        }

        private void dgvDocGia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.tbxHoten.ReadOnly = true;
            this.tbxDiaChi.ReadOnly = true;
            this.tbxCMND.ReadOnly = true;
            this.tbxSDT.ReadOnly = true;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgayDK.Enabled = false;

            DataTable dt = busDG.getDocGia();
            tbxHoten.Text = dt.Rows[e.RowIndex]["HoTen"].ToString();
            tbxDiaChi.Text = dt.Rows[e.RowIndex]["DiaChi"].ToString();
            tbxCMND.Text = dt.Rows[e.RowIndex]["CMND"].ToString();
            tbxSDT.Text = dt.Rows[e.RowIndex]["SDT"].ToString();          
            dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgaySinh"].ToString());                      
            dtpNgayDK.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["NgayDK"].ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.tbxHoten.ReadOnly = false;
            this.tbxHoten.Clear();
            this.tbxDiaChi.ReadOnly = false;
            this.tbxDiaChi.Clear();
            this.tbxCMND.ReadOnly = false;
            this.tbxCMND.Clear();
            this.tbxSDT.ReadOnly = false;
            this.tbxSDT.Clear();
            this.dtpNgaySinh.Enabled = true;
            this.dtpNgayDK.Enabled = true;

            

            if (tbxHoten.Text != "")
            {
                string prvMaDocGia = "";
                DataTable dt = busDG.getDocGia();
                prvMaDocGia = dt.Rows[dt.Rows.Count - 1]["MaDocGia"].ToString();

                DialogResult dialog = MessageBox.Show("Thông tin bạn nhập đã chính xác chưa!", "Cảnh báo!", MessageBoxButtons.YesNo);
                bool isInsert = false;
                if (dialog == DialogResult.Yes)
                {
                    isInsert = busDG.insertDocGia(prvMaDocGia, tbxHoten.Text, tbxDiaChi.Text, tbxSDT.Text, tbxCMND.Text, dtpNgaySinh.Value, dtpNgayDK.Value);
                }
                if (isInsert)
                {
                    dgvDocGia.DataSource = busDG.getDocGia();
                    MessageBox.Show("Thêm thành công");
                }             
            }
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<string> listProperties = new List<string>();                    
            listProperties.Add("MaDocGia");
            listProperties.Add("HoTen");
            if(clbThuocTinh.CheckedItems.Count > 0)
            {
                foreach(string item in clbThuocTinh.CheckedItems)
                {
                    listProperties.Add(item);
                }              
            }
            dgvDocGia.DataSource = busDG.getDocGia(listProperties);
        }
    }
}
