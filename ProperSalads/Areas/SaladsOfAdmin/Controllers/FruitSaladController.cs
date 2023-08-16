using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProperSalads.DAL;
using ProperSalads.Models;

namespace ProperSalads.Areas.SaladsOfAdmin.Controllers
{
    [Area("SaladsOfAdmin")]
    public class FruitSaladController : Controller
    {
        private readonly SaladPageDbContext _context;

        public FruitSaladController(SaladPageDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<FruitSalad>? fruitSalads = _context.FruitSalads
                .AsEnumerable();


            return View(fruitSalads);
        }
    }
}
