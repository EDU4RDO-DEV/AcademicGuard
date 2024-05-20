using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AcademicGuard.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion_dato : Migration
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
                    Usuario_modificacion = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id_persona);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Coordinador",
                columns: table => new
                {
                    Id_coordinador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_persona = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "longtext", nullable: false),
                    Especialidad = table.Column<string>(type: "longtext", nullable: false),
                    Fecha_contratacion = table.Column<string>(type: "longtext", nullable: false),
                    Periodo_mandato = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinador", x => x.Id_coordinador);
                    table.ForeignKey(
                        name: "FK_Coordinador_Personas_Id_persona",
                        column: x => x.Id_persona,
                        principalTable: "Personas",
                        principalColumn: "Id_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetallePersona",
                columns: table => new
                {
                    Id_detalle_persona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_persona = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id_estudiante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_persona = table.Column<int>(type: "int", nullable: false),
                    Año_ingreso = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id_estudiante);
                    table.ForeignKey(
                        name: "FK_Estudiante_Personas_Id_persona",
                        column: x => x.Id_persona,
                        principalTable: "Personas",
                        principalColumn: "Id_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id_profesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_persona = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "longtext", nullable: false),
                    Especialidad = table.Column<string>(type: "longtext", nullable: false),
                    Fecha_contratacion = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id_profesor);
                    table.ForeignKey(
                        name: "FK_Profesor_Personas_Id_persona",
                        column: x => x.Id_persona,
                        principalTable: "Personas",
                        principalColumn: "Id_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id_contacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_detalle_persona = table.Column<int>(type: "int", nullable: false),
                    Telefono_1 = table.Column<string>(type: "longtext", nullable: false),
                    Telefono_2 = table.Column<string>(type: "longtext", nullable: false),
                    Telefono_casa = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id_contacto);
                    table.ForeignKey(
                        name: "FK_Contacto_DetallePersona_Id_detalle_persona",
                        column: x => x.Id_detalle_persona,
                        principalTable: "DetallePersona",
                        principalColumn: "Id_detalle_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    Id_direccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_detalle_persona = table.Column<int>(type: "int", nullable: false),
                    Calle = table.Column<string>(type: "longtext", nullable: false),
                    Avenida = table.Column<string>(type: "longtext", nullable: false),
                    Barrio = table.Column<string>(type: "longtext", nullable: false),
                    Zona = table.Column<string>(type: "longtext", nullable: false),
                    Municipio = table.Column<string>(type: "longtext", nullable: false),
                    Departamento = table.Column<string>(type: "longtext", nullable: false),
                    Codigo_postal = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.Id_direccion);
                    table.ForeignKey(
                        name: "FK_Direccion_DetallePersona_Id_detalle_persona",
                        column: x => x.Id_detalle_persona,
                        principalTable: "DetallePersona",
                        principalColumn: "Id_detalle_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_detalle_persona = table.Column<int>(type: "int", nullable: false),
                    Correo_institucional = table.Column<string>(type: "longtext", nullable: false),
                    Clave = table.Column<string>(type: "longtext", nullable: false),
                    Fecha_creacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Ultima_conexion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_usuario);
                    table.ForeignKey(
                        name: "FK_Usuario_DetallePersona_Id_detalle_persona",
                        column: x => x.Id_detalle_persona,
                        principalTable: "DetallePersona",
                        principalColumn: "Id_detalle_persona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    Id_asistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_estudiante = table.Column<int>(type: "int", nullable: false),
                    Id_profesor = table.Column<int>(type: "int", nullable: false),
                    Id_coordinador = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false),
                    Asitencia = table.Column<string>(type: "longtext", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.Id_asistencia);
                    table.ForeignKey(
                        name: "FK_Asistencia_Coordinador_Id_coordinador",
                        column: x => x.Id_coordinador,
                        principalTable: "Coordinador",
                        principalColumn: "Id_coordinador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiante_Id_estudiante",
                        column: x => x.Id_estudiante,
                        principalTable: "Estudiante",
                        principalColumn: "Id_estudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencia_Profesor_Id_profesor",
                        column: x => x.Id_profesor,
                        principalTable: "Profesor",
                        principalColumn: "Id_profesor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id_curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_profesor = table.Column<int>(type: "int", nullable: false),
                    Id_estudiante = table.Column<int>(type: "int", nullable: false),
                    Id_coordinador = table.Column<int>(type: "int", nullable: false),
                    Nombre_curso = table.Column<string>(type: "longtext", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id_curso);
                    table.ForeignKey(
                        name: "FK_Curso_Coordinador_Id_coordinador",
                        column: x => x.Id_coordinador,
                        principalTable: "Coordinador",
                        principalColumn: "Id_coordinador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_Estudiante_Id_estudiante",
                        column: x => x.Id_estudiante,
                        principalTable: "Estudiante",
                        principalColumn: "Id_estudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_Profesor_Id_profesor",
                        column: x => x.Id_profesor,
                        principalTable: "Profesor",
                        principalColumn: "Id_profesor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id_permiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_estudiante = table.Column<int>(type: "int", nullable: false),
                    Id_profesor = table.Column<int>(type: "int", nullable: false),
                    Id_coordinador = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "longtext", nullable: false),
                    Documento_adjunto = table.Column<string>(type: "longtext", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false),
                    Fecha_solicitud = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fecha_respuesta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false),
                    Estado_aceptacion = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id_permiso);
                    table.ForeignKey(
                        name: "FK_Permiso_Coordinador_Id_coordinador",
                        column: x => x.Id_coordinador,
                        principalTable: "Coordinador",
                        principalColumn: "Id_coordinador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permiso_Estudiante_Id_estudiante",
                        column: x => x.Id_estudiante,
                        principalTable: "Estudiante",
                        principalColumn: "Id_estudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permiso_Profesor_Id_profesor",
                        column: x => x.Id_profesor,
                        principalTable: "Profesor",
                        principalColumn: "Id_profesor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_usuario = table.Column<int>(type: "int", nullable: false),
                    Tipo_rol = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id_rol);
                    table.ForeignKey(
                        name: "FK_Rol_Usuario_Id_usuario",
                        column: x => x.Id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "Id_usuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Id_carrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_curso = table.Column<int>(type: "int", nullable: false),
                    Id_coordinador = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false),
                    Duracion = table.Column<string>(type: "longtext", nullable: false),
                    Carrera_habilitada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Id_carrera);
                    table.ForeignKey(
                        name: "FK_Carrera_Coordinador_Id_coordinador",
                        column: x => x.Id_coordinador,
                        principalTable: "Coordinador",
                        principalColumn: "Id_coordinador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrera_Curso_Id_curso",
                        column: x => x.Id_curso,
                        principalTable: "Curso",
                        principalColumn: "Id_curso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    Id_horario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_curso = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<string>(type: "longtext", nullable: false),
                    Hora_inicio = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    Hora_fin = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    Horario_habilitado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Id_horario);
                    table.ForeignKey(
                        name: "FK_Horario_Curso_Id_curso",
                        column: x => x.Id_curso,
                        principalTable: "Curso",
                        principalColumn: "Id_curso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Jornada",
                columns: table => new
                {
                    Id_jornada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_curso = table.Column<int>(type: "int", nullable: false),
                    Tipo_jornada = table.Column<string>(type: "longtext", nullable: false),
                    Jornada_habilitada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jornada", x => x.Id_jornada);
                    table.ForeignKey(
                        name: "FK_Jornada_Curso_Id_curso",
                        column: x => x.Id_curso,
                        principalTable: "Curso",
                        principalColumn: "Id_curso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seccion",
                columns: table => new
                {
                    Id_seccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_curso = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Numero_semestre = table.Column<string>(type: "longtext", nullable: false),
                    Numero_estudiantes = table.Column<int>(type: "int", nullable: false),
                    Seccion_habilitada = table.Column<string>(type: "longtext", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seccion", x => x.Id_seccion);
                    table.ForeignKey(
                        name: "FK_Seccion_Curso_Id_curso",
                        column: x => x.Id_curso,
                        principalTable: "Curso",
                        principalColumn: "Id_curso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Id_coordinador",
                table: "Asistencia",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Id_estudiante",
                table: "Asistencia",
                column: "Id_estudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Id_profesor",
                table: "Asistencia",
                column: "Id_profesor");

            migrationBuilder.CreateIndex(
                name: "IX_Carrera_Id_coordinador",
                table: "Carrera",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Carrera_Id_curso",
                table: "Carrera",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_Id_detalle_persona",
                table: "Contacto",
                column: "Id_detalle_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinador_Id_persona",
                table: "Coordinador",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_Id_coordinador",
                table: "Curso",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_Id_estudiante",
                table: "Curso",
                column: "Id_estudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_Id_profesor",
                table: "Curso",
                column: "Id_profesor");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePersona_Id_persona",
                table: "DetallePersona",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_Id_detalle_persona",
                table: "Direccion",
                column: "Id_detalle_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_Id_persona",
                table: "Estudiante",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Id_curso",
                table: "Horario",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Jornada_Id_curso",
                table: "Jornada",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_Id_coordinador",
                table: "Permiso",
                column: "Id_coordinador");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_Id_estudiante",
                table: "Permiso",
                column: "Id_estudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_Id_profesor",
                table: "Permiso",
                column: "Id_profesor");

            migrationBuilder.CreateIndex(
                name: "IX_Profesor_Id_persona",
                table: "Profesor",
                column: "Id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Id_usuario",
                table: "Rol",
                column: "Id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Seccion_Id_curso",
                table: "Seccion",
                column: "Id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id_detalle_persona",
                table: "Usuario",
                column: "Id_detalle_persona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Jornada");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Seccion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "DetallePersona");

            migrationBuilder.DropTable(
                name: "Coordinador");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
