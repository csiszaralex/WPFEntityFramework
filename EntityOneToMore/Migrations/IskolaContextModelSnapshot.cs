﻿// <auto-generated />
using System;
using EntityOneToMore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityOneToMore.Migrations
{
    [DbContext(typeof(IskolaContext))]
    partial class IskolaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntityOneToMore.Osztaly", b =>
                {
                    b.Property<int>("osztalyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("osztalyFonok")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("osztalyNev")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.HasKey("osztalyId");

                    b.ToTable("Osztaly");

                    b.HasData(
                        new
                        {
                            osztalyId = 1,
                            osztalyFonok = "Józsi",
                            osztalyNev = "9A"
                        },
                        new
                        {
                            osztalyId = 2,
                            osztalyFonok = "Kowa",
                            osztalyNev = "13A"
                        });
                });

            modelBuilder.Entity("EntityOneToMore.Tanulo", b =>
                {
                    b.Property<int>("tanuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("osztalyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("szuletesiDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("tanuloNev")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("tanuloId");

                    b.HasIndex("osztalyId");

                    b.ToTable("Tanulo");

                    b.HasData(
                        new
                        {
                            tanuloId = 1,
                            osztalyId = 1,
                            szuletesiDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tanuloNev = "Béla"
                        },
                        new
                        {
                            tanuloId = 2,
                            osztalyId = 1,
                            szuletesiDatum = new DateTime(2005, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tanuloNev = "Cili"
                        },
                        new
                        {
                            tanuloId = 3,
                            osztalyId = 2,
                            szuletesiDatum = new DateTime(2003, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tanuloNev = "Kata"
                        });
                });

            modelBuilder.Entity("EntityOneToMore.Tanulo", b =>
                {
                    b.HasOne("EntityOneToMore.Osztaly", "Osztaly")
                        .WithMany("Tanulok")
                        .HasForeignKey("osztalyId");
                });
#pragma warning restore 612, 618
        }
    }
}
