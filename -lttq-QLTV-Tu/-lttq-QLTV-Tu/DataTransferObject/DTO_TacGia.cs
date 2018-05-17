using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    partial class DTO_TacGia
    {
        //====== Properties ======//
        private string maTacGia;
        private string hoTen;
        private int namSinh;
        private int namMat;

        //====== Getter/Setter =======//
        public string MaTacGia
        {
            get { return maTacGia; }
            set { maTacGia = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        
        public int NamMat
        {
            get { return namMat; }
            set { namMat = value; }
        }

        //======== Constructor =======//
        public DTO_TacGia()
        { }

        // Tác giả không rõ năm sinh, năm mất
        public DTO_TacGia(string maTG, string hoTenTG)
        {            
            this.maTacGia = maTG;
            this.hoTen = hoTenTG;
        }

        // Tác giả không rõ năm mất
        public DTO_TacGia(string maTG, string hoTenTG, int nam)
        {
            this.maTacGia = maTG;
            this.hoTen = hoTenTG;
            this.namSinh = nam;
        }

        // Tác giả có đủ thông tin
        public DTO_TacGia(string maTG, string hoTenTG, int namSinh, int namMat)
        {
            this.maTacGia = maTG;
            this.hoTen = hoTenTG;
            this.namSinh = namSinh;
            this.namMat = namMat;
        }
    }
}
