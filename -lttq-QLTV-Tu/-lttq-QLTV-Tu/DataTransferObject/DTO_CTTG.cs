using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    partial class DTO_CTTG
    {
        //====== Properties ======//
        private string maTacGia;
        private string butDanh;
        private int namSuDung; //Năm bắt đầu sử dụng

        //====== Getter/Setter =======//
        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

        public string ButDanh
        {
            get { return butDanh; }
            set { butDanh = value; }
        }

        public int NamSuDung
        {
            get { return namSuDung; }
            set { namSuDung = value; }
        }

        //======= Constructor =======//
        public DTO_CTTG()
        { }

        //=== Không biết rõ bút danh được sử dụng từ năm nào
        public DTO_CTTG(string maTG, string butDanh)
        {            
            this.maTacGia = maTG;
            this.butDanh = butDanh;
        }

        //=== Biết rõ bút danh được sử dụng từ năm nào
        public DTO_CTTG(string maTG, string butDanh, int namSD)
        {
            this.maTacGia = maTG;
            this.butDanh = butDanh;
            this.namSuDung = namSD;
        }
    }
}
