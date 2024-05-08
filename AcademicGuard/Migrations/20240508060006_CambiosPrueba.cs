using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicGuard.Migrations
{
    /// <inheritdoc />
    public partial class CambiosPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Coordinador_Id_coordinador",
                table: "Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Carrera_Coordinador_Id_coordinador",
                table: "Carrera");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_DetallePersona_Id_detalle_persona",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinador_Personas_Id_persona",
                table: "Coordinador");

            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Coordinador_Id_coordinador",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePersona_Personas_Id_persona",
                table: "DetallePersona");

            migrationBuilder.DropForeignKey(
                name: "FK_Direccion_DetallePersona_Id_detalle_persona",
                table: "Direccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Personas_Id_persona",
                table: "Estudiante");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Curso_Id_curso",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Jornada_Curso_Id_curso",
                table: "Jornada");

            migrationBuilder.DropForeignKey(
                name: "FK_Permiso_Coordinador_Id_coordinador",
                table: "Permiso");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesor_Personas_Id_persona",
                table: "Profesor");

            migrationBuilder.DropForeignKey(
                name: "FK_Rol_Usuario_Id_usuario",
                table: "Rol");

            migrationBuilder.DropForeignKey(
                name: "FK_Seccion_Curso_Id_curso",
                table: "Seccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_DetallePersona_Id_detalle_persona",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_Id_detalle_persona",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Seccion_Id_curso",
                table: "Seccion");

            migrationBuilder.DropIndex(
                name: "IX_Rol_Id_usuario",
                table: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_Profesor_Id_persona",
                table: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Permiso_Id_coordinador",
                table: "Permiso");

            migrationBuilder.DropIndex(
                name: "IX_Jornada_Id_curso",
                table: "Jornada");

            migrationBuilder.DropIndex(
                name: "IX_Horario_Id_curso",
                table: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_Id_persona",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Direccion_Id_detalle_persona",
                table: "Direccion");

            migrationBuilder.DropIndex(
                name: "IX_DetallePersona_Id_persona",
                table: "DetallePersona");

            migrationBuilder.DropIndex(
                name: "IX_Curso_Id_coordinador",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Coordinador_Id_persona",
                table: "Coordinador");

            migrationBuilder.DropIndex(
                name: "IX_Contacto_Id_detalle_persona",
                table: "Contacto");

            migrationBuilder.DropIndex(
                name: "IX_Carrera_Id_coordinador",
                table: "Carrera");

            migrationBuilder.DropIndex(
                name: "IX_Asistencia_Id_coordinador",
                table: "Asistencia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id_detalle_persona",
                table: "Usuario",
                column: "Id_detalle_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Seccion_Id_curso",
                table: "Seccion",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Id_usuario",
                table: "Rol",
                column: "Id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_Id_persona",
                table: "Profesor",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_Id_coordinador",
                table: "Permiso",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Jornada_Id_curso",
                table: "Jornada",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Id_curso",
                table: "Horario",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_Id_persona",
                table: "Estudiante",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_Id_detalle_persona",
                table: "Direccion",
                column: "Id_detalle_persona");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePersona_Id_persona",
                table: "DetallePersona",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_Id_coordinador",
                table: "Curso",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinador_Id_persona",
                table: "Coordinador",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_Id_detalle_persona",
                table: "Contacto",
                column: "Id_detalle_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Carrera_Id_coordinador",
                table: "Carrera",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Id_coordinador",
                table: "Asistencia",
                column: "Id_coordinador");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Coordinador_Id_coordinador",
                table: "Asistencia",
                column: "Id_coordinador",
                principalTable: "Coordinador",
                principalColumn: "Id_coordinador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrera_Coordinador_Id_coordinador",
                table: "Carrera",
                column: "Id_coordinador",
                principalTable: "Coordinador",
                principalColumn: "Id_coordinador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_DetallePersona_Id_detalle_persona",
                table: "Contacto",
                column: "Id_detalle_persona",
                principalTable: "DetallePersona",
                principalColumn: "Id_detalle_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinador_Personas_Id_persona",
                table: "Coordinador",
                column: "Id_persona",
                principalTable: "Personas",
                principalColumn: "Id_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Coordinador_Id_coordinador",
                table: "Curso",
                column: "Id_coordinador",
                principalTable: "Coordinador",
                principalColumn: "Id_coordinador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePersona_Personas_Id_persona",
                table: "DetallePersona",
                column: "Id_persona",
                principalTable: "Personas",
                principalColumn: "Id_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Direccion_DetallePersona_Id_detalle_persona",
                table: "Direccion",
                column: "Id_detalle_persona",
                principalTable: "DetallePersona",
                principalColumn: "Id_detalle_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Personas_Id_persona",
                table: "Estudiante",
                column: "Id_persona",
                principalTable: "Personas",
                principalColumn: "Id_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Curso_Id_curso",
                table: "Horario",
                column: "Id_curso",
                principalTable: "Curso",
                principalColumn: "Id_curso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jornada_Curso_Id_curso",
                table: "Jornada",
                column: "Id_curso",
                principalTable: "Curso",
                principalColumn: "Id_curso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permiso_Coordinador_Id_coordinador",
                table: "Permiso",
                column: "Id_coordinador",
                principalTable: "Coordinador",
                principalColumn: "Id_coordinador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesor_Personas_Id_persona",
                table: "Profesor",
                column: "Id_persona",
                principalTable: "Personas",
                principalColumn: "Id_persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_Usuario_Id_usuario",
                table: "Rol",
                column: "Id_usuario",
                principalTable: "Usuario",
                principalColumn: "Id_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seccion_Curso_Id_curso",
                table: "Seccion",
                column: "Id_curso",
                principalTable: "Curso",
                principalColumn: "Id_curso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_DetallePersona_Id_detalle_persona",
                table: "Usuario",
                column: "Id_detalle_persona",
                principalTable: "DetallePersona",
                principalColumn: "Id_detalle_persona",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
