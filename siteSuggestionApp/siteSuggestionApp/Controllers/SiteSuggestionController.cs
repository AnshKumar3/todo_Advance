using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using siteSuggestionApp.Data;
using siteSuggestionApp.Models;
using siteSuggestionApp.Models;
using System.Threading.Tasks;

namespace SiteSuggestionApp.Controllers
{
    public class SiteSuggestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SiteSuggestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SiteSuggestions.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SiteSuggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suggestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suggestion);
        }
    }
}
