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
    public class BUS_PhieuTra
    {
        DAL_PhieuTra dalPhieuTra = new DAL_PhieuTra();
        public DataTable getPhieuTra()
        {
            return dalPhieuTra.Get();
        }
        public DataTable getFullPhieuTra()
        {
            return dalPhieuTra.GetFull();
        }
        public bool insertPhieuTra(string maPhieuTra, string maThuThu, string maDocGia, DateTime ngayTra, int soLuong)
        {
            DTO_PhieuTra phieuTra = new DTO_PhieuTra(maPhieuTra, maDocGia, maThuThu, ngayTra, soLuong);
            return dalPhieuTra.InSert(phieuTra);
        }
    }
}
