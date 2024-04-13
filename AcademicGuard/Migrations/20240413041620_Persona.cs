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

            migrationBuilder.CreateTable(
                name: "DetallePersona",
                columns: table => new
                {
                    Id_detalle_persona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_persona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePersona", x => x.Id_detalle_persona);
                    table.ForeignKey(
                        name: "FK_DetallePersona_Personas_Id_persona",
                        column: x => x.Id_persona,
                        principalTable: "Personas",
                        principalColumn: "Id_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePersona_Id_persona",
                table: "DetallePersona",
                column: "Id_persona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePersona");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
