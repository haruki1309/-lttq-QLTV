using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DatabaseAccessLayer
{
    public class DAL_CTPM : DBConnect
    {
        public bool InSert(DTO_CTPM ctpm)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("ThemCTPM", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaPhieuMuon", ctpm.MaPhieuMuon);
                cm.Parameters.AddWithValue("@MaSach", ctpm.MaSach);
                

                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }

            return false;
        }
    }
}
