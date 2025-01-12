using MealPlanner.Models;

namespace MealPlanner.Builders
{
    public class MealDayBuilder : IMealComponentBuilder
    {
        private MealDay _result = new MealDay();

        public IMealComponentBuilder Reset()
        {
            _result = new MealDay();
            return this;
        }

        public IMealComponentBuilder WithCalories(int? calories = null)
        {
            throw new NotImplementedException();
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
