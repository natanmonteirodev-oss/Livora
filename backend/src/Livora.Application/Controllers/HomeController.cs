using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Livora.Application.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("/home", Name = "Home")]
        public IActionResult Home() 
        {
            return Ok("Healthy");
        }
    }
}
