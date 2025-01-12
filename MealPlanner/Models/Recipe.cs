using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Recipe : MealComponent
    {
        public readonly List<Ingredient> Components = [];
        public readonly List<IngredientQuantity?> IngredientQuantities = [];

        public override Enum Category
        {
            get => base.Category;
            set
            {
                if (value is not MealType)
                    throw new ArgumentException("Invalid enumeration type for this meal component.");
                base.Category = value;
            }
        }

        public void Add(Ingredient ingredient, IngredientQuantity? ingredientQuantity = null)
        {
            Components.Add(ingredient);
            IngredientQuantities.Add(ingredientQuantity);
        }

        public void Remove(Ingredient component)
        {
            var indexToRemove = Components.IndexOf(component);
            Components.Remove(component);
            IngredientQuantities.Remove(IngredientQuantities[indexToRemove]);
        }
    }
}
