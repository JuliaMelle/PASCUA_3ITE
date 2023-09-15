using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using PASCUA_MP1.Models;


namespace PASCUA_MP1.Controllers
{


  

    public class HomeController : Controller
    {
   
        List<Employee> EmployeeList = new List<Employee>
            {
                new Employee()
                {
                    Id= 1,FirstName = "Gabriel ",LastName = "Montano", Email = "gdmontanoust.edu.ph" , IsTenured=true,
                },
                new Employee()
                {
                      Id= 2,FirstName = "Zyx ",LastName = "Montano", Email = "gdmontanoust.edu.ph",IsTenured=false
                }
            };

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(EmployeeList) ;
        }
        public ActionResult Privacy()
        {
            return View();
        }
        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
