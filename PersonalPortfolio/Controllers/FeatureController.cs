using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
