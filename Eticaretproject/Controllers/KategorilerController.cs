using Microsoft.AspNetCore.Mvc;
using Eticaretproject.Models;
using System.Linq;

namespace Eticaretproject.Controllers
{
    public class KategorilerController : Controller
    {
        private readonly EticaretContext _context;

        public KategorilerController(EticaretContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kategoriler = _context.Kategorilers.ToList();
            return View(kategoriler);
        }
    }
}