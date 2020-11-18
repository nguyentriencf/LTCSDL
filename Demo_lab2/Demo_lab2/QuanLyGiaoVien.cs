using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_lab2
{
   public class QuanLyGiaoVien
    {
        public QuanLyGiaoVien() { }
        Dictionary<string, GiaoVien> qlgv = new Dictionary<string, GiaoVien>();
        
        public bool Themgv(GiaoVien gv)
        {
            if (!qlgv.ContainsKey(gv.MaSo))
            {
                
                qlgv.Add(gv.MaSo, gv);

                gv.ToString();
                return true;
            }
            return false;
           
        }
        public GiaoVien TimMaso(string maso)
        {
            GiaoVien gv = new GiaoVien();
         
            if (qlgv.ContainsKey(maso))
              
                gv= qlgv[maso];
            return gv;
            
          
            
            return null;
            
            
        }
       
    }
}
