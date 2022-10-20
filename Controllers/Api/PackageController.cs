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
        public IActionResult Get()
        {
            IQueryable<PacchettoViaggio> packages;
            
            packages = context.Packages;

            return Ok(packages);
        }
    }
}
