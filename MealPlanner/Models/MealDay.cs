namespace MealPlanner.Models
{
    public class MealDay : MealComponent
    {
        public DateTime Day { get; set; }
        public override Enum Category => Day.DayOfWeek;
        private readonly List<Recipe> _components = [];

        public override void Add(MealComponent component)
        {
            if(component is not Recipe) throw new ArgumentException($"{nameof(component)} is not a Recipe!");
            _components.Add((Recipe)component);
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            _components.Remove((Recipe)component);
        }
    }
}
