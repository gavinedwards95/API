using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenges.Migrations
{
    public partial class New5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SortingValuesForInput",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SortingValuesForInput",
                newName: "ID");
        }
    }
}
