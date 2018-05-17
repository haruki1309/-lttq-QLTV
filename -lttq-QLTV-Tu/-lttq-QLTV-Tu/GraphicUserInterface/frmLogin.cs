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
            if(busTT.Login(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                lblStatus.Text = "(*) Đăng nhập thành công";
                frmDocGia frmDocGia = new frmDocGia();                
                this.Hide();
                frmDocGia.ShowDialog();
                
            }
            else
            {
                lblStatus.Text = "(*) Sai Tên tài khoản hoặc Mật khẩu";
            }
        }
        
        
    }
}
