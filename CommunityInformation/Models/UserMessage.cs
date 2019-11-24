using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class UserMessage
	{
		private List<User> users = new List<User>();
		private List<Comment> comments = new List<Comment>();

		[Key]
		public Guid MessageID { get; set; }
		public Guid UserKey { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;
		//public User User { get; set; }

		public List<User> Users { get { return users; } }
		public List<Comment> Comments { get { return comments; } }
	}
}
