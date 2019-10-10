using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class User
	{
		private List<UserMessage> messages = new List<UserMessage>();

		public int UserID { get; set; }
		public string Name { get; set; }
		public List<UserMessage> Messages
		{
			get
			{
				return messages;
			}
			set
			{
				messages = value;
			}
		}
	}
}
