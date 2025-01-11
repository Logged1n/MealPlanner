using MealPlanner.Models;

namespace MealPlanner.Startegies
{
    public class RecipeCaloriesStrategy : ICalculateCaloriesStartegy
    {
        public int CalculateCalories(MealComponent mealComponent)
        {
            return mealComponent
                .GetComponents()
                .Sum(i => i.Calories);
        }
    }
}
