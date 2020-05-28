using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenges.Migrations
{
    public partial class RefactoringSortingStorageCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterSortingInputs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSortingInputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSortingOutputs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSortingOutputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InputSortingValues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Character = table.Column<string>(nullable: false),
                    SortingInputId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputSortingValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InputSortingValues_CharacterSortingInputs_SortingInputId",
                        column: x => x.SortingInputId,
                        principalTable: "CharacterSortingInputs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutputSortingValues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Character = table.Column<string>(nullable: false),
                    SortingOutputId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutputSortingValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OutputSortingValues_CharacterSortingOutputs_SortingOutputId",
                        column: x => x.SortingOutputId,
                        principalTable: "CharacterSortingOutputs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InputSortingValues_SortingInputId",
                table: "InputSortingValues",
                column: "SortingInputId");

            migrationBuilder.CreateIndex(
                name: "IX_OutputSortingValues_SortingOutputId",
                table: "OutputSortingValues",
                column: "SortingOutputId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputSortingValues");

            migrationBuilder.DropTable(
                name: "OutputSortingValues");

            migrationBuilder.DropTable(
                name: "CharacterSortingInputs");

            migrationBuilder.DropTable(
                name: "CharacterSortingOutputs");
        }
    }
}
