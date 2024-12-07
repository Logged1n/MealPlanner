using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Ingredient : MealComponent
    {
        public decimal Quantity { get; set; }
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
        public override void Add(MealComponent component)
        {
            throw new NotSupportedException();
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            throw new NotSupportedException();
        }
    }
}
