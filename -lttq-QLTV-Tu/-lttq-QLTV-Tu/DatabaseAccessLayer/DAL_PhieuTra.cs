using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;

namespace DatabaseAccessLayer
{
    public class DAL_PhieuTra:DBConnect
    {
        public DataTable GetFull()
        {
            try
            {
                SqlCommand cm = new SqlCommand("GetFullPhieuTra", cn);
                cm.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get()
        {
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuTra", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        public bool InSert(DTO_PhieuTra phieuTra)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("ThemPhieuTra", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaPhieuTra", phieuTra.MaPhieuTra);
                cm.Parameters.AddWithValue("@MaThuThu", phieuTra.MaThuThu);
                cm.Parameters.AddWithValue("@MaDocGia", phieuTra.MaDocGia);
                cm.Parameters.AddWithValue("@NgayTra", Convert.ToDateTime(phieuTra.NgayTra.ToString("dd/MM/yyyy").Substring(0, 10)));
                cm.Parameters.AddWithValue("@SoLuong", phieuTra.SoLuong);

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
