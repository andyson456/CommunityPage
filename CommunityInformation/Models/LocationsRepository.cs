using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class LocationsRepository
	{
		private static List<ImportantLocations> locations = new List<ImportantLocations>();
		public static List<ImportantLocations> Locations { get { return locations; } }

		static LocationsRepository()
		{
			TestData();
		}

		public static void AddLocation(ImportantLocations location)
		{
			Locations.Add(location);
		}

		static void TestData()
		{
			ImportantLocations location1 = new ImportantLocations()
			{
				LocationName = "Spencer's Butte",
				Description = "A butte located in South Eugene. Named after a young Englishmen who" +
	                          "is thought to have been killed from the Kalapuya while hiking the Butte alone",
				DateEstablished = "20 - 30 million years old"
			};

			ImportantLocations location2 = new ImportantLocations()
			{
				LocationName = "University of Oregon",
				Description = "College University located in the campus area of Eugene",
				DateEstablished = "1876"
			};

			ImportantLocations location3 = new ImportantLocations()
			{
				LocationName = "Autzen Stadium",
				Description = "Football arena located in East Eugene",
				DateEstablished = "September 23, 1967"
			};

			ImportantLocations location4 = new ImportantLocations()
			{
				LocationName = "The Hult Center for the Performing Arts",
				Description = "A concert venue located in Downtown Eugene",
				DateEstablished = "1982"
			};
		}
	}
	
}
