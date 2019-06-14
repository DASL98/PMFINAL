﻿// <auto-generated />
using AA.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AA.Migrations
{
    [DbContext(typeof(MascotaContext))]
    [Migration("20190613211610_membresia1")]
    partial class membresia1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AA.Models.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoMascota")
                        .IsRequired();

                    b.Property<int>("Edad");

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("NombreMascota")
                        .IsRequired();

                    b.Property<int>("Peso");

                    b.Property<int>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("AA.Models.Solicitud", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired();

                    b.Property<string>("CodigoM")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("AA.Models.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("AA.Models.Mascota", b =>
                {
                    b.HasOne("AA.Models.TipoMascota", "Tipo")
                        .WithMany("Mascotas")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
