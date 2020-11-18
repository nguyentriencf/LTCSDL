using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1812866
{
   public class nhanVien
    {
        private string maNV;
        private string diachi;      
        private string sdt;
        private string ngaysinh;
        private string gioitinh;
        private string phong;
        private string hinh;
        private string email;
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }

        public string Phong
        {
            get { return phong; }
            set { phong = value; }
        }
       
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }


        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
       

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

       public nhanVien(string manv ,string tennv,string gioitinh,string diachi,string sdt ,string ngaysinh,string phong , string hinh ,string email)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.sdt = sdt;
            this.Ngaysinh = ngaysinh;
            this.Phong = phong;
            this.Hinh = hinh;
            this.Email = email;

       }
       public nhanVien() { }

       public override string ToString()
       {
           string s = "";
           s += "Ho ten :" + TenNV + '\n'
               + "Ma nhan vien: " + MaNV + '\n'
               + "Ngay sinh:" + Ngaysinh + '\n'
               + "Gioi tinh :" + Gioitinh + '\n'
               + "Dia chi :" + Diachi + '\n'
               + "Email:" + Email + '\n'
               + "SDT" + Sdt + '\n'
               + "Phong : " + Phong + '\n';
               
           return base.ToString();
       }


    }
}
