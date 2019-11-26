using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class ImportantLocations
	{
		public int ImportantLocationsID { get; set; }
		public string LocationName { get; set; }
		public string Description { get; set; }
		public string DateEstablished { get; set; }
	}
}
