﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class ImportantPeople
	{
		public int ImportantPeopleID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string BirthDate { get; set; }
		public string DeathDate { get; set; }
	}
}
