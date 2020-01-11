using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityInformation.Migrations
{
    public partial class UpdateUserMessageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserKey",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "UserMessageMessageID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Messages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserMessageMessageID",
                table: "Users",
                column: "UserMessageMessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserID",
                table: "Messages",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Messages_UserMessageMessageID",
                table: "Users",
                column: "UserMessageMessageID",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Messages_UserMessageMessageID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserMessageMessageID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserMessageMessageID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Messages");

            migrationBuilder.AddColumn<Guid>(
                name: "UserKey",
                table: "Messages",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
