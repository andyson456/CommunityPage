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

		[Required]
		public string CommentText { get; set; }

		[Required]
		public User UserName { get; set; }

		[Display(Name = "Comment Post Date"), DataType(DataType.Date)]
		public DateTime PubDate { get; set; } = DateTime.Now;
	}
}
