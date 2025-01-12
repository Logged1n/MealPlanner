using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertIngredient()
        {
            return View();
        }
    }
}
