using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class MealPlan : MealComponent
    {
        public override Enum Category
        {
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
    }
}
