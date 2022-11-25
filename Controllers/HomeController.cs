using Microsoft.AspNetCore.Mvc;

namespace Care.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
