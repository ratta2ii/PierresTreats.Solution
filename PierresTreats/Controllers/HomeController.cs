using Microsoft.AspNetCore.Mvc;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
    
}