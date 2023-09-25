using Microsoft.AspNetCore.Mvc;
using PASCUA_LabActivity.Models;

using PASCUA_LabActivity.Services;
namespace PASCUA_LabActivity.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }
        public IActionResult Index()
        {

            return View(_fakeData.InstructorList);
        }
        //public IActionResult Index()
        //{
            
        //    return View(_fakeData.InstructorList);
        //}
        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            //Instructor Instructor = new Instructor();
            _fakeData.InstructorList.Add(newInstructor);
            return View("Index", _fakeData.InstructorList);
        }
        //=== EDIT 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? Instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (Instructor != null) // verify if the Instructor exist
                return View(Instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor InstructorChange)
        {
            Instructor? Instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == InstructorChange.Id);
            if (Instructor != null)
            {
                Instructor.Id = InstructorChange.Id;
                Instructor.FirstName = InstructorChange.FirstName;
                Instructor.LastName = InstructorChange.LastName;
                Instructor.IsTenured = InstructorChange.IsTenured;
                Instructor.Rank = InstructorChange.Rank;
                Instructor.HiringDate = InstructorChange.HiringDate;

            }
            return View("Index", _fakeData.InstructorList);
        }


        //==================================
        public IActionResult ShowDetail(int id)
        {
            //hehe
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
            
            if (Instructor != null)//was an Instructor found?
                return View(Instructor);

            return NotFound();
        }
        //================================
        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
            _fakeData.InstructorList.Remove(instructor);
            if (instructor != null)//was an instructor found?
                return RedirectToAction("Index", _fakeData.InstructorList);

            return NotFound();
        }
    }
}
