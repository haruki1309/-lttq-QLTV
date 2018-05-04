using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTransferObject
{
    partial class DTO_Sach
    {
        //======= Properties ========//
        private string maSach;
        private string tenSach;
        private string maTacGia;
        private int namXB; 
        private string maNXB;
        private string maNhaPhatHanh;
        private DateTime ngayNhap;
        private string maChuDe;
        private string maTheLoai;
        private double giaTri;
        private int soLuong;

        //======== Getter/Setter =======//
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }

        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

        public int NamXB
        {
            get { return namXB; }
            set { namXB = value; }
        }

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }

        public string MaNhaPhatHanh
        {
            get { return maNhaPhatHanh; }
            set { maNhaPhatHanh = value; }
        }

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public string MaChuDe
        {
            get { return maChuDe; }
            set { maChuDe = value; }
        }

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }

        public double GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        //===== Constructor =====//
        public DTO_Sach()
        { }
    }
}
