using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Ingredient : MealComponent, ICloneable
    {
        public string Unit { get; set; } = string.Empty;
        public IngredientCategory Category { get; set; }

        public override MealComponent[] GetComponents()
        {
            return [];
        }

        public override int GetTotalCalories()
        {
            return Calories;
        }
        public override object Clone()
        {
            // Tworzymy płytką kopię Ingredient
            var clone = (Ingredient)base.Clone();

            // Jeśli w przyszłości Ingredient będzie miał złożone komponenty, tutaj można dodać głębokie kopiowanie
            return clone;
        }
    }
}
