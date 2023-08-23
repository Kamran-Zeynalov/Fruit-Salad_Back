﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProperSalads.DAL;

#nullable disable

namespace ProperSalads.Migrations
{
    [DbContext(typeof(SaladPageDbContext))]
    partial class SaladPageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProperSalads.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fruitSaladId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("fruitSaladId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("ProperSalads.Models.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Ckal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FruitSalads");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitsaladImages", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FruitsaladImages");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitSaladSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FruitSaladId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FruitSaladId");

                    b.HasIndex("SizeId");

                    b.ToTable("FruitSaladSizes");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitVitamin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FruitId")
                        .HasColumnType("int");

                    b.Property<int>("VitaminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FruitId");

                    b.HasIndex("VitaminId");

                    b.ToTable("FruitSaladVitamins");
                });

            modelBuilder.Entity("ProperSalads.Models.SaladAndFruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FruitId")
                        .HasColumnType("int");

                    b.Property<int>("FruitSaladId")
                        .HasColumnType("int");

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

            modelBuilder.Entity("ProperSalads.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ProperSalads.Models.Vitamin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vitamin");
                });

            modelBuilder.Entity("ProperSalads.Models.Feedback", b =>
                {
                    b.HasOne("ProperSalads.Models.FruitSalad", "fruitSalad")
                        .WithMany("FeedBacks")
                        .HasForeignKey("fruitSaladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fruitSalad");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitsaladImages", b =>
                {
                    b.HasOne("ProperSalads.Models.FruitSalad", "FruitSalad")
                        .WithOne("GetFruitsaladImages")
                        .HasForeignKey("ProperSalads.Models.FruitsaladImages", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FruitSalad");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitSaladSize", b =>
                {
                    b.HasOne("ProperSalads.Models.FruitSalad", "FruitSalad")
                        .WithMany("fruitSaladSizes")
                        .HasForeignKey("FruitSaladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProperSalads.Models.Size", "Size")
                        .WithMany("fruitSaladSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FruitSalad");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitVitamin", b =>
                {
                    b.HasOne("ProperSalads.Models.Fruit", "Fruit")
                        .WithMany("fruitSaladVitamins")
                        .HasForeignKey("FruitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProperSalads.Models.Vitamin", "Vitamin")
                        .WithMany("fruitSaladVitamins")
                        .HasForeignKey("VitaminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fruit");

                    b.Navigation("Vitamin");
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
                        .HasForeignKey("FruitSaladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fruit");

                    b.Navigation("FruitSalad");
                });

            modelBuilder.Entity("ProperSalads.Models.Fruit", b =>
                {
                    b.Navigation("SaladAndFruits");

                    b.Navigation("fruitSaladVitamins");
                });

            modelBuilder.Entity("ProperSalads.Models.FruitSalad", b =>
                {
                    b.Navigation("FeedBacks");

                    b.Navigation("GetFruitsaladImages");

                    b.Navigation("SaladAndFruits");

                    b.Navigation("fruitSaladSizes");
                });

            modelBuilder.Entity("ProperSalads.Models.Size", b =>
                {
                    b.Navigation("fruitSaladSizes");
                });

            modelBuilder.Entity("ProperSalads.Models.Vitamin", b =>
                {
                    b.Navigation("fruitSaladVitamins");
                });
#pragma warning restore 612, 618
        }
    }
}
