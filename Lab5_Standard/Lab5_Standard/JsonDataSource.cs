using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab5_Standard
{
    public class JsonDataSource : IDataSource
    {
        public string FilePath { get; }

        public JsonDataSource(string filePath)
        {
            FilePath = filePath;
        }

        public List<Student> GetStudents()
        {
            if (!File.Exists(FilePath))
            {
                FileStream fs =  File.Create(FilePath);
                fs.Close();
            }

            using (StreamReader r = new StreamReader(FilePath))
            {
                string json = r.ReadToEnd();
                if (string.IsNullOrWhiteSpace(json))
                    return new List<Student>();
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
                return students;
            }
        }

        public void Save(List<Student> studentlist)
        {
            using (StreamWriter sw = File.CreateText(FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, studentlist);
            }

        }
    }
}
