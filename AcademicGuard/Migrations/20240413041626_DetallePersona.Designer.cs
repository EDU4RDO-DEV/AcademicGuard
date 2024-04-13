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
    [Migration("20240413041626_DetallePersona")]
    partial class DetallePersona
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

            modelBuilder.Entity("AcademicGuard.Models.DetallePersona", b =>
                {
                    b.HasOne("AcademicGuard.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("Id_persona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
