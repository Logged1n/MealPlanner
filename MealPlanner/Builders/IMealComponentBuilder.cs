using MealPlanner.Models;

namespace MealPlanner.Builders
{
    public interface IMealComponentBuilder
    {
        IMealComponentBuilder Reset();
        IMealComponentBuilder WithName(string name);
        IMealComponentBuilder WithDescription(string description);
        IMealComponentBuilder WithCalories(int calories);
        IMealComponentBuilder WithCategory(Enum category);
        IMealComponentBuilder WithComponents(List<MealComponent> components);
        IMealComponentBuilder WithUnit(string unit);
        IMealComponentBuilder WithQuantity(decimal quantity);
        IMealComponentBuilder WithDay(DateTime day);
        IMealComponentBuilder WithMacronutrients(MacronutrientsData macroutrients);
    }
}
