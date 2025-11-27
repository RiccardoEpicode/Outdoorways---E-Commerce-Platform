using E_Commerce_Outdoorways.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Outdoorways.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db = db;
        }

       
        public IActionResult Shop()
        {
            var products = _db.Products
                .Include(p => p.Category)
                .ToList();

            return View(products);
        }
    }
}
