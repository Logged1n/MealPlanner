namespace MealPlanner.Models
{
    /// <summary>
    /// This class is a common structure of Ingredients, Recipes, Meals and MealPlans (composite pattern)
    /// </summary>
    public abstract class MealComponent : ICloneable
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public string? Description { get; set; }
        public MacronutrientsData Macronutrients { get; set; }

        public abstract MealComponent[] GetComponents();
        public abstract int GetTotalCalories();

        public virtual object Clone()
        {
            // Tworzymy płytką kopię obiektu
            var clone = (MealComponent)MemberwiseClone();

            // Wołamy metodę do głębokiego kopiowania, specyficzną dla klas pochodnych
            clone.DeepClone();

            return clone;
        }

        protected virtual void DeepClone()
        {
            // Domyślna implementacja, nic nie robi
            // Klasy pochodne (np. MealPlan, MealDay) nadpisują tę metodę w razie potrzeby
        }
    }
}
