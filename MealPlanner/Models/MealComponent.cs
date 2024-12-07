namespace MealPlanner.Models
{
    /// <summary>
    /// This class is a common structure of Ingredients, Recipes, Meals and MealPlans (composite pattern)
    /// </summary>
    public abstract class MealComponent
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public virtual Enum Category {  get; set; }
        public MacronutrientsData Macronutrients { get; set; }

        public abstract void Display(int depth = 0);
        public abstract void Add(MealComponent component);
        public abstract void Remove(MealComponent component);
    }
}
