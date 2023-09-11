using Lecture2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecture2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            var st = new Student();
            st.Id = 1;
            st.FirstName = "Gab";
            st.LastName = "Montano";
            st.Birthday = DateTime.Parse("05/01/1993");

            st.Email ="GM@gmail.com";
            st.Major = Major.BSIT;

            ViewBag.student = st;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}