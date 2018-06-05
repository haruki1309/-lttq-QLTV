using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
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
                this.pnlLoginWelcome.BringToFront();                             
                this.frmLoginLoading.Start();

            }
            else
            {
                lblLoginThongBao.Text = "(*) Sai Tài khoản hoặc Mật khẩu";
                txtMatKhau.Clear();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.frmLoginLoadTimer.Start();
            
        }

        private void frmLoginTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity *= 3;
            if (this.Opacity == .100)
            {
                this.frmLoginLoadTimer.Stop();
                this.pnlLoginThongTinDN.BringToFront();
            }
        }

        private void frmLoginLoading_Tick(object sender, EventArgs e)
        {
            this.pnlLoginLoading2.Width += 50;
            if (this.pnlLoginLoading2.Width >= 720)
            {
                this.frmLoginLoading.Stop();
                frmMain frmDocGia = new frmMain();
                frmDocGia.DTO_ThuThu.MaThuThu = txtTaiKhoan.Text;
                this.Hide();
                frmDocGia.ShowDialog();              
            }
        }

        private void btnLoginESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
