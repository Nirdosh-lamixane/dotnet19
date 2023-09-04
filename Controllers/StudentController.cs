using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student
            {
                StdID = 5,
                Name = "Nirdosh",
                Address = "Balkot",
                Faculty = "CSIT"
            };
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }


            return RedirectToAction("Details", new { id = student.StdID });
        }

        public IActionResult Details(int id)
        {
            var student = new Student
            {
                StdID = id,
                Name = "Nirdosh",
                Address = "lamichhane",
                Faculty = "CSIT"
            };

            return View(student);
        }
    }
}
