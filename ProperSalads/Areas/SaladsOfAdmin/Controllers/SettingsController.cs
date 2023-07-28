using Microsoft.AspNetCore.Mvc;
using ProperSalads.DAL;
using ProperSalads.Models;
using System;

namespace ProperSalads.Areas.SaladsOfAdmin.Controllers
{
    [Area("SaladsOfAdmin")]
    public class SettingsController : Controller
    {
        readonly SaladPageDbContext _context;
        public SettingsController(SaladPageDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Setting> settings = _context.Settings.AsEnumerable();
            return View(settings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Setting newSettings)
        {
            if (newSettings.Key is null || newSettings.Value is null)
            {
                ModelState.AddModelError("", "Please enter Key and Value");
                return View();
            }
            _context.Settings.Add(newSettings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            if (id == 0) return BadRequest();
            Setting? setting = _context.Settings.FirstOrDefault(s => s.Id == id);
            if (setting == null) return BadRequest();
            return View(setting);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Setting newSetting)
        {
            if (id != newSetting.Id) return BadRequest();
            Setting? oldSetting = _context.Settings.FirstOrDefault(s => s.Id == id);
            if (!ModelState.IsValid) return BadRequest();
            oldSetting.Key = newSetting.Key;
            oldSetting.Value = newSetting.Value;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Setting? setting = _context.Settings.FirstOrDefault(s => s.Id == id);
            return View(setting);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Setting deleted)
        {

            _context.Settings.Remove(deleted);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int id)
        {
            Setting? setting = _context.Settings.FirstOrDefault(s => s.Id == id);
            return View(setting);
        }
    }
}
