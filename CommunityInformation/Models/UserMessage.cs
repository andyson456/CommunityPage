using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class UserMessage
	{
		private List<User> users = new List<User>();
		private List<Comment> comments = new List<Comment>();

		public string Message { get; set; }
		public DateTime Date { get; set; }
		public User Name { get; set; }

		public List<User> Users { get { return users; } }
		public List<Comment> Comments { get { return comments; } }
	}
}
