using MealPlanner.Models;
using MealPlanner.Startegies;

namespace MealPlanner.Builders
{
    public class MealDayBuilder : IMealComponentBuilder
    {
        private MealDay _result = new MealDay();
        private ICalculateCaloriesStartegy _calculateCaloriesStartegy = new RecipeCaloriesStrategy();

        public IMealComponentBuilder Reset()
        {
            _result = new MealDay();
            return this;
        }

        public IMealComponentBuilder WithCalories(int? calories = null)
        {
            if (calories is null)
                _result.Calories = _calculateCaloriesStartegy.CalculateCalories(_result);
            else
                _result.Calories = (int)calories;
            return this;
        }

        public IMealComponentBuilder WithCategory(Enum category)
        {
            throw new NotImplementedException();
        }

        public IMealComponentBuilder WithComponents(List<MealComponent> components, List<decimal>? quantities = null)
        {
            throw new NotImplementedException();
        }

        public IMealComponentBuilder WithDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public IMealComponentBuilder WithDescription(string description)
        {
            throw new NotImplementedException();
        }

        public IMealComponentBuilder WithMacronutrients(MacronutrientsData macroutrients)
        {
            throw new NotImplementedException();
        }

        public IMealComponentBuilder WithName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
