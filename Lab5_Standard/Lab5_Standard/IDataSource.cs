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
}
