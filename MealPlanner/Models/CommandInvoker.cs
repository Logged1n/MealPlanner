using MealPlanner.Data;

namespace MealPlanner.Models
{
    public class CommandInvoker
    {

        private readonly Stack<ICommand> _history = new Stack<ICommand>();
        

        
        public void Invoke(ICommand command,AppDbContext db)
        {
            command.Execute(db);
            _history.Push(command);
        }

        public void Undo(AppDbContext db)
        {
            if (_history.Count > 0)
            {
                var command = _history.Pop();
                command.Undo(db);
            }
        }
    }
}
