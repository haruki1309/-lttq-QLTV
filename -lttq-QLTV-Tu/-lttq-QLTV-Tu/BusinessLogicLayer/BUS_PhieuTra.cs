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
        public bool insertPhieuTra(string prvMaPhieuTra, string MaThuThu, string MaDocGia, DateTime NgayTra, int soLuong)
        {
            try
            {
                string MaPhieuTra = "";
                if (prvMaPhieuTra == "null")
                {
                    MaPhieuTra = "PT000";
                }
                else
                {
                    int indexOfString = 2;
                    for (int i = 2; i < prvMaPhieuTra.Length; i++)
                    {
                        if (prvMaPhieuTra[i] != '0')
                        {
                            indexOfString = i;
                            break;
                        }
                    }

                    int iMaPhieuTra = int.Parse(prvMaPhieuTra.Substring(indexOfString)) + 1;
                    MaPhieuTra = "PT";
                    if (iMaPhieuTra >= 0 && iMaPhieuTra <= 9)
                    {
                        MaPhieuTra += string.Format("00{0}", iMaPhieuTra.ToString());
                    }
                    else if (iMaPhieuTra >= 10 && iMaPhieuTra <= 99)
                    {
                        MaPhieuTra += string.Format("0{0}", iMaPhieuTra.ToString());
                    }
                    else if (iMaPhieuTra >= 100 && iMaPhieuTra <= 999)
                    {
                        MaPhieuTra += iMaPhieuTra.ToString();
                    }
                }
                DTO_PhieuTra phieuTra = new DTO_PhieuTra(MaPhieuTra, MaDocGia, MaThuThu, NgayTra, soLuong);
                return dalPhieuTra.InSert(phieuTra);
            }
            catch
            {
                return false;
            }
        }
    }
}
