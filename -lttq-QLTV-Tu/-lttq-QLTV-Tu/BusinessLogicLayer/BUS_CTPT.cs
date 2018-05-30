using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DatabaseAccessLayer;

namespace BusinessLogicLayer
{
    public class BUS_CTPT
    {
        DAL_CTPT dalCTPT = new DAL_CTPT();
        public bool insertCTPT(string MaPhieuTra, string MaSach, string MaTinhTrang)
        {
            try
            {
                DTO_CTPT ctpt = new DTO_CTPT(MaPhieuTra, MaSach, MaTinhTrang);
                return dalCTPT.InSert(ctpt);
            }
            catch
            {
                return false;
            }
        }
    }
}
