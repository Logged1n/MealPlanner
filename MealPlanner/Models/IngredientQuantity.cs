using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    [ComplexType]
    public class IngredientQuantity : Ingredient
    {
        public decimal Quantity { get; set; }

        public IngredientQuantity() { }
        public IngredientQuantity(Ingredient ingredient, decimal quantity)
        {
            Id = ingredient.Id;
            Category = ingredient.Category;
            Description = ingredient.Description;
            Calories = ingredient.Calories;
            Quantity = quantity;
        }

        public override int GetTotalCalories()
        {
            return (int)(Calories*Quantity);
        }
    }
}
