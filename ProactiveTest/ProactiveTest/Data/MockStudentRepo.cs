using ProactiveTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProactiveTest.Data
{
    public class MockStudentRepo : IStudentRepo
    {
        public IEnumerable<Student> GetAppStudents()
        {
            var students = List<Student>
                {
                  new Student(Id = 0, Name = "Rohan");
                  new Student(Id = 1, Name = "Sam");
                new Student(Id = 2, Name = "Ram");
            }
            return students;
        }

        public Student GetStudentById(int id)
        {
            return new Student(Id = 0, Name = "Rohan");
        }
    }
}
