using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1812860_lab05_NguyenDinhPhatTrien
{
     public class SinhVien
    {
        private string mSSV;
        private string hoTenLot;
        private string ten;
        DateTime ngaySinh;
        private string soCMND;
        private bool gioiTinh;
        private string lop;
        private string sDT;
        private string diaChiLienLac;
        private List<string> dangKyMH;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string HoTenLot { get => hoTenLot; set => hoTenLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChiLienLac { get => diaChiLienLac; set => diaChiLienLac = value; }
        public List<string> DangKyMH { get => dangKyMH; set => dangKyMH = value; }

        public SinhVien()
        {
            dangKyMH = new List<string>( );
        }
        public SinhVien(string mssv, string hotenlot, string ten, DateTime ngaysinh, string cmnd, bool gt, string lop, string sdt, string diachi, List<string> mh)
        {
            this.MSSV = mssv;
            this.HoTenLot = hotenlot;
            this.Ten = ten;
            this.NgaySinh = ngaysinh;
            this.SoCMND = cmnd;
            this.GioiTinh = gt;
            this.Lop = lop;
            this.SDT = sdt;
            this.DiaChiLienLac = diachi;
            this.DangKyMH = mh;       
        }
    }
}
