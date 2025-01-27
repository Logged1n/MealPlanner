using MealPlanner.Data;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Controllers
{
    public class RecipeController : Controller
    {
        private readonly AppDbContext _db;
        public RecipeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Recipe> recipes = _db.Recipies.ToList();

            return View(recipes);
        }
        public IActionResult Ingredient()
        {
            List<Ingredient> objIngredientList = _db.Ingredients.ToList();
            return View(objIngredientList);
        }
        public IActionResult Steps()
        {
            return View();
        }
    }
}
