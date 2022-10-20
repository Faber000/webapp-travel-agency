using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Controllers
{
    public class PackageController : Controller
    {
        public IActionResult Index()
        {
            using (TravelAgency context = new TravelAgency())
            {

                List<PacchettoViaggio> packages = context.Packages.ToList();

                return View("Index", packages);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            PacchettoViaggio package = new PacchettoViaggio();

            return View("Create", package);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PacchettoViaggio formData)
        {
            TravelAgency context = new TravelAgency();

            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            context.Packages.Add(formData);

            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
