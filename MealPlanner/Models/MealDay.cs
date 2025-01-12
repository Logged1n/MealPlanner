namespace MealPlanner.Models
{
    public class MealDay : MealComponent
    {
        public DateTime Day { get; set; }
        public DayOfWeek Category { get; set; }
        public readonly List<Recipe> Components = [];

        public override MealComponent[] GetComponents()
        {
            return [.. Components];
        }

        public override int GetTotalCalories()
        {
            return Components.Sum(c => c.GetTotalCalories());
        }
    }
}
