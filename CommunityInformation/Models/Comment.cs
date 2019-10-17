using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class Comment
	{
		public string CommentText { get; set; }
		public User UserName { get; set; }
		public UserMessage UserMessage { get; set; }
		public DateTime PubDate { get; set; } = DateTime.Now;
	}
}
