using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    [ComplexType]
    public record IngredientQuantity(decimal Quntity, string Unit);
}
