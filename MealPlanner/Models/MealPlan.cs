using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class MealPlan : MealComponent
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public readonly List<MealDay> Components = [];

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
