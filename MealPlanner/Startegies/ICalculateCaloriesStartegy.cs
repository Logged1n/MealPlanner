using MealPlanner.Models;

namespace MealPlanner.Startegies
{
    public interface ICalculateCaloriesStartegy
    {
        int CalculateCalories(MealComponent mealComponent);
    }
}
