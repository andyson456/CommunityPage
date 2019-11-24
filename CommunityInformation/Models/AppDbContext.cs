using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityInformation.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }
		public DbSet<UserMessage> Messages { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<ImportantLocations> ImportantLocations { get; set; }
		public DbSet<ImportantPeople> ImportantPeoples { get; set; }
	}
}
