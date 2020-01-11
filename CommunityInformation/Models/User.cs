using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class User
	{
<<<<<<< HEAD
		//private List<Comment> comments = new List<Comment>();
		//private List<UserMessage> messages = new List<UserMessage>();

=======
		private List<Comment> comments = new List<Comment>();
		//private List<UserMessage> messages = new List<UserMessage>();

		
>>>>>>> ef
		public int UserID { get; set; }
		public Guid UserKey { get; set; }
		public string UserName { get; set; }

<<<<<<< HEAD
		//public List<Comment> Comments { get { return comments; } }
=======
		public List<Comment> Comments { get { return comments; } }
>>>>>>> ef
		//public List<UserMessage> Messages { get { return messages; } }
	}
}
