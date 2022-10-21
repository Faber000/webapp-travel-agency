using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (TravelAgency context = new TravelAgency())
            {

                PacchettoViaggio package = context.Packages.Where(p => p.Id == id).FirstOrDefault();

                return View("Details", package);
            }
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