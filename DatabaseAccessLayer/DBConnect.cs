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
        protected SqlConnection cn = new SqlConnection("Data Source=DESKTOP-76JI7SV;Initial Catalog=QuanLyThuVien;Integrated Security=True");
    }
}
