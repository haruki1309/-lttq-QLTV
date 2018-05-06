using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_CTPM
    {
        //====== Properties ======//
        private string maPhieuMuon;
        private string maSach;

        //======= Getter/Setter =======//
        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        //===== Constructor =======//
        public DTO_CTPM()
        { }

        public DTO_CTPM(string maPM, string maSach)
        {
            this.maPhieuMuon = maPM;
            this.maSach = maSach;
        }
    }
}
