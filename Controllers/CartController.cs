using E_Commerce_Outdoorways.Context;
using E_Commerce_Outdoorways.Entities;
using Microsoft.AspNetCore.Mvc;

public class CartController : Controller
{
    private readonly AppDbContext _db;

    // SETS THE EMPTY LIST FOR THE ITEMS
    private static List<CartItem> Cart = new List<CartItem>();

    public CartController(AppDbContext db)
    {
        _db = db;
    }

    //METHOD TO SHOW THE CART PAGE
    public IActionResult CartPage()
    {
        // RETURNS THE SESSION COUNT OF ITEMS IN THE CART
        HttpContext.Session.SetString("CartCount", Cart.Sum(x => x.Quantity).ToString());

        return View("CartPage", Cart);
    }

    // METHOD TO ADD PRODUCTS TO THE LIST
    [HttpPost]
    public IActionResult Add(int id, int quantity)
    {
        var p = _db.Products.Find(id);
        if (p == null) return NotFound();

        // ADDS PRODUCTS TO THE LIST AND CHECKS IF THERE ARE ANY 
        var existing = Cart.FirstOrDefault(x => x.ProductId == id);

        if (existing != null)
        {
            existing.Quantity += quantity; 
        }
        else
        {
            Cart.Add(new CartItem
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Price = p.Price,
                ProductIMG = p.ProductIMG,
                Quantity = quantity
            });
        }

        ViewBag.CartCount = Cart.Sum(x => x.Quantity);

        return RedirectToAction("CartPage");
    }

}
