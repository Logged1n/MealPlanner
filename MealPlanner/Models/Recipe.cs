using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Recipe : MealComponent, ICloneable
    {
        public List<IngredientQuantity> Components { get; set; } = [];
        public MealType Category { get; set; }

        public void Add(Ingredient ingredient, decimal quantity)
        {
            Components.Add(new IngredientQuantity(ingredient, quantity, this));
        }

        public void Remove(IngredientQuantity component)
        {
            Components.Remove(component);
        }

        public override MealComponent[] GetComponents()
        {
            return [.. Components];
        }

        public override int GetTotalCalories()
        {
            return Calories;
        }
        protected override void DeepClone()
        {
            // Tworzymy głęboką kopię listy Components
            Components = Components.Select(c => (IngredientQuantity)c.Clone()).ToList();
        }
    }
}
