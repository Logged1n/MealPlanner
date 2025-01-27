using MealPlanner.Data;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class MealDayController : Controller
    {

        private readonly AppDbContext _db;

        public MealDayController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<MealDay> recipes = _db.MealDays.ToList();
            return View(recipes);
        }
        public IActionResult InsertMealDay() 
        {
            return View();
        }
    }
}
