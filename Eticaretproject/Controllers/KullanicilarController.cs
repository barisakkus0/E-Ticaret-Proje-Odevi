using Microsoft.AspNetCore.Mvc;
using Eticaretproject.Models;
using System.Linq;

namespace Eticaretproject.Controllers
{
    public class KullanicilarController : Controller
    {
        private readonly EticaretContext _context;

        public KullanicilarController(EticaretContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kullanicilar = _context.Kullanicilars.ToList();
            return View(kullanicilar);
        }
    }
}