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

        public IMealComponentBuilder WithCalories(int? calories = null)
        {
           _result.Calories = calories ?? 0;
            return this;
        }

        public IMealComponentBuilder WithCategory(Enum category)
        {
            _result.Category = (IngredientCategory)category;
            return this;
        }

        public IMealComponentBuilder WithComponents(List<MealComponent> components, List<IngredientQuantity?>? ingredientQuantities = null)
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

        public Ingredient Build()
        {
            return _result;
        }
    }
}
