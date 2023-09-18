using Microsoft.AspNetCore.Mvc;
using PASCUA_LabActivity.Models;


namespace PASCUA_LabActivity.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Jm",LastName = "Pascua",IsTenured=true, Rank = Rank.instructor,HiringDate = DateTime.Parse("2022-07-19"),
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Jul",LastName = "Toledo", IsTenured=true,  Rank = Rank.AssistantProfessor,HiringDate = DateTime.Parse("2022-12-05")
                }
            };
        public IActionResult Index()
        {
            
            return View(InstructorList);
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            //Instructor Instructor = new Instructor();
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
        //=== EDIT 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? Instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (Instructor != null) // verify if the Instructor exist
                return View(Instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor InstructorChange)
        {
            Instructor? Instructor = InstructorList.FirstOrDefault(st => st.Id == InstructorChange.Id);
            if (Instructor != null)
            {
                Instructor.Id = InstructorChange.Id;
                Instructor.FirstName = InstructorChange.FirstName;
                Instructor.LastName = InstructorChange.LastName;
                Instructor.IsTenured = InstructorChange.IsTenured;
                Instructor.Rank = InstructorChange.Rank;
                Instructor.HiringDate = InstructorChange.HiringDate;

            }
            return View("Index", InstructorList);
        }


        //==================================
        public IActionResult ShowDetail(int id)
        {
            //hehe
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor = InstructorList.FirstOrDefault(st => st.Id == id);
            
            if (Instructor != null)//was an Instructor found?
                return View(Instructor);

            return NotFound();
        }

    }
}
