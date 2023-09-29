﻿// <auto-generated />
using System;
using DietApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DietApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DietApp.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.FoodPhoto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FoodPhotos");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.UserDayMealFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodPhotoID")
                        .HasColumnType("int");

                    b.Property<int>("Meal")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.Property<decimal>("Portion")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserFoodID")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<int>("UserID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("ID");

                    b.HasIndex("FoodPhotoID");

                    b.HasIndex("UserFoodID");

                    b.HasIndex("UserID");

                    b.ToTable("UserDayMealFoods");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.UserFood", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("UserFoods");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.UserDayMealFood", b =>
                {
                    b.HasOne("DietApp.Entities.Concrete.FoodPhoto", "FoodPhoto")
                        .WithMany("UserDayMealFoods")
                        .HasForeignKey("FoodPhotoID");

                    b.HasOne("DietApp.Entities.Concrete.UserFood", "UserFood")
                        .WithMany("UserDayMealFoods")
                        .HasForeignKey("UserFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.Concrete.User", "User")
                        .WithMany("UserDayMealFoods")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodPhoto");

                    b.Navigation("User");

                    b.Navigation("UserFood");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.UserFood", b =>
                {
                    b.HasOne("DietApp.Entities.Concrete.Category", "Category")
                        .WithMany("UserFoods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.Concrete.User", "User")
                        .WithMany("UserFoods")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.Category", b =>
                {
                    b.Navigation("UserFoods");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.FoodPhoto", b =>
                {
                    b.Navigation("UserDayMealFoods");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserDayMealFoods");

                    b.Navigation("UserFoods");
                });

            modelBuilder.Entity("DietApp.Entities.Concrete.UserFood", b =>
                {
                    b.Navigation("UserDayMealFoods");
                });
#pragma warning restore 612, 618
        }
    }
}