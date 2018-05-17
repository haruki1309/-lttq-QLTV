using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    partial class DTO_NXB
    {
        //====== Properties ======//
        private string maNXB;
        private string tenNXB;
        private string diaChi;
        private string soDT;
        private string email;

        //======= Getter/Setter =======//
        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }

        public string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
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

        //====== Constructor ======//
        public DTO_NXB()
        { }

        // Nhà xuất bản có đủ thông tin
        public DTO_NXB(string maNXB, string tenNXB, string diaChi, string SDT, string email)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;
            this.soDT = SDT;
            this.email = email;
        }

        // Nhà xuất bản khuyết email
        public DTO_NXB(string maNXB, string tenNXB, string diaChi, string SDT)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;
            this.soDT = SDT;           
        }

        // Nhà xuất bản khuyết số điện thoại, email
        public DTO_NXB(string maNXB, string tenNXB, string diaChi)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;        
        }
    }
}
