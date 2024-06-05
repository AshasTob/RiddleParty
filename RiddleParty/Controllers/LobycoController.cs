using Microsoft.AspNetCore.Mvc;
using RiddleParty.Pages;

namespace RiddleParty.Controllers
{
    public class LobycoController : Controller
    {
        // This action returns the view with the button
        public IActionResult Index()
        {
            return View("./Pages/Login.cshtml");
        }

        // This action returns the view with the button
        public IActionResult Welcome()
        {
            return View("./Pages/Welcome.cshtml");
        }

        // This action handles the button click and redirects to AnotherPage
        [HttpPost]
        public IActionResult Validate(string password)
        {
            if (password is null) return RedirectToAction("Login");
            if (password.ToLower() == "password")
            {
                return RedirectToAction("Loading");
            }

            ViewBag.HasError = true;
            return RedirectToAction("Index");
        }

        // This action returns the view with the button
        public IActionResult Loading()
        {
            return View("./Pages/Loading.cshtml");
        }

        [HttpGet("/lobyco/home-screen")]
        // This action renders the target page
        public IActionResult Playgroud()
        {
            return View("./Pages/Playgroud.cshtml");
        }

        // This action renders the target page
        public IActionResult Level2()
        {
            return View("./Pages/Level2.cshtml");
        }

        public IActionResult Level3()
        {
            return View("./Pages/Level3.cshtml");
        }

        [Route("lobyco/3level")]
        public IActionResult Level3Mirror()
        {
            return View("./Pages/Level3Mirror.cshtml");
        }

        [Route("lobyco/locked")]
        public IActionResult Locked()
        {
            return View("./Pages/Locked.cshtml");
        }

        [Route("lobyco/strong-commercial-home-screen")]
        public IActionResult SCHS()
        {
            return View("./Pages/StrongCommercialHomeScreen.cshtml");
        }
    }
}
