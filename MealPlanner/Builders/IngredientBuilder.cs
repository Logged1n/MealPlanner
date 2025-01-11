using MealPlanner.Models;
using MealPlanner.Models.Enums;

namespace MealPlanner.Builders
{
    public class IngredientBuilder : IMealComponentBuilder
    {
        private Ingredient _result = new Ingredient();

        public IMealComponentBuilder Reset()
        {
            _result = new Ingredient();
            return this;
        }

        public IMealComponentBuilder WithCalories(int calories)
        {
           _result.Calories = calories;
            return this;
        }

        public IMealComponentBuilder WithCategory(Enum category)
        {
            _result.Category = (IngredientCategory)category;
            return this;
        }

        public IMealComponentBuilder WithComponents(List<MealComponent> components)
        {
            throw new InvalidOperationException($"Cant add components to leaf component ({_result.GetType().Name})!");
        }

        public IMealComponentBuilder WithDay(DateTime day)
        {
            throw new InvalidOperationException("Cant add Day to Ingredient!");
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
            _result.Quantity = quantity;
            return this;
        }

        public IMealComponentBuilder WithUnit(string unit)
        {
            _result.Unit = unit;
            return this;
        }

        public Ingredient Build()
        {
            return _result;
        }
    }
}
