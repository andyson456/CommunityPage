using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityInformation.Models;

namespace CommunityInformation.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Good Morning World" : "Good Afternoon World";

			return View("Index");
		}

		public IActionResult History()
		{
			ViewData["Message"] = "Your application history page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page";

			return View();
		}

		public IActionResult Locations()
		{
			ViewData["Message"] = "Important locations and links";

			return View();
		}

		public IActionResult People()
		{
			ViewData["Message"] = "Significant people and links";

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
