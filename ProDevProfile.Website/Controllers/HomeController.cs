using Microsoft.AspNetCore.Mvc;
using ProDevProfile.Website.Models;
using System.Diagnostics;

namespace ProDevProfile.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult AboutPage()
		{
			return View();
		}

		public IActionResult ContactPage()
		{
			return View();
		}

		public IActionResult PortfolioPage()
		{
			return View();
		}

		public IActionResult BlogPage()
		{
			return View();
		}
		public IActionResult Privacy()
        {
            return View();
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}