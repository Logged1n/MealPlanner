using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class MealPlanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertMealPlan()
        {
            return View();
        }
    }
}
