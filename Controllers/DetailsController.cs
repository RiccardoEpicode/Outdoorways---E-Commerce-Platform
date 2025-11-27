using E_Commerce_Outdoorways.Context;
using E_Commerce_Outdoorways.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Outdoorways.Controllers
{
    public class DetailsController : Controller
    {
        private readonly AppDbContext _db;

        // DI per usare il database
        public DetailsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Details(int id)
        {
            // Cerca il prodotto per id
            var product = _db.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductId == id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
