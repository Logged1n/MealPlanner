using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPlanner.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Macronutrients_CarbohydratesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_FatsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ProteinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ServingSize = table.Column<int>(type: "int", nullable: false),
                    Macronutrients_Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealDays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Macronutrients_CarbohydratesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_FatsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ProteinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ServingSize = table.Column<int>(type: "int", nullable: false),
                    Macronutrients_Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealDays_MealPlans_MealPlanId",
                        column: x => x.MealPlanId,
                        principalTable: "MealPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Recipies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealDayId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Macronutrients_CarbohydratesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_FatsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ProteinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ServingSize = table.Column<int>(type: "int", nullable: false),
                    Macronutrients_Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipies_MealDays_MealDayId",
                        column: x => x.MealDayId,
                        principalTable: "MealDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Macronutrients_CarbohydratesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_FatsAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ProteinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Macronutrients_ServingSize = table.Column<int>(type: "int", nullable: false),
                    Macronutrients_Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipies_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealDays_MealPlanId",
                table: "MealDays",
                column: "MealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipies_MealDayId",
                table: "Recipies",
                column: "MealDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipies");

            migrationBuilder.DropTable(
                name: "MealDays");

            migrationBuilder.DropTable(
                name: "MealPlans");
        }
    }
}
