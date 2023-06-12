using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Istatistikler";
            ViewBag.v3 = "Istatistikler Sayfasi";
            return View();
        }
    }
}
