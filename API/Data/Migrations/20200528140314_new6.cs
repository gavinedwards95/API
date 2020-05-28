using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenges.Migrations
{
    public partial class new6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterNumber",
                table: "SortingValuesForInput",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterNumber",
                table: "SortingValuesForInput");
        }
    }
}
