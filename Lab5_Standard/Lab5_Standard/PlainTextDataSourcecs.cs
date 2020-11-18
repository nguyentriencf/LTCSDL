using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Lab5_Standard
{
    public class PlainTextDataSourcecs : IDataSource
    {
        public string FilePath { get; }

        public PlainTextDataSourcecs(string filePath)
        {
            FilePath = filePath;
        }

        List<Student> studentList = new List<Student>();
        public List<Student> GetStudents()
        {
            string line;

            if (!File.Exists(FilePath))
            {
                FileStream fs = File.Create(FilePath);
                fs.Close();
            }
            using (StreamReader streamReader = new StreamReader(new FileStream(FilePath, FileMode.Open)))
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var sv = ParseLine(line);
                        studentList.Add(sv);
                    }
                }
            return studentList;
        }
       public void Save(List<Student> studentlist)
        {
            if (studentlist.Count >0)
            {
                using (var stream = new FileStream(FilePath,FileMode.Create, FileAccess.Write))
                {
                    using (var streamWriter = new StreamWriter(stream))
                    {
                        foreach (var student in studentlist)
                        {
                            streamWriter.WriteLine(FormatStudent(student));
                        }           
                    }
                }
            }
        }

        private Student ParseLine(string line)
        {
            var parts = line.Split('|');
            var dangKyMH = parts[(int) ColumIndex.DangKyMh].Split('^').ToList();

            return new Student()
            {
                MSSV = parts[(int)ColumIndex.MSSV],
                HoVaTenLot = parts[(int)ColumIndex.HoVaTenLot],
                Ten = parts[(int)ColumIndex.Ten],
                NgaySinh = DateTime.Parse(parts[(int)ColumIndex.NgaySinh]),
                CMND = parts[(int)ColumIndex.CMND],
                GioiTinh = bool.Parse(parts[(int)ColumIndex.GioiTinh]),
                Lop = parts[(int)ColumIndex.Lop],
                SDT = parts[(int)ColumIndex.SDT],
                DiaChi = parts[(int)ColumIndex.DiaChi],
                DangKyMH = dangKyMH             
            };

        }
        private string FormatStudent(Student student)
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}",
                student.MSSV,
                student.HoVaTenLot,
                student.Ten,
                student.NgaySinh,
                student.CMND,
                student.GioiTinh,
                student.Lop,
                student.SDT,
                student.DiaChi,
                string.Join("^", student.DangKyMH )
                );
           
        }
        private enum ColumIndex
        {
            MSSV,
            HoVaTenLot,
            Ten,
            NgaySinh,
            CMND,
            GioiTinh,
            Lop,
            SDT,
            DiaChi,
            DangKyMh
        }
        //public bool ReadfileJson(string path)
        //{
        //    try
        //    {
        //        string data;
        //        using (var streamReader = new StreamReader(new FileStream(path, FileMode.Open)))
        //        {
        //            data = streamReader.ReadToEnd();
        //        }
        //        studentList = JsonConvert.DeserializeObject<List<Student>>(data);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
