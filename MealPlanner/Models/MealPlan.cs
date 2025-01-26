using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class MealPlan : MealComponent, ICloneable
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<MealDay> Components = [];

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
            Components = new List<MealDay>(
                Components.Select(c => (MealDay)c.Clone())
            );
        }


    }
}
