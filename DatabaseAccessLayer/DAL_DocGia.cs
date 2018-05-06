using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DatabaseAccessLayer
{
    public class DAL_DocGia: DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DocGia", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get(string Condition)
        {
            try
            {
                string SQL = String.Format("select * from DocGia where {0}", Condition);
                SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        DataTable dt = new DataTable();
        //Them
        public bool Insert(DTO_DocGia dTO_DocGia)
        {
            try
            {
                cn.Open();
                //string SQL = string.Format("INSERT INTO ThuThu VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}', {5}, {6})", dTO_DocGia.MaDocGia, dTO_DocGia.HoTen, dTO_DocGia.DiaChi, dTO_DocGia.SoDT, dTO_DocGia.Cmnd, dTO_DocGia.NgaySinh.ToString(), dTO_DocGia.NgayDK.ToString());
                SqlCommand cmd = new SqlCommand("ThemDocGia", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDocGia", dTO_DocGia.MaDocGia);
                cmd.Parameters.AddWithValue("@HoTen", dTO_DocGia.HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", dTO_DocGia.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", dTO_DocGia.SoDT);
                cmd.Parameters.AddWithValue("@CMND", dTO_DocGia.Cmnd);
                cmd.Parameters.AddWithValue("@NgaySinh", dTO_DocGia.NgaySinh);
                cmd.Parameters.AddWithValue("@NgayDK", dTO_DocGia.NgayDK);
                

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //Sua
        public bool Update(DTO_DocGia dTO_DocGia)
        {
            try
            {
                cn.Open();
                string SQL = string.Format("UPDATE ThuThu SET HoTen = '{0}', DiaChi = '{1}', SDT = '{2}', CMND = '{3}', NgaySinh = '{4}', NgayDK = '{5}' WHERE MaDocGia = '{6}'", dTO_DocGia.HoTen, dTO_DocGia.DiaChi, dTO_DocGia.SoDT, dTO_DocGia.Cmnd, dTO_DocGia.NgaySinh, dTO_DocGia.NgayDK, dTO_DocGia.MaDocGia);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //Xoa
        public bool Delete(string MaDocGia)
        {
            try
            {
                cn.Open();
                string SQL = string.Format("DELETE FROM DocGia WHERE MaDocGia = {0}", MaDocGia);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                cn.Close();
            }
            return false;
        }

     
        public int CountRow()
        {
            try
            {
                cn.Open();
                string SQL = "select count(*) from DocGia";
                SqlCommand sCmd = new SqlCommand(SQL, cn);
                

                return (int)sCmd.ExecuteScalar();
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                cn.Close();
            }
            return 0;
        }
    }
}
