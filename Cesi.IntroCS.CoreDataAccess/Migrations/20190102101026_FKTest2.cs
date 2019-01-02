using Microsoft.EntityFrameworkCore.Migrations;

namespace Cesi.IntroCS.CoreDataAccess.Migrations
{
    public partial class FKTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Url" },
                values: new object[] { 1, "http://sample.com" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "Title" },
                values: new object[] { 1, 1, "Test 1", "First post" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BlogId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

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
    }
}
