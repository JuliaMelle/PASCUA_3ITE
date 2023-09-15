using Microsoft.AspNetCore.Mvc;
using PASCUA_MP1.Models;
using System.Diagnostics;

namespace PASCUA_MP1.Controllers
{
    public class HomeController_dati : Controller
    {
        private readonly ILogger<HomeController_dati> _logger;

        public HomeController_dati(ILogger<HomeController_dati> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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