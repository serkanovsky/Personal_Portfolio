using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
