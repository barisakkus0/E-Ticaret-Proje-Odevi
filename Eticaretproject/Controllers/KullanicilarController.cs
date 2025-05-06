using Microsoft.AspNetCore.Mvc;

namespace Eticaretproject.Controllers
{
    public class KullanicilarController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

    }
}
