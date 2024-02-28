﻿// <auto-generated />
using Lotto5API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lotto5API.Migrations
{
    [DbContext(typeof(Lotto5APIContext))]
    [Migration("20240227122141_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lotto5Adat.Models.LottoSzam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Szam1")
                        .HasColumnType("int");

                    b.Property<int>("Szam2")
                        .HasColumnType("int");

                    b.Property<int>("Szam3")
                        .HasColumnType("int");

                    b.Property<int>("Szam4")
                        .HasColumnType("int");

                    b.Property<int>("Szam5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LottoSzam");
                });
#pragma warning restore 612, 618
        }
    }
}
