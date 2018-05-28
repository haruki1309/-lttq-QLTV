using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using System.Windows;
using System.Windows.Forms;

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


        //============================================
        //lay Sach theo thuoc tinh
        //EDIT: t sửa hàm này xí, nó dùng để lấy DS sách nên không thể thêm code phần lọc vào
        // => đã thay thế bằng hàm DataTable Filt(List<string> listCondition);

        public DataTable Get(List<string> listCondition)
        {
            try
            {
                //string SQL = string.Format("select {0} from DocGia", listProperties);
                string sql = "select " + listCondition[0];
                for (int i = 1; i < listCondition.Count; i++)
                {
                    sql += (", " + listCondition[i]);
                }
                sql += " from Sach";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Get(List<string> listProps, string condition)
        {
            try
            {
                string sql = "select " + listProps[0];
                for (int i = 1; i < listProps.Count; i++)
                {
                    sql += (", " + listProps[i]);
                }
                sql += " from Sach";

                sql += (" where " + condition);

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
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

        public DataTable Filt(List<string> listCondition)
        {
            try
            {
                string condition = "A.MaSach, A.TenSach";

                if (listCondition.Count == 1)
                {
                    condition += (", " + listCondition[0]);
                }
                else if (listCondition.Count > 1)
                {
                    condition += (", " + listCondition[0] + ", ");

                    for (int i = 1; i < listCondition.Count; i++)
                    {
                        if (i == listCondition.Count - 1)
                            condition += listCondition[i];
                        else
                            condition += listCondition[i] + ", ";
                    }
                }

                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("LocSach", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DieuKienLoc", condition);
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

                cm.Parameters.AddWithValue("@TenSach", dtoSach.TenSach);
                cm.Parameters.AddWithValue("@TenTacGia", dtoSach.MaTacGia);
                cm.Parameters.AddWithValue("@NamXB", dtoSach.NamXB);
                cm.Parameters.AddWithValue("@TenNXB", dtoSach.MaNXB);
                cm.Parameters.AddWithValue("@TenNhaPhatHanh", dtoSach.MaNhaPhatHanh);
                cm.Parameters.AddWithValue("@NgayNhap", dtoSach.NgayNhap);
                cm.Parameters.AddWithValue("@TenChuDe", dtoSach.MaChuDe);
                cm.Parameters.AddWithValue("@TenTheLoai", dtoSach.MaTheLoai);
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
                cm.Parameters.AddWithValue("@TenSach", dtoSach.TenSach);
                cm.Parameters.AddWithValue("@TenTacGia", dtoSach.MaTacGia);
                cm.Parameters.AddWithValue("@NamXB", dtoSach.NamXB);
                cm.Parameters.AddWithValue("@TenNXB", dtoSach.MaNXB);
                cm.Parameters.AddWithValue("@TenNhaPhatHanh", dtoSach.MaNhaPhatHanh);
                cm.Parameters.AddWithValue("@NgayNhap", dtoSach.NgayNhap);
                cm.Parameters.AddWithValue("@TenChuDe", dtoSach.MaChuDe);
                cm.Parameters.AddWithValue("@TenTheLoai", dtoSach.MaTheLoai);
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
        public bool UpdateSoLuong(string maSach, int soLuong)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("CapNhatSoLuongSach", cn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@MaSach", maSach);
                cm.Parameters.AddWithValue("@SoLuong", soLuong);

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


        public List<string> AutoCompleteTextBox(string columnName, string tableName)
        {
            try
            {
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("AutoCompleteText", cn);
                command.CommandType = CommandType.StoredProcedure;
                //adapter.SelectCommand = command;

                command.Parameters.AddWithValue("@TenCot", columnName);
                command.Parameters.AddWithValue("@TenBang", tableName);

                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                List<string> completeStringSource = new List<string>();

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        string col = string.Format("{0}", columnName);
                        completeStringSource.Add(reader[col].ToString());
                    }
                }
                else
                    completeStringSource.Add("");
                
                cn.Close();

                return completeStringSource;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public List<string> GetDataComboBox(string columnName, string tableName)
        {
            try
            {
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("LayDuLieuComboBox", cn);
                command.CommandType = CommandType.StoredProcedure;
                //adapter.SelectCommand = command;

                command.Parameters.AddWithValue("@TenCot", columnName);
                command.Parameters.AddWithValue("@TenBang", tableName);

                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                List<string> comboBoxSource = new List<string>();

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        string col = string.Format("{0}", columnName);
                        comboBoxSource.Add(reader[col].ToString());
                    }
                }
                else
                    comboBoxSource.Add("Khác...");

                cn.Close();

                return comboBoxSource;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
