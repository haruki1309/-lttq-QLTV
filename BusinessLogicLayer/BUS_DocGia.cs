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
    public class BUS_DocGia
    {
        DAL_DocGia dalDocGia = new DAL_DocGia();

        public DataTable getDocGia()
        {
            return dalDocGia.Get();
        }
        
        //public bool insertDocGia(string prvMaDocGia, string hoTen, string diaChi, string soDT, string cmnd, DateTime ngaySinh, DateTime ngayDK)
        //{
        //    int iMaDocGia;
        //    DataTable dt = dalDocGia.Get();
        //    return dalDocGia.Insert(dTO_DocGia);
        //}
        public bool updateDocGia(DTO_DocGia dTO_DocGia)
        {
            return dalDocGia.Update(dTO_DocGia);
        }
        public bool delete(string MaDocGia)
        {
            return dalDocGia.Delete(MaDocGia);
        }
        public DataTable getDocGia(string MaDocGia)
        {
            return dalDocGia.Get(MaDocGia);
        }
    }
}
