﻿// <auto-generated />
using System;
using System.Collections.Generic;
using MealPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MealPlanner.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250112200849_editcmddaa")]
    partial class editcmddaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MealPlanner.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ComplexProperty<Dictionary<string, object>>("Macronutrients", "MealPlanner.Models.Ingredient.Macronutrients#MacronutrientsData", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<decimal>("CarbohydratesAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("FatsAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("ProteinAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<int>("ServingSize")
                                .HasColumnType("int");

                            b1.Property<string>("Unit")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasDiscriminator().HasValue("Ingredient");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MealPlanner.Models.MealDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MealPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ComplexProperty<Dictionary<string, object>>("Macronutrients", "MealPlanner.Models.MealDay.Macronutrients#MacronutrientsData", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<decimal>("CarbohydratesAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("FatsAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("ProteinAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<int>("ServingSize")
                                .HasColumnType("int");

                            b1.Property<string>("Unit")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.HasIndex("MealPlanId");

                    b.ToTable("MealDays");
                });

            modelBuilder.Entity("MealPlanner.Models.MealPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.ComplexProperty<Dictionary<string, object>>("Macronutrients", "MealPlanner.Models.MealPlan.Macronutrients#MacronutrientsData", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<decimal>("CarbohydratesAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("FatsAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("ProteinAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<int>("ServingSize")
                                .HasColumnType("int");

                            b1.Property<string>("Unit")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.ToTable("MealPlans");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MealDayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ComplexProperty<Dictionary<string, object>>("Macronutrients", "MealPlanner.Models.Recipe.Macronutrients#MacronutrientsData", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<decimal>("CarbohydratesAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("FatsAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("ProteinAmount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<int>("ServingSize")
                                .HasColumnType("int");

                            b1.Property<string>("Unit")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.HasIndex("MealDayId");

                    b.ToTable("Recipies");
                });

            modelBuilder.Entity("MealPlanner.Models.IngredientQuantity", b =>
                {
                    b.HasBaseType("MealPlanner.Models.Ingredient");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("RecipeId");

                    b.HasDiscriminator().HasValue("IngredientQuantity");
                });

            modelBuilder.Entity("MealPlanner.Models.MealDay", b =>
                {
                    b.HasOne("MealPlanner.Models.MealPlan", null)
                        .WithMany()
                        .HasForeignKey("MealPlanId");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.HasOne("MealPlanner.Models.MealDay", null)
                        .WithMany("Components")
                        .HasForeignKey("MealDayId");
                });

            modelBuilder.Entity("MealPlanner.Models.IngredientQuantity", b =>
                {
                    b.HasOne("MealPlanner.Models.Recipe", null)
                        .WithMany("Components")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("MealPlanner.Models.MealDay", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
