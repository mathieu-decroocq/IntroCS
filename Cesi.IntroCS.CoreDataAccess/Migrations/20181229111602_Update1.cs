using Microsoft.EntityFrameworkCore.Migrations;

namespace Cesi.IntroCS.CoreDataAccess.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Posts",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "PostId");
        }
    }
}
