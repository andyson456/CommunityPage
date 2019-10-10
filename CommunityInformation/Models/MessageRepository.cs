using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public static class MessageRepository
	{
		private static List<UserMessage> messages = new List<UserMessage>();
		
		public static IEnumerable<UserMessage> Messages
		{
			get
			{
				return messages;
			}
		}

		public static void AddMessage(UserMessage message)
		{
			messages.Add(message);
		}
	}
}
