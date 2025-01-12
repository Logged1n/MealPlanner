using MealPlanner.Models;

namespace MealPlanner.Startegies
{
    public class RecipeCaloriesStrategy : ICalculateCaloriesStartegy
    {
        public int CalculateCalories(MealComponent component)
        {
            int totalCalories = 0;

            if (component is IngredientQuantity ingredientQuantity)
            {
                totalCalories += ingredientQuantity.GetTotalCalories();
            }
            else
            {
                totalCalories += component.Calories;

                foreach (var subComponent in component.GetComponents())
                {
                    totalCalories += CalculateCalories(subComponent);
                }
            }

            return totalCalories;
        }
    }
}
