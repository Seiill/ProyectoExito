﻿// <auto-generated />
using System;
using ConsolasExito.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsolasExito.App.Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20210925172140_ModificarTablas1")]
    partial class ModificarTablas1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ConsolasExito.App.Dominio.Consola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CapAlmacenamiento")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumControles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<int>("TipoAlmacenamiento")
                        .HasColumnType("int");

                    b.Property<int>("VelocidadProcesador")
                        .HasColumnType("int");

                    b.Property<int>("VelocidadRam")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("controlcId")
                        .HasColumnType("int");

                    b.Property<int?>("videojuegoscId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("controlcId");

                    b.HasIndex("videojuegoscId");

                    b.ToTable("Consolas");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Control", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Controles");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolPerson")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("accesoReportes")
                        .HasColumnType("bit");

                    b.Property<int?>("sucursalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sucursalId");

                    b.ToTable("Empleados");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Empleado");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumeroFactura")
                        .HasColumnType("int");

                    b.Property<int?>("SucursalVentaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorVenta")
                        .HasColumnType("float");

                    b.Property<int?>("empleadoventaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalVentaId");

                    b.HasIndex("empleadoventaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Videojuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Multiplataforma")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videojuegos");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("ConsolasExito.App.Dominio.Empleado");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Consola", b =>
                {
                    b.HasOne("ConsolasExito.App.Dominio.Control", "controlc")
                        .WithMany()
                        .HasForeignKey("controlcId");

                    b.HasOne("ConsolasExito.App.Dominio.Videojuego", "videojuegosc")
                        .WithMany()
                        .HasForeignKey("videojuegoscId");

                    b.Navigation("controlc");

                    b.Navigation("videojuegosc");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Empleado", b =>
                {
                    b.HasOne("ConsolasExito.App.Dominio.Sucursal", "sucursal")
                        .WithMany()
                        .HasForeignKey("sucursalId");

                    b.Navigation("sucursal");
                });

            modelBuilder.Entity("ConsolasExito.App.Dominio.Venta", b =>
                {
                    b.HasOne("ConsolasExito.App.Dominio.Sucursal", "SucursalVenta")
                        .WithMany()
                        .HasForeignKey("SucursalVentaId");

                    b.HasOne("ConsolasExito.App.Dominio.Empleado", "empleadoventa")
                        .WithMany()
                        .HasForeignKey("empleadoventaId");

                    b.Navigation("empleadoventa");

                    b.Navigation("SucursalVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
