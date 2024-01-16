using Microsoft.AspNetCore.Mvc;

namespace ProDevProfile.Website.Controllers
{
	public class ContactController : Controller
	{
		public ContactController()
		{

		}

		public IActionResult ContactPage()
		{
			return View();
		}
	}
}
