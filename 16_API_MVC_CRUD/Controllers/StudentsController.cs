using _16_API_MVC_CRUD.Models;
using _16_API_MVC_CRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace _16_API_MVC_CRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            _studentService.Add(student);
            return RedirectToAction("ListStudent");
        }
        public IActionResult UpdateStudent(int id)
        {
            var students = _studentService.GetById(id);
            return View(students);
        }

        [HttpPost,ActionName("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            if(!ModelState.IsValid)
            {
                return View(student);
            }
            _studentService.Update(student);
            return RedirectToAction("ListStudent");
        }
        public IActionResult DeleteStudent(int id)
        {
            var students = _studentService.GetById(id);
            return View(students);
        }
        [HttpPost, ActionName("DeleteStudent")]
        public IActionResult DeleteStudent(Student student)
        {
            _studentService.Delete(student);
            return RedirectToAction("ListStudent");
        }
        public IActionResult ListStudent()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
    }
}
