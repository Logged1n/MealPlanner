namespace MealPlanner.Models
{
    public class MealDay : MealComponent
    {
        public DateTime Day { get; set; }
        public override Enum Category
        {
            get => base.Category;
            set
            {
                if (value is not DayOfWeek)
                    throw new ArgumentException("Invalid enumeration type for this meal component.");
                base.Category = value;
            }
        }
        public readonly List<Recipe> Components = [];
    }
}
