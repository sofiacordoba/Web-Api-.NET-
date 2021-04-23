using Microsoft.EntityFrameworkCore.Migrations;

namespace SWMedicos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Medico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.RenameTable(
                name: "Medico",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
