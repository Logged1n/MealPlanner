using MealPlanner.Models;

namespace MealPlanner.Builders
{
    public interface IMealComponentBuilder
    {
        IMealComponentBuilder Reset();
        IMealComponentBuilder WithName(string name);
        IMealComponentBuilder WithDescription(string description);
        IMealComponentBuilder WithCalories(int? calories = null);
        IMealComponentBuilder WithCategory(Enum category);
        IMealComponentBuilder WithComponents(List<MealComponent> components, List<decimal>? quantities = null);
        IMealComponentBuilder WithDay(DateTime day);
        IMealComponentBuilder WithMacronutrients(MacronutrientsData macroutrients);
    }
}
