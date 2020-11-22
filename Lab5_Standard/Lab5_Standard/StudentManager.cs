using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Standard
{
    public interface IDataSource
    {
        string FilePath { get; }
        List<Student> GetStudents();
        void Save(List<Student> studentlist);
    }
    public class StudentManager
    {
        private readonly IDataSource _dataSource;
        private readonly List<Student> _studentList;

        public StudentManager(IDataSource dataSource)
        {
            _dataSource = dataSource;
            _studentList = _dataSource.GetStudents();
        }

        // lấy DS sinh viên
        public List<Student> GetALLStudents()
        {
            return _studentList;
        }
        
        public void AddStudent(Student student)
        {
            if (student is null)
                throw new ArgumentException($"sinh viên không hợp lệ");
            var isExist = _studentList.Exists(SV => SV.MSSV == student.MSSV);
            if (isExist)
                throw new ArgumentException($"Sinh viên có mã số {student.MSSV} đã tồn tại");

            _studentList.Add(student);
            _dataSource.Save(_studentList);
            
        }
        public void DelByID(string MSSV)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Mã số sinh viên không hợp lệ");

            var student = _studentList.Find(st => st.MSSV == MSSV);
            if (student is null)
                throw new ArgumentException($"{MSSV} không hợp lệ!");
            _studentList.Remove(student);
            _dataSource.Save(_studentList);
        }

        public void UpdateByID(string mssv, Student studentUpdate)
        {
            if (string.IsNullOrWhiteSpace(mssv))
                throw new ArgumentException($"MÃ sinh viên không hợp lệ");

            var isExist = _studentList.Exists(SV=> SV.MSSV == mssv);
            if (!isExist)
                throw new ArgumentException($"không tồn tại SV có {mssv}");

            var index = _studentList.FindIndex(SV=> SV.MSSV == mssv);
            _studentList[index] = studentUpdate;

            _dataSource.Save(_studentList);

        }
    }
}
