using MealPlanner.Data;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class MealPlanController : Controller
    {

        private readonly AppDbContext _db;

        public MealPlanController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<MealPlan> mealPlans=_db.MealPlans.ToList();
            return View(mealPlans);
        }
        public IActionResult InsertMealPlan()
        {
            return View();
        }
    }
}
