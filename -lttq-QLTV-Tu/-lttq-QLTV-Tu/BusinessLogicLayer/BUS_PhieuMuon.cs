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
        public bool insertPhieuMuon(string prvMaPhieuMuon, string MaThuThu, string MaDocGia, DateTime NgayMuon, int soLuong)
        {
            try
            {
                string MaPhieuMuon = "";
                if(prvMaPhieuMuon == "null")
                {
                    MaPhieuMuon = "PM000";
                }
                else
                {
                    int indexOfString = 2;
                    for (int i = 2; i < prvMaPhieuMuon.Length; i++)
                    {
                        if (prvMaPhieuMuon[i] != '0')
                        {
                            indexOfString = i;
                            break;
                        }
                    }

                    int iMaPhieuMuon = int.Parse(prvMaPhieuMuon.Substring(indexOfString)) + 1;
                    MaPhieuMuon = "PM";
                    if (iMaPhieuMuon >= 0 && iMaPhieuMuon <= 9)
                    {
                        MaPhieuMuon += string.Format("00{0}", iMaPhieuMuon.ToString());
                    }
                    else if (iMaPhieuMuon >= 10 && iMaPhieuMuon <= 99)
                    {
                        MaPhieuMuon += string.Format("0{0}", iMaPhieuMuon.ToString());
                    }
                    else if (iMaPhieuMuon >= 100 && iMaPhieuMuon <= 999)
                    {
                        MaPhieuMuon += iMaPhieuMuon.ToString();
                    }
                }
                DTO_PhieuMuon phieuMuon = new DTO_PhieuMuon(MaPhieuMuon, MaDocGia, MaThuThu, NgayMuon, soLuong);
                return dalPhieuMuon.InSert(phieuMuon);
            }
            catch
            {
                return false;
            }
        }
    }
}
