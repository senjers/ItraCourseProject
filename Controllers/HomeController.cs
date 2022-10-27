using Microsoft.AspNetCore.Mvc;

namespace Itra.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public string Hello ()
        {
            return "Hello Sen, this is mixed request!";
        }
    }
}
