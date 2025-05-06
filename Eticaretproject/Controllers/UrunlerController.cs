using Microsoft.AspNetCore.Mvc;
using Eticaretproject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore; // Include metodu için gerekli

namespace Eticaretproject.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly EticaretContext _context;

        public UrunlerController(EticaretContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Ürünleri kategorileriyle birlikte eager loading ile getiriyoruz
            var urunler = _context.Urunlers.Include(u => u.Kategori).ToList();
            return View(urunler);
        }
    }
}