using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult Send(Message message)
        {

            TravelAgency ctx = new TravelAgency();

            message.PacchettoViaggio = ctx.Packages.Where(package => package.Id == message.PacchettoViaggioId).FirstOrDefault();
            ctx.Messages.Add(message);
            ctx.SaveChanges();

            return Ok("Messaggio salvato");
        }
    }
}
