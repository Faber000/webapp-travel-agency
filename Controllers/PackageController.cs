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

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (TravelAgency context = new TravelAgency())
            {
                PacchettoViaggio package = context.Packages
                    .Where(package => package.Id == id).FirstOrDefault();

                return View("Update", package);

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, PacchettoViaggio formData)
        {
            using (TravelAgency context = new TravelAgency())
            {
                if (!ModelState.IsValid)
                {
                    return View("Update", formData);
                }

                PacchettoViaggio package = context.Packages.Where(p => p.Id == id).FirstOrDefault();

                package.Title = formData.Title;
                package.Description = formData.Description;
                package.Price = formData.Price;
                package.Image = formData.Image;


                context.SaveChanges();

                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            using (TravelAgency context = new TravelAgency())
            {
                PacchettoViaggio package = context.Packages.Where(package => package.Id == id).FirstOrDefault();

                context.Packages.Remove(package);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (TravelAgency context = new TravelAgency())
            {

                PacchettoViaggio package= context.Packages.Where(p => p.Id == id).FirstOrDefault();

                return View("Details", package);
            }
        }
    }

}
