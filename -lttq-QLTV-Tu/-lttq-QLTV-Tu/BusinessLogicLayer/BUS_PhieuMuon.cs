using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DatabaseAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BUS_PhieuMuon
    {
        DAL_PhieuMuon dalPhieuMuon = new DAL_PhieuMuon();
        public DataTable getPhieuMuon()
        {
            return dalPhieuMuon.Get();
        }

        public bool insertPhieuMuon(string maPhieuMuon, string maDocGia, string maThuThu, DateTime ngayMuon, int soLuong)
        {
            DTO_PhieuMuon phieuMuon = new DTO_PhieuMuon(maPhieuMuon, maDocGia, maThuThu, ngayMuon, soLuong);
            return dalPhieuMuon.InSert(phieuMuon);
        }
    }
}
