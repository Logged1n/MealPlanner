using MealPlanner.Models.Enums;
using System.Diagnostics.CodeAnalysis;

namespace MealPlanner.Models
{
    public class Ingredient : MealComponent
    {
        
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
