using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversidadWebSite.Migrations
{
    public partial class FotoEstudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Estudiantes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Estudiantes");
        }
    }
}
