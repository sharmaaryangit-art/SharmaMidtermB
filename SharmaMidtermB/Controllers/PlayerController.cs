using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharmaMidtermB.Data;
using SharmaMidtermB.Models;
using System.Numerics;
using System.Threading.Tasks;

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


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Players.Add(player);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

    }
}