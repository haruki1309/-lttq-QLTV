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
        // Lay toan bo thong tin Sach
        public DataTable Get()
        {
            try
            {
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("GetFullSach", cn);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
               
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }           
        }

        // Lay thong tin Sach theo dieu kien
        public DataTable Get(string condition)
        {
            try
            {
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("GetSach_DieuKien", cn);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;

                SqlParameter p = new SqlParameter("@DieuKien", condition);
                command.Parameters.Add(p);
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Get(List<string> listCondition)
        {
            try
            {
                string Sql = "";

                if (listCondition.Count == 1)
                {
                    Sql = ", " + listCondition[0];
                }
                else
                {
                    Sql = ", " + listCondition[0] + ", ";

                    for (int i = 1; i < listCondition.Count; i++)
                    {
                        if (i == listCondition.Count - 1)
                            Sql += listCondition[i];
                        else
                            Sql += listCondition[i] + ", ";
                    }
                }
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("LocSach", cn);
                command.Parameters.AddWithValue("@DieuKienLoc", Sql);
                adapter.SelectCommand = command;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cn.Close();
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
