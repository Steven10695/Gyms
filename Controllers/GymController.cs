using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using gym.Data;
using gym.Models;

namespace gym.Controllers
{
    public class GymController : Controller
    {
        private GymContext _context;
        public GymController(GymContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Gym p) {
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var gyms = _context.Gyms.OrderBy(x => x.Nombre).ToList();
            return View(gyms);
        }
    }
}