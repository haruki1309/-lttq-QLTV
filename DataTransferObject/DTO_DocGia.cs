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
        private string cmnd;
        private string ngaySinh;
        private string ngayDK;

        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NgayDK { get => ngayDK; set => ngayDK = value; }
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
    }
}
