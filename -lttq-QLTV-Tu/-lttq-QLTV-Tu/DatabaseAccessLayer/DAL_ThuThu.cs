using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DatabaseAccessLayer
{
    public class DAL_ThuThu: DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ThuThu", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Login(string MaThuThu, string MatKhau)
        {
            try
            {
                cn.Open();
                string SQL = String.Format("select * from ThuThu where MaThuThu='{0}' and Pass='{1}'", MaThuThu, MatKhau);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataReader dtr = cmd.ExecuteReader();
                if(dtr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                
            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        DataTable dt = new DataTable();
        //Them
        public bool Insert(DTO_ThuThu dTO_ThuThu)
        {
            try
            {
                cn.Open();
                string SQL = string.Format("INSERT INTO ThuThu VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", dTO_ThuThu.MaThuThu, dTO_ThuThu.HoTen, dTO_ThuThu.DiaChi, dTO_ThuThu.SoDT, dTO_ThuThu.CMND, dTO_ThuThu.Email, dTO_ThuThu.NgayVL, dTO_ThuThu.Password);
                SqlCommand cmd = new SqlCommand(SQL, cn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
               
            }
            finally
            {
                cn.Close();
            }
            return false;
        }
        //Sua
        public bool Update(DTO_ThuThu dTO_ThuThu)
        {
            try
            {
                cn.Open();
                string SQL = string.Format("UPDATE ThuThu SET HoTen = '{0}', DiaChi = '{1}', SDT = '{2}', CMND = '{3}', EMAIL = '{4}', NgayVL = '{5}', Pass = '{6}' WHERE MaThuThu = '{7}'", dTO_ThuThu.HoTen, dTO_ThuThu.DiaChi, dTO_ThuThu.SoDT, dTO_ThuThu.CMND, dTO_ThuThu.Email, dTO_ThuThu.NgayVL, dTO_ThuThu.Password, dTO_ThuThu.MaThuThu);
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
        public bool Delete(string MaThuThu)
        {
            try
            {
                cn.Open();
                string SQL = string.Format("DELETE FROM ThuThu WHERE MaThuThu = {0}", MaThuThu);
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

    }
}
