using Microsoft.AspNetCore.Mvc;
using ProperSalads.Models;
using System.Diagnostics;

namespace ProperSalads.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}