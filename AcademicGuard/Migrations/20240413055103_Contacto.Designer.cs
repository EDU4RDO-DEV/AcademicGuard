﻿// <auto-generated />
using System;
using AcademicGuard.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademicGuard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240413055103_Contacto")]
    partial class Contacto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AcademicGuard.Models.Asistencia", b =>
                {
                    b.Property<int>("Id_asistencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Id_coordinador")
                        .HasColumnType("int");

                    b.Property<int>("Id_estudiante")
                        .HasColumnType("int");

                    b.Property<int>("Id_profesor")
                        .HasColumnType("int");

                    b.HasKey("Id_asistencia");

                    b.HasIndex("Id_coordinador");

                    b.HasIndex("Id_estudiante");

                    b.HasIndex("Id_profesor");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("AcademicGuard.Models.Carrera", b =>
                {
                    b.Property<int>("Id_carrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Carrera_habilitada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_coordinador")
                        .HasColumnType("int");

                    b.Property<int>("Id_curso")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_carrera");

                    b.HasIndex("Id_coordinador");

                    b.HasIndex("Id_curso");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("AcademicGuard.Models.Contacto", b =>
                {
                    b.Property<int>("Id_contacto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_detalle_persona")
                        .HasColumnType("int");

                    b.Property<string>("Telefono_1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono_2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono_casa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_contacto");

                    b.HasIndex("Id_detalle_persona");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("AcademicGuard.Models.Coordinador", b =>
                {
                    b.Property<int>("Id_coordinador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fecha_contratacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_persona")
                        .HasColumnType("int");

                    b.Property<string>("Periodo_mandato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_coordinador");

                    b.HasIndex("Id_persona");

                    b.ToTable("Coordinador");
                });

            modelBuilder.Entity("AcademicGuard.Models.Curso", b =>
                {
                    b.Property<int>("Id_curso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_coordinador")
                        .HasColumnType("int");

                    b.Property<int>("Id_estudiante")
                        .HasColumnType("int");

                    b.Property<int>("Id_profesor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_curso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_curso");

                    b.HasIndex("Id_coordinador");

                    b.HasIndex("Id_estudiante");

                    b.HasIndex("Id_profesor");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("AcademicGuard.Models.DetallePersona", b =>
                {
                    b.Property<int>("Id_detalle_persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_persona")
                        .HasColumnType("int");

                    b.HasKey("Id_detalle_persona");

                    b.HasIndex("Id_persona");

                    b.ToTable("DetallePersona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Direccion", b =>
                {
                    b.Property<int>("Id_direccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avenida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Codigo_postal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_detalle_persona")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Zona")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_direccion");

                    b.HasIndex("Id_detalle_persona");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("AcademicGuard.Models.Estudiante", b =>
                {
                    b.Property<int>("Id_estudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Año_ingreso")
                        .HasColumnType("int");

                    b.Property<int>("Id_persona")
                        .HasColumnType("int");

                    b.HasKey("Id_estudiante");

                    b.HasIndex("Id_persona");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("AcademicGuard.Models.Horario", b =>
                {
                    b.Property<int>("Id_horario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("Hora_fin")
                        .HasColumnType("time(6)");

                    b.Property<TimeSpan>("Hora_inicio")
                        .HasColumnType("time(6)");

                    b.Property<bool>("Horario_habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Id_curso")
                        .HasColumnType("int");

                    b.HasKey("Id_horario");

                    b.HasIndex("Id_curso");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("AcademicGuard.Models.Jornada", b =>
                {
                    b.Property<int>("Id_jornada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_curso")
                        .HasColumnType("int");

                    b.Property<bool>("Jornada_habilitada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tipo_jornada")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_jornada");

                    b.HasIndex("Id_curso");

                    b.ToTable("Jornada");
                });

            modelBuilder.Entity("AcademicGuard.Models.Permiso", b =>
                {
                    b.Property<int>("Id_permiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Documento_adjunto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha_respuesta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha_solicitud")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_coordinador")
                        .HasColumnType("int");

                    b.Property<int>("Id_estudiante")
                        .HasColumnType("int");

                    b.Property<int>("Id_profesor")
                        .HasColumnType("int");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_permiso");

                    b.HasIndex("Id_coordinador");

                    b.HasIndex("Id_estudiante");

                    b.HasIndex("Id_profesor");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("AcademicGuard.Models.Persona", b =>
                {
                    b.Property<int>("Id_persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos_extras")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Dpi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha_creacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha_modificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha_nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombres_extras")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Persona_habilitada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Primer_apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Primer_nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Segundo_apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Segundo_nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Usuario_modificacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_persona");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("AcademicGuard.Models.Profesor", b =>
                {
                    b.Property<int>("Id_profesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fecha_contratacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_persona")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_profesor");

                    b.HasIndex("Id_persona");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("AcademicGuard.Models.Rol", b =>
                {
                    b.Property<int>("Id_rol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_rol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_rol");

                    b.HasIndex("Id_usuario");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("AcademicGuard.Models.Seccion", b =>
                {
                    b.Property<int>("Id_seccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id_curso")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Numero_estudiantes")
                        .HasColumnType("int");

                    b.Property<string>("Numero_semestre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Seccion_habilitada")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_seccion");

                    b.HasIndex("Id_curso");

                    b.ToTable("Seccion");
                });

            modelBuilder.Entity("AcademicGuard.Models.Usuario", b =>
                {
                    b.Property<int>("Id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo_institucional")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_detalle_persona")
                        .HasColumnType("int");

                    b.HasKey("Id_usuario");

                    b.HasIndex("Id_detalle_persona");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AcademicGuard.Models.Asistencia", b =>
                {
                    b.HasOne("AcademicGuard.Models.Coordinador", "Coordinador")
                        .WithMany()
                        .HasForeignKey("Id_coordinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("Id_estudiante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("Id_profesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinador");

                    b.Navigation("Estudiante");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AcademicGuard.Models.Carrera", b =>
                {
                    b.HasOne("AcademicGuard.Models.Coordinador", "Coordinador")
                        .WithMany()
                        .HasForeignKey("Id_coordinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("Id_curso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinador");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("AcademicGuard.Models.Contacto", b =>
                {
                    b.HasOne("AcademicGuard.Models.DetallePersona", "DetallePersona")
                        .WithMany()
                        .HasForeignKey("Id_detalle_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetallePersona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Coordinador", b =>
                {
                    b.HasOne("AcademicGuard.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Id_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Curso", b =>
                {
                    b.HasOne("AcademicGuard.Models.Coordinador", "Coordinador")
                        .WithMany()
                        .HasForeignKey("Id_coordinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("Id_estudiante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("Id_profesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinador");

                    b.Navigation("Estudiante");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AcademicGuard.Models.DetallePersona", b =>
                {
                    b.HasOne("AcademicGuard.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Id_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Direccion", b =>
                {
                    b.HasOne("AcademicGuard.Models.DetallePersona", "DetallePersona")
                        .WithMany()
                        .HasForeignKey("Id_detalle_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetallePersona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Estudiante", b =>
                {
                    b.HasOne("AcademicGuard.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Id_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Horario", b =>
                {
                    b.HasOne("AcademicGuard.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("Id_curso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("AcademicGuard.Models.Jornada", b =>
                {
                    b.HasOne("AcademicGuard.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("Id_curso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("AcademicGuard.Models.Permiso", b =>
                {
                    b.HasOne("AcademicGuard.Models.Coordinador", "Coordinador")
                        .WithMany()
                        .HasForeignKey("Id_coordinador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("Id_estudiante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcademicGuard.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("Id_profesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinador");

                    b.Navigation("Estudiante");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("AcademicGuard.Models.Profesor", b =>
                {
                    b.HasOne("AcademicGuard.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Id_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AcademicGuard.Models.Rol", b =>
                {
                    b.HasOne("AcademicGuard.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AcademicGuard.Models.Seccion", b =>
                {
                    b.HasOne("AcademicGuard.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("Id_curso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("AcademicGuard.Models.Usuario", b =>
                {
                    b.HasOne("AcademicGuard.Models.DetallePersona", "DetallePersona")
                        .WithMany()
                        .HasForeignKey("Id_detalle_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetallePersona");
                });
#pragma warning restore 612, 618
        }
    }
}
