using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    [ComplexType]
    public record MacronutrientsData(decimal ProteinAmount,
        decimal CarbohydratesAmount,
        decimal FatsAmount,
        int ServingSize,
        string Unit);
}
