using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AcademicGuard.Migrations
{
    /// <inheritdoc />
    public partial class Persona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id_persona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Dpi = table.Column<string>(type: "longtext", nullable: false),
                    Primer_nombre = table.Column<string>(type: "longtext", nullable: false),
                    Segundo_nombre = table.Column<string>(type: "longtext", nullable: false),
                    Nombres_extras = table.Column<string>(type: "longtext", nullable: false),
                    Primer_apellido = table.Column<string>(type: "longtext", nullable: false),
                    Segundo_apellido = table.Column<string>(type: "longtext", nullable: false),
                    Apellidos_extras = table.Column<string>(type: "longtext", nullable: false),
                    Sexo = table.Column<string>(type: "longtext", nullable: false),
                    Fecha_nacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Persona_habilitada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Fecha_creacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fecha_modificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Usuario_modificacion = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id_persona);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
