using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Hegemony.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Hegemony.Controllers
{
    public class GameController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Setup()
        {
            ViewBag.ArmyId = new SelectList(db.Armies, "ArmyId", "Name");
            ViewBag.TechnologyId = new SelectList(db.Technologies, "TechnologyId", "Name");
            ViewBag.GeographyId = new SelectList(db.Geographies, "GeographyId", "Name");
            ViewBag.EconomicsId = new SelectList(db.Economics, "EconomicsId", "Name");
            ViewBag.GovernmentId = new SelectList(db.Governments, "GovernmentId", "Name");


            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Character character)
        //{
        //    db.Characters.Add(character);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public IActionResult newGovernment(int id)
        {
            var test = id;
            var newGovernmentDescription = db.Governments.FirstOrDefault(Government => Government.GovernmentId == id);
            return Json(newGovernmentDescription);
        }

    }
}
