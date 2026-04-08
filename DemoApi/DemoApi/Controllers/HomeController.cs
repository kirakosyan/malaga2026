using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
