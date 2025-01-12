using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class MealDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertMealDay() 
        {
            return View();
        }
    }
}
