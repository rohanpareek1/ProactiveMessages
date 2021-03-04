using ProactiveTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProactiveTest.Data
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAppStudents();
        Student GetStudentById(int id);
    }
}
