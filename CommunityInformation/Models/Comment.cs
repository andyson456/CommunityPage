using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class Comment
	{
		[Key]
		public Guid CommentID { get; set; }
		public Guid UserID { get; set; }
		public Guid MessageID { get; set; }
		public string CommentText { get; set; }
		public User UserName { get; set; }
		public UserMessage UserMessage { get; set; }
		public DateTime PubDate { get; set; } = DateTime.Now;
	}
}
