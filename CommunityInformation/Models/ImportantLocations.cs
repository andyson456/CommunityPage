using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class ImportantLocations
	{
		[Key]
		public int LocationID { get; set; }
		public string LocationName { get; set; }
		public string Description { get; set; }
		public string DateEstablished { get; set; }
	}
}
