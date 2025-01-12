using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Recipe : MealComponent
    {
        public readonly List<IngredientQuantity> Components = [];
        public MealType Category { get; set; }

        public void Add(Ingredient ingredient, decimal quantity)
        {
            Components.Add(new IngredientQuantity(ingredient, quantity));
        }

        public void Remove(Ingredient component)
        {
            Components.Remove((IngredientQuantity)component);
        }
    }
}
