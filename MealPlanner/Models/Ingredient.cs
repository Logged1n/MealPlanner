using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Ingredient : MealComponent
    {
        public string Unit { get; set; }
        public override Enum Category
        {
            get => base.Category;
            set
            {
                if (value is not IngredientCategory)
                    throw new ArgumentException("Invalid enumeration type for this meal component.");
                base.Category = value;
            }
        }
        
    }
}
