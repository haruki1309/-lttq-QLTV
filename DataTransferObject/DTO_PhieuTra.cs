using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_PhieuTra
    {
        //======== Properties =========//
        private string maPhieuTra;
        private string maDocGia;
        private string maThuThu;
        private DateTime ngayMuon;
        private int soLuong;

        //======== Getter/Setter =======//
        public string MaPhieuTra
        {
            get { return maPhieuTra; }
            set { maPhieuTra = value; }
        }

        public string MaDocGia
        {
            get { return maDocGia; }
            set { maDocGia = value; }
        }

        public string MaThuThu
        {
            get { return maThuThu; }
            set { maThuThu = value; }
        }

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        //======= Constructor ========//
        public DTO_PhieuTra()
        { }

        // Phiếu trả có đầy đủ thông tin
        public DTO_PhieuTra(string maPM, string maDG, string maTT, DateTime ngayMuon, int soLuong)
        {
            this.maPhieuTra = maPM;
            this.maDocGia = maDG;
            this.maThuThu = maTT;
            this.ngayMuon = ngayMuon;
            this.soLuong = soLuong;
        }
    }
}
