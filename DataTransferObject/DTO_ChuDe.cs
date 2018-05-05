using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class DTO_ChuDe
    {
        //======== Properties =========//
        private string maChuDe;
        private string tenChuDe;

        //======== Getter/Setter =======//
        public string MaChuDe
        {
            get { return maChuDe; }
            set { maChuDe = value; }
        }

        public string TenChuDe
        {
            get { return tenChuDe; }
            set { tenChuDe = value; }
        }

        //======= Constructor ========//
        public DTO_ChuDe()
        { }

        public DTO_ChuDe(string ma, string ten)
        {
            this.maChuDe = ma;
            this.tenChuDe = ten;
        }
    }
}
