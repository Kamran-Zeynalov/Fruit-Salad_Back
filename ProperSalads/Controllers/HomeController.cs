using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProperSalads.DAL;

namespace ProperSalads.Controllers
{
    public class HomeController : Controller
    {
        private readonly SaladPageDbContext _context;

        public HomeController(SaladPageDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Products = _context.FruitSalads
                                    .Include(fs => fs.GetFruitsaladImages)?
                                    .Include(fs => fs.SaladAndFruits).ThenInclude(saf => saf.Fruit).OrderByDescending(fs => fs.Id).Take(4).ToList();
            return View();
        }
    }
}
