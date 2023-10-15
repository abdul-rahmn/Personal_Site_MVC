using Microsoft.AspNetCore.Mvc;
using PersonalWebSite.Models;
using System.Diagnostics;

namespace PersonalWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.CP = CardProject.cardProjects;
            ViewBag.CS = CardServices.cardServices;
            return View();
        }
        public IActionResult Detailes(int id)
        {
            DetailesC detailesC = DetailesC.detailes.Single(p => p.id == id);
            ViewBag.DT = detailesC;
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