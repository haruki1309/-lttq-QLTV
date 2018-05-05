using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_TheLoai
    {
        //======== Properties =========//
        private string maTheLoai;
        private string tenTheLoai;

        //======== Getter/Setter =======//
        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }

        public string TenTheLoai
        {
            get { return tenTheLoai; }
            set { tenTheLoai = value; }
        }

        //======= Constructor ========//
        public DTO_TheLoai()
        { }

        public DTO_TheLoai(string ma, string ten)
        {
            this.maTheLoai = ma;
            this.tenTheLoai = ten;
        }
    }
}

