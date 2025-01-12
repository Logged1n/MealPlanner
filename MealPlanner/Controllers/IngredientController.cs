using MealPlanner.Data;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class IngredientController : Controller
    {

        private readonly AppDbContext _db;

        public IngredientController(AppDbContext db)
        {
            _db = db;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertIngredient(Ingredient obj)
        {
            _db.Ingredients.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteIngredient(Ingredient obj)
        {

            _db.Ingredients.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}
