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
                string SQL = string.Format("INSERT INTO ThuThu VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", dTO_DocGia.MaDocGia, dTO_DocGia.HoTen, dTO_DocGia.DiaChi, dTO_DocGia.SoDT, dTO_DocGia.Cmnd, dTO_DocGia.NgaySinh, dTO_DocGia.NgayDK);
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

        // bug cho nay
    //    public int CountRow()
    //    {
    //        try
    //        {
    //            cn.Open();
                
    //            SqlCommand cmd = cn.CreateCommand();
    //            DbDataReader reader = cmd.ExecuteReader();
    //            reader.getV
    //            if (cmd.ExecuteNonQuery() > 0)
    //            {
    //                return true;
    //            }
    //        }
    //        catch (Exception e)
    //        {

    //        }
    //        finally
    //        {
    //            cn.Close();
    //        }
    //        return false;
    //    }
    }
}
