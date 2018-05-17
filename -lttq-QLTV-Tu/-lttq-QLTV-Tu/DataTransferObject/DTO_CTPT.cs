using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_CTPT
    {
        //====== Properties ======//
        private string maPhieuTra;
        private string maSach;
        private string maTinhTrang;

        //======= Getter/Setter =======//
        public string MaPhieuTra
        {
            get { return maPhieuTra; }
            set { maPhieuTra = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }

        //===== Constructor =======//
        public DTO_CTPT()
        { }

        // Chi tiết phiếu trả đầy đủ thông tin
        public DTO_CTPT(string maPM, string maSach, string maTinhTrang)
        {
            this.maPhieuTra = maPM;
            this.maSach = maSach;
            this.maTinhTrang = maTinhTrang;
        }

        // Chi tiết phiếu trả khuyết tình trạng sách
        public DTO_CTPT(string maPM, string maSach)
        {
            this.maPhieuTra = maPM;
            this.maSach = maSach;            
        }
    }
}
