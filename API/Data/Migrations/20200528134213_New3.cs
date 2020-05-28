using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenges.Migrations
{
    public partial class New3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SortingValues");

            migrationBuilder.CreateTable(
                name: "SortingValuesForInput",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Character = table.Column<string>(nullable: false),
                    SortingInputId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortingValuesForInput", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SortingValuesForInput_InputtedCharacters_SortingInputId",
                        column: x => x.SortingInputId,
                        principalTable: "InputtedCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SortingValuesForOutput",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Character = table.Column<string>(nullable: false),
                    SortingOutputId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortingValuesForOutput", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SortingValuesForOutput_OutputtedCharacters_SortingOutputId",
                        column: x => x.SortingOutputId,
                        principalTable: "OutputtedCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SortingValuesForInput_SortingInputId",
                table: "SortingValuesForInput",
                column: "SortingInputId");

            migrationBuilder.CreateIndex(
                name: "IX_SortingValuesForOutput_SortingOutputId",
                table: "SortingValuesForOutput",
                column: "SortingOutputId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SortingValuesForInput");

            migrationBuilder.DropTable(
                name: "SortingValuesForOutput");

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
    }
}
