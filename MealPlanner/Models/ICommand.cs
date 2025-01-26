using MealPlanner.Data;

namespace MealPlanner.Models
{
    public interface ICommand
    {
        void Execute(AppDbContext db);

        void Undo(AppDbContext db);
    }

}
