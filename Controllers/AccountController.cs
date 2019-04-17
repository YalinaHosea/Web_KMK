using Microsoft.AspNetCore.Mvc;

namespace Web_KMK.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
            //hallo
            //hello2
            //this
        }

        public IActionResult Pendaftaran(){
            return View();
        }
    }

}