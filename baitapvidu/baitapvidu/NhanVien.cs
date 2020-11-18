using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvidu
{
    [Serializable]
   public class NhanVien
    {
        private string manv;
        private string hoten;
        private DateTime ngaysinh;
        private string diachi;
        private string phongban;
        private string hinh;
        private string gioitinh;
        private string sodt;
        private string email;

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Phongban { get => phongban; set => phongban = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Email { get => email; set => email = value; }

        public NhanVien() { }
        
        public NhanVien(string manv, string hoten, DateTime ngaysinh, string phongban, string diachi, string email, string sdt, string gioitinh, string hinh)
        {
            this.Manv = manv;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Phongban = phongban ;
            this.Hinh = hinh;
            this.Gioitinh = gioitinh;
            this.Sodt = sdt;
            this.Email = email;
            this.Diachi = diachi;
        }
        public override string ToString()
        {
            string s = Manv + "      " + Gioitinh + "\n" +
                       Hoten + "\n" +
                       Ngaysinh + "     " +Sodt +"\n" +
                       Diachi + "\n" +
                       Phongban + "     " + Email + "\n"+
                       Hinh+"\n";
            return s;
        }

      

    }
}
