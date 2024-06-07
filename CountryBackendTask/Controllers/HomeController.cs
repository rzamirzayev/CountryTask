using Microsoft.AspNetCore.Mvc;

namespace CountryBackendTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


        [NonAction]
        public string RandomId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
