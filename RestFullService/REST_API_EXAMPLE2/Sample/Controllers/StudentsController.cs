using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    [Route("api/stud")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        List<Student> OStudents = new List<Student>() {
        new Student(){ID=1,Name="Aditya",Roll=1001},
         new Student(){ID=2,Name="Papu",Roll=1002},
          new Student(){ID=3,Name="Sonu",Roll=1003},
           new Student(){ID=4,Name="Bunty",Roll=1004},
            new Student(){ID=5,Name="Chotu",Roll=1005}

        };
        [HttpGet]
        public IActionResult Gets()
        {
            if (OStudents.Count == null)
            {
                return NotFound("No Item found in the list");
            }
            return Ok(OStudents);

        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var OStudent = OStudents.SingleOrDefault(x => x.ID == id);
            if(OStudent==null)
            {
               return NotFound("No student Found.");
            }
            return Ok(OStudents);
        }

        [HttpPost]
        public IActionResult save(Student OStudent)
        {
            OStudents.Add(OStudent);
            if(OStudents.Count == 0)
            {
                return NotFound("No student Found.");
            }
            return Ok(OStudents);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var OStudent = OStudents.SingleOrDefault(x=>x.ID==id);
            if (OStudent == null)
            {
                return NotFound("No student Found.");
            }
            OStudents.Remove(OStudent);
            if (OStudents.Count == 0)
            {
                return NotFound("No student Found.");
            }
            return Ok(OStudents);
        }
    }
}