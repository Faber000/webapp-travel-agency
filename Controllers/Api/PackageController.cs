using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        TravelAgency context;

        public PackageController()
        {
            context = new TravelAgency();
        }

        [HttpGet]
        public IActionResult Get(string? title)
        {
            IQueryable<PacchettoViaggio> packages;

            if (title != null)
            {
                packages = context.Packages.Where(p => p.Title.ToLower().Contains(title.ToLower()));
            }
            else
            {
                packages = context.Packages;
            }

            return Ok(packages);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PacchettoViaggio package = context.Packages.Where(p => p.Id == id).FirstOrDefault();

            return Ok(package);
        }
    }
}
