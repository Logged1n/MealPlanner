using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ingredient()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
    }
}
