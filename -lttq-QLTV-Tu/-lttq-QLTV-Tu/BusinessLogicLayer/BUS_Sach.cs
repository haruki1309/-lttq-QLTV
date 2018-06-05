using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using DatabaseAccessLayer;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    public class BUS_Sach
    {
        DAL_Sach dalSach = new DAL_Sach();

        public DataTable getSach()
        {
            return dalSach.Get();
        }

        public DataTable getSach(string condition)
        {
            return dalSach.Get(condition);
        }
        
        public DataTable getSach(List<string> listCondition)
        {
            return dalSach.Get(listCondition);
        }

        public DataTable getSach(List<string> listProperties, string condition)
        {
            return dalSach.Get(listProperties, condition);
        }
        public DataTable LocSach(List<string> listCondition)
        {
            return dalSach.Filt(listCondition);
        }
        // Nhớ kiểm tra điều kiện Insert
        public bool insertSach(string maSach, string tenSach, string maTacGia, int namXB, string maNXB, string maNhaPhatHanh, DateTime ngayNhap, string maChuDe, string maTheLoai, double giaTri, int soLuong)
        {
            DTO_Sach dtoSach = new DTO_Sach(maSach, tenSach, maTacGia, namXB, maNXB, maNhaPhatHanh, ngayNhap, maChuDe, maTheLoai, giaTri, soLuong);

            return dalSach.Insert(dtoSach);
        }

        // Nhớ kiểm tra điều kiện Update
        public bool updateSach(string maSach, string tenSach, string maTacGia, int namXB, string maNXB, string maNhaPhatHanh, DateTime ngayNhap, string maChuDe, string maTheLoai, double giaTri, int soLuong)
        {
            DTO_Sach dtoSach = new DTO_Sach(maSach, tenSach, maTacGia, namXB, maNXB, maNhaPhatHanh, ngayNhap, maChuDe, maTheLoai, giaTri, soLuong);

            return dalSach.Update(dtoSach);
        }

        public bool updateSoluongSach(string maSach, int soLuong)
        {
            return dalSach.UpdateSoLuong(maSach, soLuong);
        }

        // Nhớ kiểm tra điều kiện Delete
        public bool deleteSach(string maSach)
        {
            return dalSach.Delete(maSach);
        }
       

        public List<string> getDataComboBox(string columnName, string tableName)
        {
            return dalSach.GetDataComboBox(columnName, tableName);
        }

        public bool insertTable(string parameterValue, string parameterName, string procedureName)
        {
            return dalSach.Insert(parameterValue, parameterName, procedureName);
        }
    }
}
