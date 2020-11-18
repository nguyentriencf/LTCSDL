using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baitapvidu;

using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace baitapvidu.io
{
    public class FileFactory
    {
        public static bool Savefile(Dictionary<string,NhanVien> Qlnv,string path)
        {
            try
            {
                FileStream fs = new FileStream(path ,FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Qlnv);
                fs.Close();
                return true;

            }
            catch (Exception ex)
            {

                throw(ex);
            }

        }

        public static Dictionary<string, NhanVien> readfile (string path)
        {
            Dictionary<string, NhanVien> Qlnv = new Dictionary<string, NhanVien>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data= bf.Deserialize(fs);
                Qlnv = data as Dictionary<string, NhanVien>;
                
                fs.Close();
                return Qlnv;

            }
            catch (Exception ex)
            {

                throw(ex);
            }
        }
    }

}
