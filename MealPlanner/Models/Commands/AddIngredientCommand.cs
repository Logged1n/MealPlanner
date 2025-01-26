using MealPlanner.Data;

namespace MealPlanner.Models.Commands
{
    public class AddIngredientCommand : ICommand
    {
        private readonly Ingredient _ingredient;
        
        

        public AddIngredientCommand(Ingredient ingredient)
        {
            _ingredient = ingredient;
       
        }

        public void Execute(AppDbContext db)
        {
            db.Ingredients.Add(_ingredient);
            db.SaveChanges();
        }

        public void Undo(AppDbContext db)
        {
            if (_ingredient != null)
            {
                db.Ingredients.Remove(_ingredient);
                db.SaveChanges();
            }
        }
    }
}
