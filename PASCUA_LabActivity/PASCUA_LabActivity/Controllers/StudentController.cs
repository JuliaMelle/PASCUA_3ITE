using Microsoft.AspNetCore.Mvc;
using PASCUA_LabActivity.Database;
using PASCUA_LabActivity.Models;
using PASCUA_LabActivity.Services;

namespace PASCUA_LabActivity.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            
            return View(_dbContext.Student);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            //Student student = new Student();
            _dbContext.Student.Add(newStudent);
            return RedirectToAction("Index", _dbContext.Student);
        }
        //=== EDIT 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student? student = _dbContext.Student.FirstOrDefault(st=>st.Id == id);

            if(student !=null) // verify if the student exist
            return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Student studentChange)
        {
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == studentChange.Id);
            if(student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName=studentChange.LastName;
                student.Course = studentChange.Course;
                student.AdmissionDate = studentChange.AdmissionDate;    
                student.Email = studentChange.Email;

            }
            return RedirectToAction("Index", _dbContext.Student);
        }


        //==================================

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        //==================================
        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == id);
            _dbContext.Student.Remove(student);
            if (student != null)//was an student found?
                return RedirectToAction("Index", _dbContext.Student);

            return NotFound();
        }

    }
}
