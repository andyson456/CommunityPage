using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CommunityInformation.Models;
using System.Web;

namespace CommunityInformation.Controllers
{
	public class HomeController : Controller
	{
		UserMessage userMessage;
		ImportantPeople people;
		ImportantLocations location;
		IMessageRepository repo;

		public HomeController(IMessageRepository r)
		{
			repo = r;
		}

		public IActionResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Good Morning World" : "Good Afternoon World";

			return View("Index");
		}

		public StatusCodeResult Status404() => StatusCode(StatusCodes.Status404NotFound);

		public StatusCodeResult BadRequestPage() => StatusCode(StatusCodes.Status400BadRequest);

		public JsonResult JsonPage() => Json(new[] { "Look", "at", "these", "objects" });

		public ObjectResult ObjectPage() => Ok(new string[] { "A", "page", "that", "displays", "objects" });

		public IActionResult History()
		{
			ViewData["Message"] = "Your application history page.";

			return View();
		}

		[HttpGet]
		public ViewResult MessageComments(UserMessage usermessage)
		{
			return View(usermessage);
		}

		[HttpPost]
		public RedirectToActionResult MessageComments(string commentText, string userName, Guid messageKey)
		{
			UserMessage message = new UserMessage();
			message.Comments.Add(new Comment()
			{
				MessageID = messageKey,
				UserName = new User() { UserName = userName },
				CommentText = commentText
			});
			repo.AddComment(new Comment()
			{
				MessageID = messageKey,
				UserName = new User() { UserName = userName },
				CommentText = commentText
			});
			return RedirectToAction("MessageResponses");
		}

		[HttpGet]
		public IActionResult Locations()
		{
			List<ImportantLocations> locations = LocationsRepository.Locations;
			ViewBag.locationsCount = locations.Count();
			locations.Sort((l1, l2) => string.Compare(l1.LocationName, l2.LocationName, StringComparison.Ordinal));
			return View();
		}

		[HttpPost]
		public RedirectToActionResult Locations(string locationName, string description, string dateEstablished)
		{
			location = new ImportantLocations();
			location.LocationName = locationName;
			location.Description = description;
			location.DateEstablished = dateEstablished;
			LocationsRepository.AddLocation(location);
			return RedirectToAction("Locations");
		}

		[HttpGet]
		public IActionResult People()
		{
			List<ImportantPeople> peoples = PeopleRepository.People;
			ViewBag.peopleCount = peoples.Count();
			peoples.Sort((p1, p2) => string.Compare(p1.LastName, p2.LastName, StringComparison.Ordinal));
			return View();
		}

		[HttpPost]
		public RedirectToActionResult People(string firstName, string lastName, string birthDate, string deathDate)
		{
			people = new ImportantPeople();
			people.FirstName = firstName;
			people.LastName = lastName;
			people.BirthDate = birthDate;
			people.DeathDate = deathDate;
			PeopleRepository.AddPeople(people);
			return RedirectToAction("People");
		}

		[HttpGet]
		public IActionResult Contact()
		{
			List<UserMessage> messages = repo.Messages;
			messages.Sort((m1, m2) => DateTime.Compare(m1.Date, m2.Date));
			return View();
		}

		[HttpPost]
		public RedirectToActionResult Contact(string message, string name)
		{
			userMessage = new UserMessage();
			userMessage.MessageID = Guid.NewGuid();
			userMessage.Message = message;
			userMessage.Users.Add(new User() { UserName = name });
			repo.AddMessage(userMessage);
			return RedirectToAction("MessageResponses");
		}

		public ViewResult MessageResponses()
		{
			List<UserMessage> messages = repo.Messages;
			ViewData["NewestMessage"] = messages[messages.Count - 1].Message;
			return View(messages);
		}

		public IActionResult MessageComments(string title)
		{
			return View("AddComment", HttpUtility.HtmlDecode(title));
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
