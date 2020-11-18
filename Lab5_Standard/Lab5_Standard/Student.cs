using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Standard
{
    public class Student
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten{ get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public  bool GioiTinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public List<string> DangKyMH { get; set; }
        public Student()
        {
            DangKyMH = new List<string>();
        }
        public Student(string mssv, string hotenlot, string ten, DateTime ngaysinh, string cmnd, bool gt, string lop, string sdt, string diachi, List<string> mh)
        {
            this.MSSV = mssv;
            this.HoVaTenLot = hotenlot;
            this.Ten = ten;
            this.NgaySinh = ngaysinh;
            this.CMND = cmnd;
            this.GioiTinh = gt;
            this.Lop = lop;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.DangKyMH = mh;
        }
    }
}
