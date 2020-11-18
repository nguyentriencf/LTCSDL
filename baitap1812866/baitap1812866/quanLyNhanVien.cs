using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1812866
{
   public class quanLyNhanVien
    {
        private Dictionary<string, nhanVien> listnv;

        public Dictionary<string, nhanVien> Listnv
        {
            get { return listnv; }
            set { listnv = value; }
        }
        public quanLyNhanVien() { Listnv = new Dictionary<string, nhanVien>(); }
        public bool themNhanvien(nhanVien nv)
        {
            if (!Listnv.ContainsKey(nv.MaNV))
            {
                Listnv.Add(nv.MaNV, nv);
                return true;
            }
            return false;
        }
       
       public bool updateNV(string maso,string ten,string diachi,string email, string gioitinh,string sdt,string phong,string ngaysinh)
        {
            nhanVien nv = new nhanVien();
            if(Listnv.ContainsKey(maso))
            {
                nv = Listnv[maso];
                nv.TenNV = ten;
                nv.Diachi = diachi;
                nv.Email = email;
                nv.Gioitinh = gioitinh;
                nv.Sdt = sdt;
                nv.Phong = phong;
                nv.Ngaysinh = ngaysinh;
                return true;
            }
            return false;
        }
        

    }
}
