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

        public IMealComponentBuilder WithCalories(int? calories = null)
        {
            _result.Calories = _caloriesStartegy.CalculateCalories(_result);
            return this;
        }

        public IMealComponentBuilder WithCategory(Enum category)
        {
            _result.Category = (MealType)category;
            return this;
        }

        public IMealComponentBuilder WithComponents(List<MealComponent> components, List<IngredientQuantity?>? ingredientQuantities = null)
        {
            var zippedList = components.Zip(ingredientQuantities, (i1, i2) => new { Ingredient = i1, IngredientQuantity = i2 });
            foreach (var item in zippedList)
            {
                _result.Add((Ingredient)item.Ingredient, item.IngredientQuantity);
            }
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
    }
}
