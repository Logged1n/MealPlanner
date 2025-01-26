namespace MealPlanner.Models
{
    public class IngredientQuantity : MealComponent, ICloneable
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

        public override object Clone()
        {
            // Tworzymy płytką kopię IngredientQuantity
            var clone = (IngredientQuantity)base.Clone();

            // Wykonujemy głębokie kopiowanie referencji na Recipe i Ingredient
            clone.Recipe = (Recipe)Recipe.Clone();  // Głębokie klonowanie Recipe
            clone.Ingredient = (Ingredient)Ingredient.Clone();  // Głębokie klonowanie Ingredient

            return clone;
        }
    }
}
