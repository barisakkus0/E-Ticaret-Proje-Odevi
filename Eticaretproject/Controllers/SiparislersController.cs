using Microsoft.AspNetCore.Mvc;
using Eticaretproject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore; // Kullanıcı bilgisini eager loading ile almak için

namespace Eticaretproject.Controllers
{
    public class SiparislersController : Controller
    {
        private readonly EticaretContext _context;

        public SiparislersController(EticaretContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Siparişleri kullanıcı bilgileriyle birlikte getiriyoruz
            var siparisler = _context.Siparislers.Include(s => s.Kullanici).ToList();
            return View(siparisler);
        }
    }
}