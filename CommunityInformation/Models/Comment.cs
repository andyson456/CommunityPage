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
		public int CommentID { get; set; }
		public Guid MessageKey { get; set; }
		public string CommentText { get; set; }
		public User UserName { get; set; }
		public DateTime PubDate { get; set; } = DateTime.Now;
	}
}
