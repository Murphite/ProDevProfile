using Microsoft.AspNetCore.Mvc;

namespace ProDevProfile.Website.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {

        }

        public IActionResult AboutPage()
        {
            return View();
        }
    }
}
