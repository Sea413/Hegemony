using Hegemony.Models;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Hegemony.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public GameController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db
            )
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<ActionResult> Setup()
        {
            
            ViewBag.ArmyId = new SelectList(_db.Armies, "ArmyId", "Name");
            ViewBag.TechnologyId = new SelectList(_db.Technologies, "TechnologyId", "Name");
            ViewBag.GeographyId = new SelectList(_db.Geographies, "GeographyId", "Name");
            ViewBag.EconomyId = new SelectList(_db.Economies, "EconomyId", "Name");
            ViewBag.GovernmentId = new SelectList(_db.Governments, "GovernmentId", "Name");


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Setup(Nation nation)
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            nation.User = currentUser;
            _db.Nations.Add(nation);
            _db.SaveChanges();
            return RedirectToAction("Setup");
        }

        public IActionResult newGovernment(int id)
        {
            var newGovernmentDescription = _db.Governments.FirstOrDefault(Government => Government.GovernmentId == id);
            return Json(newGovernmentDescription);
        }

        public IActionResult newArmy(int id)
        {
            var newArmyDescription = _db.Armies.FirstOrDefault(Army => Army.ArmyId == id);
            return Json(newArmyDescription);
        }

        public IActionResult newEconomy(int id)
        {
            var newEconomyDescription = _db.Economies.FirstOrDefault(Economy => Economy.EconomyId == id);
            return Json(newEconomyDescription);
        }

        public IActionResult newTechnology(int id)
        {
            var newTechnologyDescription = _db.Technologies.FirstOrDefault(Technology => Technology.TechnologyId == id);
            return Json(newTechnologyDescription);
        }

        public IActionResult newGeography(int id)
        {
            var newGeographyDescription = _db.Geographies.FirstOrDefault(Geography => Geography.GeographyId == id);
            return Json(newGeographyDescription);
        }
    }
}