namespace MealPlanner.Models
{
    public class MealDay : MealComponent, ICloneable
    {
        public DateTime Day { get; set; }
        public DayOfWeek Category { get; set; }
        public List<Recipe> Components = [];

        public override MealComponent[] GetComponents()
        {
            return [.. Components];
        }

        public override int GetTotalCalories()
        {
            return Components.Sum(c => c.GetTotalCalories());
        }
        protected override void DeepClone()
        {
            // Głębokie klonowanie listy Components
            Components = new List<Recipe>(
                Components.Select(c => (Recipe)c.Clone())
            );
        }
    }
}
