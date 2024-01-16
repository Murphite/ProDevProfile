using Microsoft.AspNetCore.Mvc;

namespace ProDevProfile.Website.Controllers
{
	public class BlogController : Controller
	{
		public BlogController()
		{

		}


		public IActionResult BlogPage()
		{
			return View();
		}
	}
}
