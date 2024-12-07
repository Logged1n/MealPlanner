namespace MealPlanner.Models
{
    public class MealPlan : MealComponent
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private readonly List<MealDay> _components = [];
        public override void Add(MealComponent component)
        {
            if (component is not MealDay) throw new ArgumentException($"{nameof(component)} is not a MealDay!");
            _components.Add((MealDay)component);
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            _components.Remove((MealDay)component);
        }
    }
}
