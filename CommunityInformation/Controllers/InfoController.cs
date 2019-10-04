using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommunityInformation.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Locations()
		{
			ViewData["Message"] = "Important locations and links.";

			return View();
		}

		public IActionResult People()
		{
			ViewData["Message"] = "Significant people and links";

			return View();
		}
	}
}