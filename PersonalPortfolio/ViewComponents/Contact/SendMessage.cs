using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
