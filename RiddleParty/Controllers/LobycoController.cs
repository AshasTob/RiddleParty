﻿using Microsoft.AspNetCore.Mvc;

namespace RiddleParty.Controllers
{
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