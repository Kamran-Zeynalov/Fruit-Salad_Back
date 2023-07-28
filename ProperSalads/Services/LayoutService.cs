using Microsoft.AspNetCore.Mvc.ActionConstraints;
using ProperSalads.DAL;
using ProperSalads.Models;

namespace ProperSalads.Services
{
    public class LayoutService
    {
        private readonly SaladPageDbContext _context;

        public LayoutService(SaladPageDbContext context)
        {
            _context = context;
        }

        public List<Setting> GetSettings()
        {
            List<Setting> settings = _context.Settings.ToList();
            return settings;
        }
    }
}
