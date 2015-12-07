using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiskSystem.Models;

namespace RiskSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MainLevels()
        {
            var context = new RiskSystemEntities();
            return View(context.MainLevels.ToList());
        }

        public ActionResult SubLevels()
        {
            var context = new RiskSystemEntities();
            ViewBag.MainLevels = context.MainLevels.ToList();
            return View(context.SubLevels.ToList());
        }

        public ActionResult Elements()
        {
            var context=new RiskSystemEntities();
            ViewBag.SubLevels = context.SubLevels.ToList();
            ViewBag.MainLevels = context.MainLevels.ToList();
            return View(context.Elements.ToList());
        }

        public ActionResult Damages()
        {
            var context = new RiskSystemEntities();
            return View(context.Damages.ToList());
        }

        public ActionResult DamagePlaces()
        {
            var context = new RiskSystemEntities();
            ViewBag.MainLevels = context.MainLevels.ToList();
            ViewBag.SubLevels = context.SubLevels.ToList();
            ViewBag.Elements = context.Elements.ToList();
            ViewBag.Damages = context.Damages.ToList();
            return View(context.DamagePlaces.ToList());
        }

        [HttpGet]
        public ActionResult AddNewMainLevel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewMainLevel(MainLevel mainLevel)
        {
            var context = new RiskSystemEntities();
            context.MainLevels.Add(mainLevel);
            context.SaveChanges();
            return RedirectToAction("MainLevels");
        }

        [HttpGet]
        public ActionResult AddNewSubLevel()
        {
            var context = new RiskSystemEntities();
            ViewBag.MainLevels = context.MainLevels.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddNewSubLevel(SubLevel subLevel)
        {
            var context = new RiskSystemEntities();
            context.SubLevels.Add(subLevel);
            context.SaveChanges();
            return RedirectToAction("SubLevels");
        }

        [HttpGet]
        public ActionResult AddNewElement()
        {
            var context = new RiskSystemEntities();
            ViewBag.SubLevels = context.SubLevels.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddNewElement(Element element)
        {
            var context = new RiskSystemEntities();
            context.Elements.Add(element);
            context.SaveChanges();
            return RedirectToAction("Elements");
        }

        [HttpGet]
        public ActionResult AddNewDamage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewDamage(Damage damage)
        {
            var context = new RiskSystemEntities();
            context.Damages.Add(damage);
            context.SaveChanges();
            return RedirectToAction("Damages");
        }

        [HttpGet]
        public ActionResult AddNewDamagePlace()
        {
            var context = new RiskSystemEntities();
            ViewBag.MainLevels = context.MainLevels.ToList();
            ViewBag.SubLevels = context.SubLevels.ToList();
            ViewBag.Elements = context.Elements.ToList();
            ViewBag.Damages = context.Damages.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddNewDamagePlace(/*DamagePlace damagePlace*/int? LevelId, int? SubLevelId, int? ElementId, int DamageLevel, int DamageId)
        {
            var context = new RiskSystemEntities();
            DamagePlace damagePlace=new DamagePlace();
            damagePlace.LevelId = LevelId;
            damagePlace.SubLevelId = SubLevelId;
            damagePlace.ElementId = ElementId;
            damagePlace.DamageId = DamageId;
            context.DamagePlaces.Add(damagePlace);
            context.SaveChanges();
            return RedirectToAction("DamagePlaces");
        }
    }
}