using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.api.Model;

namespace StudentManagement.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student(){StudentId=1,FirstName="Shrey",LastName="Gupta",Age=23,Email="shrey@gmail.com"},
            new Student(){StudentId=2,FirstName="Harsh",LastName="Gupta",Age=20,Email="harsh@gmail.com"},
            new Student(){StudentId=3,FirstName="Pandit",LastName="pandey",Age=23,Email="pandit@gmail.com"},
            new Student(){StudentId=4,FirstName="Asu",LastName="Srivastav",Age=27,Email="asu@gmail.com"},
            new Student(){StudentId=5,FirstName="Harshit",LastName="Singh",Age=23,Email="harshit@gmail.com"},
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_students);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _students.Add(student);
            return Ok(_students);
        }
    }
}
