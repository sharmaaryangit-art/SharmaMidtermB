using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SharmaMidtermB.Data;

namespace SharmaMidtermB.Controllers {
    public class PlayerController : Controller {
        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Players.ToListAsync());
        }
    }
}