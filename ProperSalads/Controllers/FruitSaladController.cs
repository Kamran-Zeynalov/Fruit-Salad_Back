using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(int id)
        {
            ViewBag.Products = _context.FruitSalads
                                      .Include(fs => fs.GetFruitsaladImages)?
                                      .Include(fs => fs.SaladAndFruits).ThenInclude(saf => saf.Fruit).OrderByDescending(fs => fs.Id).Take(4).ToList();
            return View();
        }
    }
}