namespace MealPlanner.Models
{
    public class IngredientQuantity : MealComponent
    {
        public decimal Quantity { get; set; }

        //navigation
        public Recipe Recipe { get; set; } = null!;
        public Ingredient Ingredient { get; set; } = null!;

        public IngredientQuantity() { }
        public IngredientQuantity(Ingredient ingredient, decimal quantity, Recipe recipe)
        {
            Id = ingredient.Id;
            Description = ingredient.Description;
            Calories = ingredient.Calories;
            Quantity = quantity;
            Recipe = recipe;
        }

        public override int GetTotalCalories()
        {
            return (int)(Ingredient.Calories*Quantity);
        }

        public override MealComponent[] GetComponents()
        {
            return Array.Empty<MealComponent>();
        }
    }
}
