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
		UserMessage userMessage;

		public HomeController()
		{
			if (MessageRepository.Messages.Count == 0)
			{
				userMessage = new UserMessage()
				{
					Message = "Some message",
					Date = "10/11/2019"
				};
				userMessage.Users.Add(new User
				{
					Name = "Andrew"
				}
				);
				MessageRepository.AddMessage(userMessage);
			}
		}

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

		[HttpGet]
		public ViewResult Contact()
		{
			return View();
		}

		[HttpPost]
		public RedirectToActionResult Contact(string message, string user, string date)
		{
			userMessage = new UserMessage();
			userMessage.Message = message;
			userMessage.Users.Add(new User() { Name = user });
			userMessage.Date = date;
			MessageRepository.AddMessage(userMessage);
			return RedirectToAction("MessageResponses");
		}

		public ViewResult MessageResponses()
		{
			List<UserMessage> messages = MessageRepository.Messages.ToList();
			return View(messages);
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
