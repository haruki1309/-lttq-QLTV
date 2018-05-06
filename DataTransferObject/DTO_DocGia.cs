using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_DocGia
    {
        private string maDocGia;
        private string hoTen;
        private string diaChi;
        private string soDT;
        private string cmnd;
        private DateTime ngaySinh;
        private DateTime ngayDK;

        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayDK { get => ngayDK; set => ngayDK = value; }
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string SoDT { get => soDT; set => soDT = value; }


        public DTO_DocGia()
        { }

        public DTO_DocGia(string maDocGia, string hoTen, string diaChi, string soDT, string cmnd, DateTime ngaySinh, DateTime ngayDK)
        {
            this.maDocGia = maDocGia;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
            this.ngayDK = ngayDK;
        }             
    }
}
