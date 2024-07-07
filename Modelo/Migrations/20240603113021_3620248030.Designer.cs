﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(SistemaBibliotecario))]
    [Migration("20240603113021_3620248030")]
    partial class _3620248030
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Devolucion", b =>
                {
                    b.Property<int>("DevolucionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevolucionId"));

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("int");

                    b.HasKey("DevolucionId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("Devoluciones");

                    b.HasData(
                        new
                        {
                            DevolucionId = 1,
                            FechaDevolucion = new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3334),
                            PrestamoId = 1
                        },
                        new
                        {
                            DevolucionId = 2,
                            FechaDevolucion = new DateTime(2024, 6, 1, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3336),
                            PrestamoId = 2
                        },
                        new
                        {
                            DevolucionId = 3,
                            FechaDevolucion = new DateTime(2024, 6, 2, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3337),
                            PrestamoId = 3
                        });
                });

            modelBuilder.Entity("Entidades.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroId"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            LibroId = 1,
                            Autor = "Gabriel García Márquez",
                            Disponible = true,
                            Titulo = "Cien años de soledad",
                            Ubicacion = "M1"
                        },
                        new
                        {
                            LibroId = 2,
                            Autor = "Miguel de Cervantes",
                            Disponible = true,
                            Titulo = "Don Quijote de la Mancha",
                            Ubicacion = "C1"
                        },
                        new
                        {
                            LibroId = 3,
                            Autor = "Antoine de Saint-Exupéry",
                            Disponible = true,
                            Titulo = "El principito",
                            Ubicacion = "S1"
                        },
                        new
                        {
                            LibroId = 4,
                            Autor = "George Orwell",
                            Disponible = true,
                            Titulo = "1984",
                            Ubicacion = "F2"
                        },
                        new
                        {
                            LibroId = 5,
                            Autor = "Harper Lee",
                            Disponible = true,
                            Titulo = "Matar a un ruiseñor",
                            Ubicacion = "A3"
                        },
                        new
                        {
                            LibroId = 6,
                            Autor = "Homero",
                            Disponible = true,
                            Titulo = "La Odisea",
                            Ubicacion = "G4"
                        },
                        new
                        {
                            LibroId = 7,
                            Autor = "Fiódor Dostoyevski",
                            Disponible = true,
                            Titulo = "Crimen y castigo",
                            Ubicacion = "H5"
                        },
                        new
                        {
                            LibroId = 8,
                            Autor = "Jane Austen",
                            Disponible = true,
                            Titulo = "Orgullo y prejuicio",
                            Ubicacion = "J6"
                        },
                        new
                        {
                            LibroId = 9,
                            Autor = "Homero",
                            Disponible = true,
                            Titulo = "La Ilíada",
                            Ubicacion = "K7"
                        },
                        new
                        {
                            LibroId = 10,
                            Autor = "Marcel Proust",
                            Disponible = true,
                            Titulo = "En busca del tiempo perdido",
                            Ubicacion = "L8"
                        },
                        new
                        {
                            LibroId = 11,
                            Autor = "James Joyce",
                            Disponible = true,
                            Titulo = "Ulises",
                            Ubicacion = "M9"
                        });
                });

            modelBuilder.Entity("Entidades.Multa", b =>
                {
                    b.Property<int>("MultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MultaId"));

                    b.Property<DateTime>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Pagada")
                        .HasColumnType("bit");

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("MultaId");

                    b.HasIndex("SocioId");

                    b.ToTable("Multas");

                    b.HasData(
                        new
                        {
                            MultaId = 1,
                            FechaFinalizacion = new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3375),
                            FechaInicio = new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3371),
                            Pagada = true,
                            SocioId = 1
                        });
                });

            modelBuilder.Entity("Entidades.Prestamo", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrestamoId"));

                    b.Property<int>("CarritoId")
                        .HasColumnType("int");

                    b.Property<bool>("EnPrestamo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("PrestamoId");

                    b.HasIndex("LibroId");

                    b.HasIndex("SocioId");

                    b.ToTable("Prestamos");

                    b.HasData(
                        new
                        {
                            PrestamoId = 1,
                            CarritoId = 1,
                            EnPrestamo = true,
                            FechaDevolucion = new DateTime(2024, 5, 24, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3305),
                            FechaPrestamo = new DateTime(2024, 5, 24, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3288),
                            LibroId = 1,
                            SocioId = 1
                        },
                        new
                        {
                            PrestamoId = 2,
                            CarritoId = 2,
                            EnPrestamo = true,
                            FechaDevolucion = new DateTime(2024, 5, 29, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3311),
                            FechaPrestamo = new DateTime(2024, 5, 29, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3311),
                            LibroId = 2,
                            SocioId = 2
                        },
                        new
                        {
                            PrestamoId = 3,
                            CarritoId = 3,
                            EnPrestamo = true,
                            FechaDevolucion = new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3313),
                            FechaPrestamo = new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3313),
                            LibroId = 3,
                            SocioId = 3
                        });
                });

            modelBuilder.Entity("Entidades.Regla", b =>
                {
                    b.Property<int>("ReglaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReglaId"));

                    b.Property<int>("DiasMulta")
                        .HasColumnType("int");

                    b.Property<int>("DiasPrestamo")
                        .HasColumnType("int");

                    b.Property<int>("MaxLibrosPorUsuario")
                        .HasColumnType("int");

                    b.HasKey("ReglaId");

                    b.ToTable("Reglas");

                    b.HasData(
                        new
                        {
                            ReglaId = 1,
                            DiasMulta = 7,
                            DiasPrestamo = 7,
                            MaxLibrosPorUsuario = 3
                        });
                });

            modelBuilder.Entity("Entidades.Socio", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocioId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantidadLibros")
                        .HasColumnType("int");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("MultadoHasta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocioId");

                    b.ToTable("Socios");

                    b.HasData(
                        new
                        {
                            SocioId = 1,
                            Apellido = "González",
                            CantidadLibros = 0,
                            Dni = 12345678,
                            Habilitado = true,
                            Nombre = "Ana"
                        },
                        new
                        {
                            SocioId = 2,
                            Apellido = "Martínez",
                            CantidadLibros = 0,
                            Dni = 87654321,
                            Habilitado = true,
                            Nombre = "Juan"
                        },
                        new
                        {
                            SocioId = 3,
                            Apellido = "López",
                            CantidadLibros = 0,
                            Dni = 98765432,
                            Habilitado = true,
                            Nombre = "María"
                        },
                        new
                        {
                            SocioId = 4,
                            Apellido = "Pérez",
                            CantidadLibros = 0,
                            Dni = 23456789,
                            Habilitado = true,
                            Nombre = "Luis"
                        },
                        new
                        {
                            SocioId = 5,
                            Apellido = "García",
                            CantidadLibros = 0,
                            Dni = 34567890,
                            Habilitado = true,
                            Nombre = "Sofía"
                        },
                        new
                        {
                            SocioId = 6,
                            Apellido = "Rodríguez",
                            CantidadLibros = 0,
                            Dni = 45678901,
                            Habilitado = true,
                            Nombre = "Carlos"
                        },
                        new
                        {
                            SocioId = 7,
                            Apellido = "Fernández",
                            CantidadLibros = 0,
                            Dni = 56789012,
                            Habilitado = true,
                            Nombre = "Lucía"
                        },
                        new
                        {
                            SocioId = 8,
                            Apellido = "Sánchez",
                            CantidadLibros = 0,
                            Dni = 67890123,
                            Habilitado = true,
                            Nombre = "Miguel"
                        },
                        new
                        {
                            SocioId = 9,
                            Apellido = "Martín",
                            CantidadLibros = 0,
                            Dni = 78901234,
                            Habilitado = true,
                            Nombre = "Isabel"
                        },
                        new
                        {
                            SocioId = 10,
                            Apellido = "Ruiz",
                            CantidadLibros = 0,
                            Dni = 89012345,
                            Habilitado = true,
                            Nombre = "Fernando"
                        },
                        new
                        {
                            SocioId = 11,
                            Apellido = "Hernández",
                            CantidadLibros = 0,
                            Dni = 90123456,
                            Habilitado = true,
                            Nombre = "Patricia"
                        });
                });

            modelBuilder.Entity("Entidades.Devolucion", b =>
                {
                    b.HasOne("Entidades.Prestamo", "Prestamo")
                        .WithMany()
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("Entidades.Multa", b =>
                {
                    b.HasOne("Entidades.Socio", "Socio")
                        .WithMany()
                        .HasForeignKey("SocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("Entidades.Prestamo", b =>
                {
                    b.HasOne("Entidades.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Socio", "Socio")
                        .WithMany()
                        .HasForeignKey("SocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");

                    b.Navigation("Socio");
                });
#pragma warning restore 612, 618
        }
    }
}
