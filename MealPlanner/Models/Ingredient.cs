using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Ingredient : MealComponent
    {
        public string Unit { get; set; } = string.Empty;
        public IngredientCategory Category { get; set; }
        
    }
}
