using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using ProperSalads.DAL;
using ProperSalads.Models;
using System.Diagnostics;

namespace ProperSalads.Controllers
{
    public class FruitSaladController : Controller
    {
        private readonly SaladPageDbContext _context;

        public FruitSaladController(SaladPageDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Products = _context.FruitSalads
                                      .Include(fs => fs.GetFruitsaladImages)?
                                      .Include(fs => fs.SaladAndFruits)
                                      .ThenInclude(saf => saf.Fruit)
                                      .ThenInclude(f => f.fruitCategories).OrderByDescending(fs => fs.Id).Take(4).ToList();
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Products = _context.FruitSalads
                                    .Include(fs => fs.GetFruitsaladImages)?
                                    .Include(fs => fs.SaladAndFruits)
                                    .ThenInclude(saf => saf.Fruit)
                                    .ThenInclude(f => f.fruitCategories).OrderByDescending(fs => fs.Id).Take(4).ToList();

            ViewBag.AllFruits = _context.Fruits.ToList();
            if (id == 0) return NotFound();

            FruitSalad? fruitSalad = _context.FruitSalads.FirstOrDefault(fs => fs.Id == id);

            if (fruitSalad is null) return NotFound();
            return View(fruitSalad);
        }
    }
}