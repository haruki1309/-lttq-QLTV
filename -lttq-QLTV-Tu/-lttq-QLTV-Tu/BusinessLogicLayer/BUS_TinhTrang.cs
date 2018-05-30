using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BUS_TinhTrang
    {
        DAL_TinhTrang dalTinhTrang = new DAL_TinhTrang();
        public DataTable GetTinhTrang()
        {
            return dalTinhTrang.Get();
        }
        public DataTable GetTinhTrang(string condition)
        {
            return dalTinhTrang.Get(condition);
        }
    }
}
