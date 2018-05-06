using System;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace GraphicUserInterface
{
    public partial class frmLogin : Form
    {
        BUS_ThuThu busTT = new BUS_ThuThu();
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(busTT.Login(tbx_MaThuThu.Text, tbx_MatKhau.Text))
            {
                MessageBox.Show("Đăng Nhập Thành Công");
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
        }

        
    }
}
