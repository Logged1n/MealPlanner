using MealPlanner.Data;

namespace MealPlanner.Models.Commands
{
    public class DeleteIngredientCommand : ICommand
    {
        private readonly Ingredient _ingredient;
        
        private Ingredient _previousState;

        public DeleteIngredientCommand(Ingredient ingredient)
        {
            _ingredient = ingredient;
            
        }

        public void Execute(AppDbContext _db)
        {

            _previousState = new Ingredient
            {
                Id = _ingredient.Id,
                Name = _ingredient.Name,
                Category = _ingredient.Category,
                Calories = _ingredient.Calories,
                Macronutrients = new MacronutrientsData(
            _ingredient.Macronutrients.ProteinAmount,
            _ingredient.Macronutrients.CarbohydratesAmount,
            _ingredient.Macronutrients.FatsAmount,
            _ingredient.Macronutrients.ServingSize,
            _ingredient.Macronutrients.Unit
            )
            };

            _db.Ingredients.Remove(_ingredient);
            _db.SaveChanges();
        }

        public void Undo(AppDbContext db)
        {
            if (_previousState != null)
            {
                db.Ingredients.Add(_previousState);
                db.SaveChanges();
            }
        }
    }
}
