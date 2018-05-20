using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DatabaseAccessLayer;

namespace BusinessLogicLayer
{
    public class BUS_CTPM
    {
        DAL_CTPM ctpmDAL = new DAL_CTPM();
        public bool insertCTPM(string MaPhieuMuon, string MaSach)
        {
            try
            {
                DTO_CTPM ctpm = new DTO_CTPM(MaPhieuMuon, MaSach);
                return ctpmDAL.InSert(ctpm);
            }
            catch
            {
                return false;
            }
        }
    }
}
