using MealPlanner.Models;

namespace MealPlanner.Startegies
{
    public class RecipeCaloriesStrategy : ICalculateCaloriesStartegy
    {
        public int CalculateCalories(Recipe recipe)
        {
            return recipe
                .Components
                .Sum(i => i.Calories);
        }
    }
}
