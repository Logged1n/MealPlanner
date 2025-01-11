using MealPlanner.Models;
using MealPlanner.Models.Enums;
using MealPlanner.Startegies;

namespace MealPlanner.Builders
{
    public class RecipeBuilder : IMealComponentBuilder
    {
        private Recipe _result;
        private readonly ICalculateCaloriesStartegy _caloriesStartegy;

        public RecipeBuilder(ICalculateCaloriesStartegy caloriesStartegy)
        {
            _caloriesStartegy = caloriesStartegy;
            _result = new Recipe();
        }

        public IMealComponentBuilder Reset()
        {
            _result = new Recipe();
            return this;
        }

        public IMealComponentBuilder WithCalories(int calories)
        {
            _result.Calories = _caloriesStartegy.CalculateCalories(_result);
            return this;
        }

        public IMealComponentBuilder WithCategory(Enum category)
        {
            _result.Category = (MealType)category;
            return this;
        }

        public IMealComponentBuilder WithComponents(List<MealComponent> components)
        {
            components.ForEach(_result.Add);
            return this;
        }

        public IMealComponentBuilder WithDay(DateTime day)
        {
            throw new InvalidOperationException();
        }

        public IMealComponentBuilder WithDescription(string description)
        {
            _result.Description = description;
            return this;
        }

        public IMealComponentBuilder WithMacronutrients(MacronutrientsData macroutrients)
        {
            _result.Macronutrients = macroutrients;
            return this;
        }

        public IMealComponentBuilder WithName(string name)
        {
            _result.Name = name;
            return this;
        }

        public IMealComponentBuilder WithQuantity(decimal quantity)
        {
            throw new InvalidOperationException();
        }

        public IMealComponentBuilder WithUnit(string unit)
        {
            throw new InvalidOperationException();
        }
    }
}
