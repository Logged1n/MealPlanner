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

        public override void Add(MealComponent component)
        {
            if(component is not Recipe) throw new ArgumentException($"{nameof(component)} is not a Recipe!");
            Components.Add((Recipe)component);
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            Components.Remove((Recipe)component);
        }

        public override List<MealComponent> GetComponents()
        {
            throw new NotImplementedException();
        }
    }
}
