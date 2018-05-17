using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_TinhTrang
    {

        //======== Properties =========//
        private string maTinhTrang;
        private string tenTinhTrang;

        //======== Getter/Setter =======//
        public string MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }

        public string TenTinhTrang
        {
            get { return tenTinhTrang; }
            set { tenTinhTrang = value; }
        }

        //======= Constructor ========//
        public DTO_TinhTrang()
        { }

        public DTO_TinhTrang(string ma, string ten)
        {
            this.maTinhTrang = ma;
            this.tenTinhTrang = ten;
        }
    }
}
