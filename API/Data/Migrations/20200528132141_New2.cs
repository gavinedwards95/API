using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenges.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterSortingInputs",
                table: "CharacterSortingInputs");

            migrationBuilder.RenameTable(
                name: "CharacterSortingInputs",
                newName: "InputtedCharacters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InputtedCharacters",
                table: "InputtedCharacters",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OutputtedCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutputtedCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SortingValues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Character = table.Column<string>(nullable: false),
                    SortingInputId = table.Column<int>(nullable: true),
                    SortingOutputId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortingValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SortingValues_InputtedCharacters_SortingInputId",
                        column: x => x.SortingInputId,
                        principalTable: "InputtedCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SortingValues_OutputtedCharacters_SortingOutputId",
                        column: x => x.SortingOutputId,
                        principalTable: "OutputtedCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SortingValues_SortingInputId",
                table: "SortingValues",
                column: "SortingInputId");

            migrationBuilder.CreateIndex(
                name: "IX_SortingValues_SortingOutputId",
                table: "SortingValues",
                column: "SortingOutputId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SortingValues");

            migrationBuilder.DropTable(
                name: "OutputtedCharacters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InputtedCharacters",
                table: "InputtedCharacters");

            migrationBuilder.RenameTable(
                name: "InputtedCharacters",
                newName: "CharacterSortingInputs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterSortingInputs",
                table: "CharacterSortingInputs",
                column: "Id");
        }
    }
}
