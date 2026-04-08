using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "home")]
        public string Get()
        {
            return "Hello, World!";
        }
    }
}
