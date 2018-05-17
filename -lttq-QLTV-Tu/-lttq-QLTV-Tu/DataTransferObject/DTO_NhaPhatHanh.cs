using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    partial class DTO_NhaPhatHanh
    {
        //===== Properties ======//
        private string maNhaPhatHanh;
        private string tenNhaPhatHanh;
        private string diaChi;
        private string soDT;        
        private string email;

        //====== Getter/Setter =====//
        public string MaNhaPhatHanh
        {
            get { return maNhaPhatHanh; }
            set { maNhaPhatHanh = value; }
        }

        public string TenNhaPhatHanh
        {
            get { return tenNhaPhatHanh; }
            set { tenNhaPhatHanh = value; }
        }
        
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //======= Constructor ======//
        public DTO_NhaPhatHanh()
        { }

        // Nhà phát hành có đầy đủ thông tin
        public DTO_NhaPhatHanh(string maNPH, string tenNPB, string diaChi, string SDT, string email)
        {
            this.maNhaPhatHanh = maNPH;
            this.tenNhaPhatHanh = tenNPB;
            this.diaChi = diaChi;
            this.soDT = SDT;
            this.email = email;
        }

        // Nhà phát hành khuyết email
        public DTO_NhaPhatHanh(string maNPH, string tenNPB, string diaChi, string SDT)
        {
            this.maNhaPhatHanh = maNPH;
            this.tenNhaPhatHanh = tenNPB;
            this.diaChi = diaChi;
            this.soDT = SDT;
        }

        // Nhà phát hành khuyết số điện thoại, email
        public DTO_NhaPhatHanh(string maNPH, string tenNPB, string diaChi)
        {
            this.maNhaPhatHanh = maNPH;
            this.tenNhaPhatHanh = tenNPB;
            this.diaChi = diaChi;
        }
    }
}
