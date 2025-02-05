﻿// <auto-generated />
using System;
using MiVeterinaria.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiVeterinaria.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentarios");

                    b.Property<bool>("EstaDisponible");

                    b.Property<DateTime>("Fecha");

                    b.Property<int?>("MascotaId");

                    b.Property<int?>("PropietarioId");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentarios");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Fecha");

                    b.Property<int?>("MascotaId");

                    b.Property<int?>("TipoServicioId");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("TipoServicioId");

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentarios");

                    b.Property<string>("ImagenUrl");

                    b.Property<DateTime>("Nacimiento");

                    b.Property<int?>("PropietarioId");

                    b.Property<string>("Raza")
                        .HasMaxLength(50);

                    b.Property<int?>("TipoMascotaId");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("TipoMascotaId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("direccion")
                        .HasMaxLength(100);

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("telCelular")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("telFijo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoMascotas");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.TipoServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoServicios");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Agenda", b =>
                {
                    b.HasOne("MiVeterinaria.Web.Data.Entities.Mascota", "Mascota")
                        .WithMany("Agendas")
                        .HasForeignKey("MascotaId");

                    b.HasOne("MiVeterinaria.Web.Data.Entities.Propietario", "Propietario")
                        .WithMany("Agendas")
                        .HasForeignKey("PropietarioId");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Historia", b =>
                {
                    b.HasOne("MiVeterinaria.Web.Data.Entities.Mascota", "Mascota")
                        .WithMany("Historias")
                        .HasForeignKey("MascotaId");

                    b.HasOne("MiVeterinaria.Web.Data.Entities.TipoServicio", "TipoServicio")
                        .WithMany("Historias")
                        .HasForeignKey("TipoServicioId");
                });

            modelBuilder.Entity("MiVeterinaria.Web.Data.Entities.Mascota", b =>
                {
                    b.HasOne("MiVeterinaria.Web.Data.Entities.Propietario", "Propietario")
                        .WithMany("Mascotas")
                        .HasForeignKey("PropietarioId");

                    b.HasOne("MiVeterinaria.Web.Data.Entities.TipoMascota", "TipoMascota")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoMascotaId");
                });
#pragma warning restore 612, 618
        }
    }
}
