﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityInformation.Models;
using System.Web;

namespace CommunityInformation.Controllers
{
	public class HomeController : Controller
	{
		UserMessage userMessage;
		Comment comment;

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
		public ViewResult MessageComments()
		{
			return View();
		}

		[HttpPost]
		public RedirectToActionResult MessageComments(string commentText, string userName)
		{
			UserMessage message = new UserMessage();
			message.Comments.Add(new Comment()
			{
				UserName = new User() { UserName = userName },
				CommentText = commentText
			});
			
			return RedirectToAction("MessageResponses");
		}

		[HttpGet]
		public ViewResult Contact()
		{
			return View();
		}

		[HttpPost]
		public RedirectToActionResult Contact(string message, string name, string date)
		{
			userMessage = new UserMessage();
			userMessage.Message = message;
			userMessage.Users.Add(new User() { UserName = name });
			userMessage.Date = DateTime.Parse(date);
			MessageRepository.AddMessage(userMessage);
			return RedirectToAction("MessageResponses");
		}

		public ViewResult MessageResponses()
		{
			List<UserMessage> messages = MessageRepository.Messages;
			return View(messages);
		}

		public IActionResult MessageComments(string title)
		{
			return View("AddComment", HttpUtility.HtmlDecode(title));
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
