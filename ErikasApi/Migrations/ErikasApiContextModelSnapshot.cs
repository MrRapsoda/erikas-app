﻿// <auto-generated />
using ErikasApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ErikasApi.Migrations
{
    [DbContext(typeof(ErikasApiContext))]
    partial class ErikasApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ErikasApi.Models.Trajes2", b =>
                {
                    b.Property<int>("idTraje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ajuste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("Talla")
                        .HasColumnType("int");

                    b.Property<string>("Tela")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTraje");

                    b.ToTable("Trajes2");
                });

            modelBuilder.Entity("ErikasApi.Models.VQuinceanos", b =>
                {
                    b.Property<int>("idQuinceanos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ajuste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoQ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("talla")
                        .HasColumnType("int");

                    b.Property<string>("tela")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idQuinceanos");

                    b.ToTable("VQuinceanos");
                });

            modelBuilder.Entity("ErikasApi.Models.Vestido", b =>
                {
                    b.Property<int>("idVestidos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estilo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("talla")
                        .HasColumnType("int");

                    b.Property<string>("tela")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idVestidos");

                    b.ToTable("Vestido");
                });

            modelBuilder.Entity("ErikasApi.Models.accesorioss", b =>
                {
                    b.Property<int>("idAccesorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoAccesorio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAccesorio");

                    b.ToTable("accesorioss");
                });
#pragma warning restore 612, 618
        }
    }
}
