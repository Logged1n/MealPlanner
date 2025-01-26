using MealPlanner.Data;
using MealPlanner.Models;
using MealPlanner.Models.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class IngredientController : Controller
    {

        private readonly AppDbContext _db;
        private readonly CommandInvoker _commandInvoker;

        public IngredientController(AppDbContext db,CommandInvoker cmd)
        {
            _db = db;
            _commandInvoker = cmd;
        }

        public IActionResult Index()
        {
            List<Ingredient> objIngredientList = _db.Ingredients.ToList();
            return View(objIngredientList);
        }


        public IActionResult InsertIngredient()
        {
            return View();
        }

        public IActionResult UndoAction()
        {
            _commandInvoker.Undo(_db); 
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertIngredient(Ingredient obj)
        {
            var command = new AddIngredientCommand(obj);
            _commandInvoker.Invoke(command,_db); 
            return RedirectToAction("Index");
        }

        public IActionResult DeleteIngredient(Guid id)
        {
            var ingredient = _db.Ingredients.Find(id);
            if (ingredient == null)
            {
                return NotFound("Składnik nie został znaleziony.");
            }
            var command = new DeleteIngredientCommand(ingredient);
                _commandInvoker.Invoke(command, _db); 
            
            return RedirectToAction("Index");
        }
        public IActionResult DuplicateIngredient(Guid id)
        {
            // Pobieramy składnik na podstawie ID
            var ingredient = _db.Ingredients.Find(id);
            if (ingredient == null)
            {
                return NotFound("Składnik nie został znaleziony.");
            }

            // Klonujemy składnik
            var clonedIngredient = (Ingredient)ingredient.Clone();

            // Generujemy nowe, unikalne ID dla sklonowanego składnika
            clonedIngredient.Id = Guid.NewGuid();

            // Dodajemy sklonowany składnik do bazy danych
            _db.Ingredients.Add(clonedIngredient);
            _db.SaveChanges();

            // Przekierowujemy do listy składników
            return RedirectToAction("Index");
        }
        public IActionResult EditIngredient(Guid id)
        {
            // Pobieramy składnik na podstawie ID
            var ingredient = _db.Ingredients.Find(id);
            if (ingredient == null)
            {
                return NotFound("Składnik nie został znaleziony.");
            }

            return View(ingredient); // Przekazujemy obiekt składnika do widoku
        }

        // Nowa akcja POST - zapisanie zmian w składniku
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditIngredient(Ingredient ingredient)
        {
            // Pobieramy składnik z bazy danych na podstawie jego ID
            var existingIngredient = _db.Ingredients.Find(ingredient.Id);
            if (existingIngredient == null)
            {
                return NotFound("Składnik nie został znaleziony.");
            }

            // Aktualizujemy dane składnika
            existingIngredient.Name = ingredient.Name;
            existingIngredient.Description = ingredient.Description;
            existingIngredient.Calories = ingredient.Calories;
            existingIngredient.Macronutrients = ingredient.Macronutrients;
            existingIngredient.Unit = ingredient.Unit;
            existingIngredient.Category = ingredient.Category;

            // Zapisujemy zmiany w bazie danych
            _db.SaveChanges();

            return RedirectToAction("Index"); // Przekierowujemy z powrotem do listy składników
        }
    
}
}
