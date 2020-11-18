using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvidu
{
    [Serializable]
   public class Quanly
    {
        private Dictionary<string, NhanVien> qlnv;

        public Dictionary<string, NhanVien> Qlnv { get => qlnv; set => qlnv = value; }
      
        public Quanly() {

            Qlnv = new Dictionary<string, NhanVien>();
                
        }
        public bool Insert(NhanVien nv)
        {
            if (!Qlnv.ContainsKey(nv.Manv))
            {
                Qlnv.Add(nv.Manv, nv);
                return true;
            }
               return false;
        }
      
        public bool Update(NhanVien nv)
        {
            if (Qlnv.ContainsKey(nv.Manv))
            {
                Qlnv[nv.Manv] = nv;
                return true;
            }
            else
                return false;
             
        }
    }
}
