using Microsoft.AspNetCore.Mvc;
using Web_KMK.DAL;
using Web_KMK.Models;
using Microsoft.AspNetCore.Http;


namespace Web_KMK.Controllers
{
    public class AdminController : Controller
    {
 private IAdmin _adm;
    public AdminController(IAdmin adm)
    {
        _adm = adm;
    }
        public IActionResult Login(){
            return View();
        }

       [HttpPost]
        public IActionResult Login(string email, string password){
            var data = _adm.Login(email, password);
            
            HttpContext.Session.SetString("user", email);
                        return RedirectToAction("Index", "Home");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("user", "");
            return RedirectToAction("Index", "Home");
        }

        
    }

}