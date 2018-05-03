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
    public class BUS_ThuThu
    {
        DAL_ThuThu dalThuThu = new DAL_ThuThu();

        public DataTable getThuThu()
        {
            return dalThuThu.Get();
        }
        public bool Login(string MaThuThu, string MatKhau)
        {
            if(dalThuThu.Login(MaThuThu, MatKhau))
            {
                return true;
            }
            return false;
        }
        public bool insertThuThu(DTO_ThuThu dTO_ThuThu)
        {
            return dalThuThu.Insert(dTO_ThuThu);
        }
        public bool updateThuThu(DTO_ThuThu dTO_ThuThu)
        {
            return dalThuThu.Update(dTO_ThuThu);
        }
        public bool deleteThuThu(string MaThuThu)
        {
            return dalThuThu.Delete(MaThuThu);
        }
    }
}
