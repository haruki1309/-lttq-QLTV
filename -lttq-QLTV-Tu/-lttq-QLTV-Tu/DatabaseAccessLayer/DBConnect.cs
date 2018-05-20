using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer
{
    public class DBConnect
    {
        protected SqlConnection cn = new SqlConnection("Data Source=DESKTOP-IDE56EU\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
    }
}
