using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public static class PeopleRepository
	{
		private static List<ImportantPeople> people = new List<ImportantPeople>();
		public static List<ImportantPeople> People { get { return people; } }

		static PeopleRepository()
		{
			TestData();
		}

		public static void AddPeople(ImportantPeople people)
		{
			People.Add(people);
		}

		static void TestData()
		{
			ImportantPeople person1 = new ImportantPeople()
			{
				BirthDate = "02/24/1938",
				DeathDate = "Current",
				FirstName = "Phillup",
				LastName = "Knight"
			};
			People.Add(person1);

			ImportantPeople person2 = new ImportantPeople()
			{
				BirthDate = "09/13/1809",
				DeathDate = "12/15/1864",
				FirstName = "Eugene",
				LastName = "Skinner"
			};
			People.Add(person2);

			ImportantPeople person3 = new ImportantPeople()
			{
				BirthDate = "01/25/1951",
				DeathDate = "05/30/1975",
				FirstName = "Steve",
				LastName = "Prefontaine"
			};
			People.Add(person3);

			ImportantPeople person4 = new ImportantPeople()
			{
				BirthDate = "06/08/1965",
				DeathDate = "Current",
				FirstName = "Stanley",
				LastName = "Love"
			};
			People.Add(person4);

		}
	}
}
