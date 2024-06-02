using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RiddleParty.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("hello world");
        }
    }

    public class LobycoController : Controller
    {
        // This action returns the view with the button
        public IActionResult Index()
        {
            return View("./Pages/Login.cshtml");
        }

        // This action handles the button click and redirects to AnotherPage
        [HttpPost]
        public IActionResult Validate(string password)
        {
            if (password is null) return RedirectToAction("Login");
            if (password.ToLower() == "password")
            {
                return RedirectToAction("Index");
            }

            ViewBag.HasError = true;
            return RedirectToAction("Login");
        }

        // This action renders the target page
        public IActionResult Login()
        {
            return View("./Pages/Login.cshtml");
        }
    }
}
