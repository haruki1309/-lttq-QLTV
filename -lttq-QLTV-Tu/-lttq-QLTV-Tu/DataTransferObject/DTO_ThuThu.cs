using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_ThuThu
    {
        private string maThuThu;
        private string hoTen;
        private string diaChi;
        private string soDT;
        private string cmnd;
        private string email;
        private string ngayVL;
        private string password;

        public string MaThuThu
        {
            get
            {
                return this.maThuThu;
            }
            set
            {
                this.maThuThu = value;
            }
        }
        public string HoTen
        {
            get
            {
                return this.hoTen;
            }
            set
            {
                this.hoTen = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return this.diaChi;
            }
            set
            {
                this.diaChi = value;
            }
        }
        public string SoDT
        {
            get
            {
                return this.soDT;
            }
            set
            {
                this.soDT = value;
            }
        }
        public string CMND
        {
            get
            {
                return this.cmnd;
            }
            set
            {
                this.cmnd = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string NgayVL
        {
            get
            {
                return this.ngayVL;
            }
            set
            {
                this.ngayVL = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public DTO_ThuThu(string mathuthu, string hoten, string diachi, string sodt, string cmnd, string email, string ngayvl, string pass)
        {
            this.maThuThu = mathuthu;
            this.hoTen = hoten;
            this.diaChi = diachi;
            this.soDT = sodt;
            this.cmnd = cmnd;
            this.email = email;
            this.ngayVL = ngayvl;
            this.password = pass;
        }
    }

}
