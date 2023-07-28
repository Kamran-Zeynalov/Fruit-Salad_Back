﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProperSalads.DAL;

#nullable disable

namespace ProperSalads.Migrations
{
    [DbContext(typeof(SaladPageDbContext))]
    [Migration("20230716073114_CreateFruitAndFruitSaladsRelations")]
    partial class CreateFruitAndFruitSaladsRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProperSalads.Models.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vitamin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitSalad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FruitSalads");
                });

            modelBuilder.Entity("ProperSalads.Models.SaladAndFruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FruitId")
                        .HasColumnType("int");

                    b.Property<int?>("FruitSaladId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FruitId");

                    b.HasIndex("FruitSaladId");

                    b.ToTable("SaladAndFruits");
                });

            modelBuilder.Entity("ProperSalads.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ProperSalads.Models.Vitamin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FruitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FruitId");

                    b.ToTable("Vitamin");
                });

            modelBuilder.Entity("ProperSalads.Models.SaladAndFruit", b =>
                {
                    b.HasOne("ProperSalads.Models.Fruit", "Fruit")
                        .WithMany("SaladAndFruits")
                        .HasForeignKey("FruitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProperSalads.Models.FruitSalad", "FruitSalad")
                        .WithMany("SaladAndFruits")
                        .HasForeignKey("FruitSaladId");

                    b.Navigation("Fruit");

                    b.Navigation("FruitSalad");
                });

            modelBuilder.Entity("ProperSalads.Models.Vitamin", b =>
                {
                    b.HasOne("ProperSalads.Models.Fruit", "Fruit")
                        .WithMany("Vitamins")
                        .HasForeignKey("FruitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fruit");
                });

            modelBuilder.Entity("ProperSalads.Models.Fruit", b =>
                {
                    b.Navigation("SaladAndFruits");

                    b.Navigation("Vitamins");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitSalad", b =>
                {
                    b.Navigation("SaladAndFruits");
                });
#pragma warning restore 612, 618
        }
    }
}
