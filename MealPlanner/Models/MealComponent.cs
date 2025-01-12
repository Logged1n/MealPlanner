namespace MealPlanner.Models
{
    /// <summary>
    /// This class is a common structure of Ingredients, Recipes, Meals and MealPlans (composite pattern)
    /// </summary>
    public abstract class MealComponent
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public string? Description { get; set; }
        public MacronutrientsData Macronutrients { get; set; }
    }
}
