﻿using MealPlanner.Data;
using MealPlanner.Models;
using MealPlanner.Models.Enums;
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
            List<Recipe> recipes = _db.Recipies
                .Include(r => r.Components)
                .ToList();

            return View(recipes);
        }
        public IActionResult InsertRecipe()
        {
            List<Ingredient> objIngredientList = _db.Ingredients.ToList();
            return View(objIngredientList);
        }

        [HttpPost]
        public IActionResult InsertRecipe(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return View(recipe); // Jeśli dane są błędne, zwróć formularz z błędami
            }

            // Dodajemy logikę przetwarzania (np. zapis do bazy)
            _db.Recipies.Add(recipe);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var recipe = _db.Recipies
                             .Include(r => r.Components)
                             .ThenInclude(i => i.Ingredient)
                             .FirstOrDefault(r => r.Id == id);

            if (recipe == null)
            {
                return NotFound(); // Jeśli przepis nie istnieje
            }

            return View(recipe);
        }

    }
}
