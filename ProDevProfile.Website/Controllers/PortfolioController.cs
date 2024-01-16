using Microsoft.AspNetCore.Mvc;

namespace ProDevProfile.Website.Controllers
{
	public class PortfolioController : Controller
	{
		public PortfolioController()
		{

		}

		public IActionResult PortfolioPage()
		{
			return View();
		}
	}
}
