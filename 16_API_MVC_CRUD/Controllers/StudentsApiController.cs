using _16_API_MVC_CRUD.Data;
using _16_API_MVC_CRUD.Models;
using _16_API_MVC_CRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace _16_API_MVC_CRUD.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentsApiController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsApiController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult GetALlNotes()
        {
            var students = _studentService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudents(Student student)
        {
            _studentService.Add(student);
            return Ok("Student added successfully!");
        }

        [HttpPut]
        public IActionResult UpdateStudents(Student student)
        {
            _studentService.Update(student);
            return Ok("Student Updated Successfully");
        }

        [HttpDelete]
        public IActionResult DeleteStudents(Student student)
        {
            _studentService.Delete(student);
            return Ok("Student deleted successfully");
        }
    }
}
