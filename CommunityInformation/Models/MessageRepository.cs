using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class MessageRepository : IMessageRepository
	{
		private AppDbContext context;
		
		public List<UserMessage> Messages { get {
				return context.Messages.Include("Comments").Include("Users").ToList(); } }

		public MessageRepository(AppDbContext appDbContext)
		{
			context = appDbContext;
		}

		public void AddComment(Comment comment)
		{
			var message = Messages.FirstOrDefault(msg => msg.MessageKey == comment.MessageKey);
			if (message == null)
			{
				return;
			}
			message.Comments.Add(comment);
		}

		public void AddMessage(UserMessage message)
		{
			context.Messages.Add(message);
			context.SaveChanges();
		}

<<<<<<< HEAD
		void AddTestData()
		{
			UserMessage message = new UserMessage()
			{
				Message = "Some message",
				Date = new DateTime(2002, 4, 3)
			};
			message.Users.Add(new User
			{
				UserName = "Andrew"
			}
			);
			Comment comment1 = new Comment() { CommentText = "I DON'T LIKE THIS MESSAGE" };
			message.Comments.Add(comment1);
			messages.Add(message);

			message = new UserMessage()
			{
				Message = "Another message",
				Date = new DateTime(2001, 5, 11)
			};
			message.Users.Add(new User
			{
				UserName = "Jason"
			}
			);

			Comment comment2 = new Comment() { CommentText = "This is a comment" };
			message.Comments.Add(comment2);
			messages.Add(message);
		}
=======
		public void AddComment(Comment comment)
		{
			var message = Messages.FirstOrDefault(msg => msg.MessageKey == comment.MessageKey);
			if (message == null)
			{
				return;
			}
			context.Messages.Add(message);
			context.Messages.Update(message);
			context.SaveChanges();
		}

		//void AddTestData()
		//{
		//	UserMessage message = new UserMessage()
		//	{
		//		Message = "Some message",
		//		Date = new DateTime(2002, 4, 3)
		//	};
		//	message.Users.Add(new User
		//	{
		//		UserName = "Andrew"
		//	}
		//	);
		//	Comment comment1 = new Comment() { CommentText = "I DON'T LIKE THIS MESSAGE" };
		//	message.Comments.Add(comment1);
		//	messages.Add(message);

		//	message = new UserMessage()
		//	{
		//		Message = "Another message",
		//		Date = new DateTime(2001, 5, 11)
		//	};
		//	message.Users.Add(new User
		//	{
		//		UserName = "Jason"
		//	}
		//	);

		//	Comment comment2 = new Comment() { CommentText = "This is a comment" };
		//	message.Comments.Add(comment2);
		//	messages.Add(message);
		//}

>>>>>>> ef
	}
}
