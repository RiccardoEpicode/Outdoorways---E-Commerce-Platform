using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Outdoorways.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login() 
        {
            return View();
        }
    }
}
