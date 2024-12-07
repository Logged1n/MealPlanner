using MealPlanner.Models.Enums;

namespace MealPlanner.Models
{
    public class Recipe : MealComponent
    {
        private readonly List<Ingredient> _components = [];
        public override Enum Category
        {
            get => base.Category;
            set
            {
                if (value is not MealType)
                    throw new ArgumentException("Invalid enumeration type for this meal component.");
                base.Category = value;
            }
        }

        public override void Add(MealComponent component)
        {
            if (component is not Ingredient) throw new ArgumentException("You are tring to add invalid component to Recipe!");
            _components.Add((Ingredient)component);
        }

        public override void Display(int depth = 0)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MealComponent component)
        {
            _components.Remove((Ingredient)component);
        }
    }
}
