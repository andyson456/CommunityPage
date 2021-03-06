﻿// <auto-generated />
using System;
using CommunityInformation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommunityInformation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommunityInformation.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFounded");

                    b.Property<string>("Name");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CommunityInformation.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("CommentKey");

                    b.Property<string>("CommentText");

                    b.Property<Guid>("MessageKey");

                    b.Property<DateTime>("PubDate");

                    b.Property<Guid>("UserID");

                    b.Property<int?>("UserMessageMessageID");

                    b.Property<int?>("UserNameUserID");

                    b.HasKey("CommentID");

                    b.HasIndex("UserMessageMessageID");

                    b.HasIndex("UserNameUserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CommunityInformation.Models.ImportantLocations", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateEstablished");

                    b.Property<string>("Description");

                    b.Property<string>("LocationName");

                    b.HasKey("LocationID");

                    b.ToTable("ImportantLocations");
                });

            modelBuilder.Entity("CommunityInformation.Models.ImportantPeople", b =>
                {
                    b.Property<int>("ImportantPeopleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("DeathDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ImportantPeopleID");

                    b.ToTable("ImportantPeoples");
                });

            modelBuilder.Entity("CommunityInformation.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("UserKey");

                    b.Property<int?>("UserMessageMessageID");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.HasIndex("UserMessageMessageID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CommunityInformation.Models.UserMessage", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Message");

                    b.Property<Guid>("MessageKey");

                    b.Property<int?>("UserID");

                    b.HasKey("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CommunityInformation.Models.Comment", b =>
                {
                    b.HasOne("CommunityInformation.Models.UserMessage", "UserMessage")
                        .WithMany("Comments")
                        .HasForeignKey("UserMessageMessageID");

                    b.HasOne("CommunityInformation.Models.User", "UserName")
                        .WithMany("Comments")
                        .HasForeignKey("UserNameUserID");
                });

            modelBuilder.Entity("CommunityInformation.Models.User", b =>
                {
                    b.HasOne("CommunityInformation.Models.UserMessage")
                        .WithMany("Users")
                        .HasForeignKey("UserMessageMessageID");
                });

            modelBuilder.Entity("CommunityInformation.Models.UserMessage", b =>
                {
                    b.HasOne("CommunityInformation.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
