using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
