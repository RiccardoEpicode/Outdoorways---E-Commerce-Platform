using E_Commerce_Outdoorways.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Outdoorways.Controllers
{
    public class CategoriesController : Controller
    {
        // The controller needs to access the database.
        // So we create a private variable named "_db" of Type: AppDbContext (your database connection + all tables)
        // "private"  → usable ONLY inside this controller
        // "readonly" → can be assigned ONLY once (inside the constructor)
        // After it's assigned, it cannot change (for safety)
        // The controller will use _db to query the database
        // This technique is called **Dependency Injection** (DI).

        private readonly AppDbContext _db;

        public CategoriesController(AppDbContext db)
        {
            // We assign the injected AppDbContext to our private field _db.
            // Now the entire controller can use _db to:
            // - query the database
            // - insert products
            // - filter by category
            // - update orders, etc.
            _db = db;
        }

        public IActionResult Men()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 1)
                              .ToList();

            return View(products);
        }

        public IActionResult Women()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 2)
                              .ToList();

            return View(products);
        }

        public IActionResult Kids()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 3)
                              .ToList();

            return View(products);
        }

        public IActionResult Autumn()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 4)
                              .ToList();

            return View(products);
        }

        public IActionResult Winter()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 5)
                              .ToList();

            return View(products);
        }

        public IActionResult Spring()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 6)
                              .ToList();

            return View(products);
        }

        public IActionResult Summer()
        {
            var products = _db.Products
                              .Where(p => p.CategoryId == 7)
                              .ToList();

            return View(products);
        }
    }
}
