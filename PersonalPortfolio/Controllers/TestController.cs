using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
