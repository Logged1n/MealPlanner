namespace MealPlanner.Models
{
    public class MealDay : MealComponent
    {
        public DateTime Day { get; set; }
        public DayOfWeek Category { get; set; }
        public readonly List<Recipe> Components = [];
    }
}
