﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NordicForslag.Data;

#nullable disable

namespace NordicForslag.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NordicForslag.Models.Forslag", b =>
                {
                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DatoRegistrert")
                        .HasColumnType("datetime2");

                    b.Property<string>("Forbedringsforslag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Løsning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mål")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Årsak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Navn");

                    b.ToTable("Forslags");
                });
#pragma warning restore 612, 618
        }
    }
}
