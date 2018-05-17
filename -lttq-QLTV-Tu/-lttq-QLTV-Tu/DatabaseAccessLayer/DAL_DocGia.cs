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

        //Lay doc gia
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
                string SQL = String.Format("select * from DocGia where " + Condition);
                SqlDataAdapter da = new SqlDataAdapter(SQL, cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Get(List<string> listProperties)
        {
            try
            {
                //string SQL = string.Format("select {0} from DocGia", listProperties);
                string sql = "select " + listProperties[0];
                for(int i = 1; i < listProperties.Count; i++)
                {
                    sql += (", " + listProperties[i]);
                }
                sql += " from DocGia";
              
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                
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
                SqlCommand cmd = new SqlCommand("SuaDocGia", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDocGia", dTO_DocGia.MaDocGia);
                cmd.Parameters.AddWithValue("@HoTen", dTO_DocGia.HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", dTO_DocGia.DiaChi);
                cmd.Parameters.AddWithValue("@CMND", dTO_DocGia.Cmnd);
                cmd.Parameters.AddWithValue("@SDT", dTO_DocGia.SoDT);
                cmd.Parameters.AddWithValue("@NgaySinh", dTO_DocGia.NgaySinh);

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
                SqlCommand cmd = new SqlCommand("XoaDocGia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
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
