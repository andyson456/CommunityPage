using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class City
	{
		[Key]
		public int CityID { get; set; }
		public string Name { get; set; }
		public DateTime DateFounded { get; set; }
	}
}
