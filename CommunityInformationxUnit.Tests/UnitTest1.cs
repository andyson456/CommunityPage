using System;
using Xunit;
using CommunityInformation.Controllers;
using CommunityInformation.Models;
using FluentAssertions;
using System.Linq;

namespace CommunityInformationxUnit.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void AddMessageTest()
		{
			// Arrange
			var repo = new FakeMessageRepository();
			var homeController = new HomeController(repo);

			// Act
			homeController.Contact("Hello", "RandomName");

			// Assert
			Assert.Equal("Hello", repo.Messages[repo.Messages.Count - 1].Message);
		}

		[Fact]
		public void AddCommentTest()
		{
			// Arrange
			var repo = new FakeMessageRepository();
			var homeController = new HomeController(repo);

			// Act
			var key = new Guid();
			var userMessage = new UserMessage();
			userMessage.MessageID = key;
			userMessage.Message = "test123";
			userMessage.Users.Add(new User() { UserName = "jake" });
			repo.AddMessage(userMessage);

			homeController.MessageComments("test123", "name", key);

			var message = repo.Messages.FirstOrDefault(m => m.MessageID == key);
			if (message == null)
			{
				Assert.False(true);
				return;
			}
			// Assert
			var comment = message.Comments.FirstOrDefault(m => m.CommentText == "test123");
			if (comment == null)
			{
				Assert.False(true);
				return;
			}
		}

		[Fact]
		public void Status404Test()
		{
			var repo = new FakeMessageRepository();
			var homeController = new HomeController(repo);

			var response = homeController.Status404();

			Assert.Equal(404, response.StatusCode);
		}
	}
}
