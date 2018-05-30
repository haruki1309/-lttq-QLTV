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
    public class DAL_CTPT : DBConnect
    {
        public bool InSert(DTO_CTPT ctpt)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("ThemCTPT", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaPhieuTra", ctpt.MaPhieuTra);
                cm.Parameters.AddWithValue("@MaSach", ctpt.MaSach);
                cm.Parameters.AddWithValue("@MaTinhTrang", ctpt.MaTinhTrang);


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
