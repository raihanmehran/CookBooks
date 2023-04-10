﻿// <auto-generated />
using System;
using CookBooks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookBooks.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230409192615_start001")]
    partial class start001
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CookBook.Model.AppUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("CookBook.Model.Instructions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InstructionsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstructionsId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("CookBook.Model.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<int?>("AppUser")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RecipeDifficultyLevel")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.HasIndex("AppUser");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("CookBooks.Model.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ingredient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IngredientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookBook.Model.Instructions", b =>
                {
                    b.HasOne("CookBook.Model.Recipe", null)
                        .WithMany("Instructions")
                        .HasForeignKey("InstructionsId");
                });

            modelBuilder.Entity("CookBook.Model.Recipe", b =>
                {
                    b.HasOne("CookBook.Model.AppUser", "Owner")
                        .WithMany("Recipes")
                        .HasForeignKey("AppUser");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CookBooks.Model.Ingredients", b =>
                {
                    b.HasOne("CookBook.Model.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("IngredientsId");
                });

            modelBuilder.Entity("CookBook.Model.AppUser", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("CookBook.Model.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Instructions");
                });
#pragma warning restore 612, 618
        }
    }
}
