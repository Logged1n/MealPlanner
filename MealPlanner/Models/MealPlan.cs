using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class MealPlan : MealComponent
    {
        public override Enum Category {
            get => base.Category;
            set
            {
                if (value is not MealPlanDuration)
                    throw new ArgumentException("Invalid enumeration type for this meal component.");
                base.Category = value;
            }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public readonly List<MealDay> Components = [];

        public override void Add(MealComponent component)
        {
            if (component is not MealDay) throw new ArgumentException($"{nameof(component)} is not a MealDay!");
            Components.Add((MealDay)component);
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            Components.Remove((MealDay)component);
        }

        public override List<MealComponent> GetComponents()
        {
            throw new NotImplementedException();
        }
    }
}
