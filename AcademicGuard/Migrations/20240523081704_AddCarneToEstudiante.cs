using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicGuard.Migrations
{
    /// <inheritdoc />
    public partial class AddCarneToEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Carne",
                table: "Estudiante",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carne",
                table: "Estudiante");
        }
    }
}
