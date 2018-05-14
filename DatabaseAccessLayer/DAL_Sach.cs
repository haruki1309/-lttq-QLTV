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
    public class DAL_Sach: DBConnect
    {
        public DataTable Get()
        {
            try
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand cm = new SqlCommand("GetFullSach", cn);
                cm.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cm;
               
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

        public DataTable Get(string condition)
        {
            try
            {
                cn.Open();

                string SQL = String.Format("Select * From Sach Where {0}", condition);
                SqlDataAdapter da = new SqlDataAdapter(SQL, cn);

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

        public bool Insert(DTO_Sach dtoSach)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("ThemSach", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaSach", dtoSach.MaSach);
                cm.Parameters.AddWithValue("TenSach", dtoSach.TenSach);
                cm.Parameters.AddWithValue("@MaTacGia", dtoSach.MaTacGia);
                cm.Parameters.AddWithValue("@NamXB", dtoSach.NamXB);
                cm.Parameters.AddWithValue("@MaNXB", dtoSach.MaNXB);
                cm.Parameters.AddWithValue("@MaNhaPhatHanh", dtoSach.MaNhaPhatHanh);
                cm.Parameters.AddWithValue("@NgayNhap", dtoSach.NgayNhap);
                cm.Parameters.AddWithValue("@MaChuDe", dtoSach.MaChuDe);
                cm.Parameters.AddWithValue("@MaTheLoai", dtoSach.MaTheLoai);
                cm.Parameters.AddWithValue("@GiaTri", dtoSach.GiaTri);
                cm.Parameters.AddWithValue("@SoLuong", dtoSach.SoLuong);

                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception)
            {
                
            }
            finally
            {
                cn.Close();
            }

            return false;
        }

        public bool Update(DTO_Sach dtoSach)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("CapNhatSach", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaSach", dtoSach.MaSach);
                cm.Parameters.AddWithValue("TenSach", dtoSach.TenSach);
                cm.Parameters.AddWithValue("@MaTacGia", dtoSach.MaTacGia);
                cm.Parameters.AddWithValue("@NamXB", dtoSach.NamXB);
                cm.Parameters.AddWithValue("@MaNXB", dtoSach.MaNXB);
                cm.Parameters.AddWithValue("@MaNhaPhatHanh", dtoSach.MaNhaPhatHanh);
                cm.Parameters.AddWithValue("@NgayNhap", dtoSach.NgayNhap);
                cm.Parameters.AddWithValue("@MaChuDe", dtoSach.MaChuDe);
                cm.Parameters.AddWithValue("@MaTheLoai", dtoSach.MaTheLoai);
                cm.Parameters.AddWithValue("@GiaTri", dtoSach.GiaTri);
                cm.Parameters.AddWithValue("@SoLuong", dtoSach.SoLuong);

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

        public bool Delete(string maSach)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("XoaSach", cn);
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@MaSach", maSach);

                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception)
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
