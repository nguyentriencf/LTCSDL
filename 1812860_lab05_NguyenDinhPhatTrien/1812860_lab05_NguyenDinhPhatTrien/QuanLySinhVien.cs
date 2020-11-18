using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace _1812860_lab05_NguyenDinhPhatTrien
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien kq = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    kq = sv;
                    break;
                }
            return kq;                           
        }

        public void them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public void xoa(object sv, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= DanhSach.Count; i++)
                if (ss(this[i], sv) == 0)
                    DanhSach.RemoveAt(i);
        }
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i <= count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void Ghifile()
        {
            string path = "DanhSachSV.txt";
            //SinhVien sv = new SinhVien();
           // SinhVien sv;      
            try
            {
                StreamWriter wr = new StreamWriter(path, false, Encoding.UTF8);
                foreach (SinhVien item in DanhSach)
                {
                    string dsmh = null;
                    foreach (var mh in item.DangKyMH)
                    {
                        dsmh += mh+ ",";
                    }
                    int gt = 1;
                    if (item.GioiTinh == false)
                        gt = 0;
                   
                    string newCN = dsmh.Substring(0, dsmh.LastIndexOf(','));
                    string line = item.MSSV + "*" + item.HoTenLot + "*" + item.Ten + "*" + item.NgaySinh.ToString("dd/MM/yyyy") + "*" +
                        item.SoCMND + "*" + gt +"*"+ item.Lop+"*" + item.SDT + "*" + item.DiaChiLienLac +"*" + newCN;
                    wr.WriteLine(line);
                }
                wr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        public void Doctufile()
        {
            string path = "DanhSachSV.txt";
            string line;
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            try
            {
                
                while ((line = sr.ReadLine()) != null)
                {
                    
                    SinhVien sv = new SinhVien();
                    string[] arrline = line.Split('*');
                    sv.MSSV = arrline[0];
                    sv.HoTenLot = arrline[1];
                    sv.Ten = arrline[2];
                    sv.NgaySinh = DateTime.Parse(arrline[3]);
                    sv.SoCMND = arrline[4];         

                    if (arrline[5] == "0")
                        sv.GioiTinh = false;
                    else
                        sv.GioiTinh = true;

                    sv.Lop = arrline[6];
                    sv.SDT = arrline[7];
                    sv.DiaChiLienLac = arrline[8];
                    foreach (var item in arrline[9].Split(','))
                        sv.DangKyMH.Add(item);
                    them(sv);               
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
