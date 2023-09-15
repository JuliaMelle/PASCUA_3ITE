using Microsoft.AspNetCore.Mvc;
using PASCUA_MP1.Models;


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
