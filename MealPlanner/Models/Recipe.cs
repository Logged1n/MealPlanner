using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Recipe : MealComponent
    {
        public readonly List<IngredientQuantity> Components = [];

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
