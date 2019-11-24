using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class ImportantPeople
	{
		[Key]
		public int ImportantPeopleID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string BirthDate { get; set; }
		public string DeathDate { get; set; }
	}
}
