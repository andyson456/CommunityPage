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
				BirthDate = "04/09/1933",
				DeathDate = "01/01/1994",
				FirstName = "Henry",
				LastName = "Rollins"
			};
			People.Add(person1);

			ImportantPeople person2 = new ImportantPeople()
			{
				BirthDate = "10/28/1853",
				DeathDate = "04/01/1912",
				FirstName = "Dirk",
				LastName = "Diggler"
			};
			People.Add(person2);

			ImportantPeople person3 = new ImportantPeople()
			{
				BirthDate = "08/08/1912",
				DeathDate = "01/01/1973",
				FirstName = "Forest",
				LastName = "Gump"
			};
			People.Add(person3);

		}
	}
}
