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
    public class DAL_PhieuMuon : DBConnect
    {
        public DataTable Get()
        {
            try
            {
                cn.Open();

                SqlCommand command = new SqlCommand("GetFullPhieuMuon", cn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Close();

                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool InSert(DTO_PhieuMuon phieuMuon)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("ThemPhieuMuon", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaThuThu", phieuMuon.MaThuThu);
                cm.Parameters.AddWithValue("@MaDocGia", phieuMuon.MaDocGia);
                cm.Parameters.AddWithValue("@NgayMuon", phieuMuon.NgayMuon);
                cm.Parameters.AddWithValue("@SoLuong", phieuMuon.SoLuong);

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
