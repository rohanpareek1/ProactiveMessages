using Microsoft.AspNetCore.Mvc;
using ProactiveTest.Data;
using ProactiveTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProactiveTest.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MockStudentRepo _repository = new MockStudentRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents();
        {
          var
        }

        [HttpGet("{id}")]
       public ActionResult<Student> GetStudentById(int id)
       {

        }
    }
}
