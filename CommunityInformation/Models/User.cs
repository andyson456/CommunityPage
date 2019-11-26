using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class User
	{
		private List<Comment> comments = new List<Comment>();
		//private List<UserMessage> messages = new List<UserMessage>();

		public int UserID { get; set; }
		public Guid UserKey { get; set; }
		public string UserName { get; set; }

		public List<Comment> Comments { get { return comments; } }
		//public List<UserMessage> Messages { get { return messages; } }
	}
}
