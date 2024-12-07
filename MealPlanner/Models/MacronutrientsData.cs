namespace MealPlanner.Models
{
    public record MacronutrientsData(decimal ProteinAmount,
        decimal CarbohydratesAmount,
        decimal FatsAmount,
        int ServingSize,
        string Unit);
}
