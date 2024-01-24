﻿// <auto-generated />
using System;
using API_BOCHA_STORE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_BOCHA_STORE.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231212050458_Creacion_DB")]
    partial class Creacion_DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_BOCHA_STORE.Models.Marca", b =>
                {
                    b.Property<int>("idMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMarca"));

                    b.Property<string>("nombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMarca");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            idMarca = 1,
                            nombreMarca = "Adidas"
                        },
                        new
                        {
                            idMarca = 2,
                            nombreMarca = "Nike"
                        });
                });

            modelBuilder.Entity("API_BOCHA_STORE.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<string>("descripcionProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("idProovedor")
                        .HasColumnType("int");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("idProducto");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            idProducto = 1,
                            descripcionProducto = "Camiseta Oversized",
                            fechaCreacion = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idProovedor = 1,
                            nombreProducto = "Camiseta Negra",
                            precio = 19.989999999999998,
                            stock = 0
                        },
                        new
                        {
                            idProducto = 2,
                            descripcionProducto = "Pantalon Deportivo",
                            fechaCreacion = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idProovedor = 2,
                            nombreProducto = "Pantalon Negro",
                            precio = 15.99,
                            stock = 0
                        });
                });

            modelBuilder.Entity("API_BOCHA_STORE.Models.Proovedor", b =>
                {
                    b.Property<int>("idProovedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProovedor"));

                    b.Property<int>("duracionContrato")
                        .HasColumnType("int");

                    b.Property<string>("nombreProovedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precioImportacion")
                        .HasColumnType("float");

                    b.HasKey("idProovedor");

                    b.ToTable("Proovedor");

                    b.HasData(
                        new
                        {
                            idProovedor = 1,
                            duracionContrato = 3,
                            nombreProovedor = "Fast & Good",
                            precioImportacion = 90.0
                        },
                        new
                        {
                            idProovedor = 2,
                            duracionContrato = 3,
                            nombreProovedor = "Import S.A",
                            precioImportacion = 70.0
                        },
                        new
                        {
                            idProovedor = 3,
                            duracionContrato = 3,
                            nombreProovedor = "Import Facil",
                            precioImportacion = 65.0
                        });
                });

            modelBuilder.Entity("API_BOCHA_STORE.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            idUsuario = 1,
                            password = "admin123",
                            username = "admin"
                        },
                        new
                        {
                            idUsuario = 2,
                            password = "cliente123",
                            username = "cliente"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
