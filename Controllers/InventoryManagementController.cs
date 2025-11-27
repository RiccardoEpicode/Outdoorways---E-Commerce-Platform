using E_Commerce_Outdoorways.Context;
using E_Commerce_Outdoorways.Entities;
using Microsoft.AspNetCore.Mvc;

public class InventoryManagementController : Controller
{
    private readonly AppDbContext _db;

    public InventoryManagementController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult InventoryManagement()
    {
        ViewBag.Categories = _db.Categories.ToList();
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();

        return RedirectToAction("InventoryManagement");
    }

    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
        _db.Products.Update(product);
        _db.SaveChanges();

        return RedirectToAction("InventoryManagement");
    }

    [HttpPost]
    public IActionResult DeleteProduct(Product product)
    {        
        _db.Products.Remove(product);
        _db.SaveChanges();       

        return RedirectToAction("InventoryManagement");
    }
}
