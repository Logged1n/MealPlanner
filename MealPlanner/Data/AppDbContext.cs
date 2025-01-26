using MealPlanner.Models;
using MealPlanner.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientQuantity> IngredientQuantities { get; set; }
        public DbSet<Recipe> Recipies { get; set; }
        public DbSet<MealDay> MealDays { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Category)
                .HasConversion(
                    c => c.ToString(),
                    c => (IngredientCategory)Enum.Parse(typeof(IngredientCategory), c)
                );

            modelBuilder.Entity<Recipe>()
                .Property(r => r.Category)
                .HasConversion(
                    c => c.ToString(),
                    c => (MealType)Enum.Parse(typeof(MealType), c)
                );

            modelBuilder.Entity<MealDay>()
                .HasMany(m => m.Components);

            modelBuilder.Entity<MealDay>()
                .Property(m => m.Category)
                .HasConversion(
                    c => c.ToString(),
                    c => (DayOfWeek)Enum.Parse(typeof(DayOfWeek), c)
                );

            modelBuilder.Entity<MealPlan>()
                .HasMany<MealDay>();
        }
    }
}
