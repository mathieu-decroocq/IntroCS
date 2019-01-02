using Microsoft.EntityFrameworkCore.Migrations;

namespace Cesi.IntroCS.CoreDataAccess.Migrations
{
    public partial class foreignkeyTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BlogId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Blogs",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "FK_Posts_Blogs_BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "FK_Posts_Blogs_BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
