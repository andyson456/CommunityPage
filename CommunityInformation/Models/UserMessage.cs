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
		public int MessageID { get; set; }

		public Guid MessageKey { get; set; }

		[Required]
		[StringLength(200, MinimumLength = 0)]
		public string Message { get; set; }

		[Display(Name = "Post Date"), DataType(DataType.Date)]
		public DateTime Date { get; set; } = DateTime.Now;

		public User User { get; set; }

		public List<User> Users { get { return users; } }
		public List<Comment> Comments { get { return comments; } }
	}
}
