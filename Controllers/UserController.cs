
using System;
using Microsoft.AspNetCore.Mvc;
using Web_KMK.Models;
namespace Web_KMK.Controllers
{
    public class UserController : Controller
    {

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Agenda()
        {
            return View();
        }
        public IActionResult Renungan()
        {
            return View();
        }

        
    }

}