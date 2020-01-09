using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityInformation.Migrations
{
    public partial class migrationTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserNameUserID",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "UserNameUserID",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserNameUserID",
                table: "Comments",
                column: "UserNameUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserNameUserID",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "UserNameUserID",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserNameUserID",
                table: "Comments",
                column: "UserNameUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
