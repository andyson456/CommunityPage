using System;
using Xunit;
using CommunityInformation.Controllers;
using CommunityInformation.Models;

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
			var user = repo.Messages[repo.Messages.Count - 1].User.UserName;

			// Act
			homeController.Contact("Hello", "RandomName");

			// Assert
			Assert.Equal("Hello", repo.Messages[repo.Messages.Count - 1].Message);
			//Assert.Equal("RandomName", user);
		}
	}
}
