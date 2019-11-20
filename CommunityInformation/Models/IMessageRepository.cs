using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public interface IMessageRepository
	{
		List<UserMessage> Messages { get; }
		void AddMessage(UserMessage message);
		void AddComment(Comment comment);
		
	}
}
