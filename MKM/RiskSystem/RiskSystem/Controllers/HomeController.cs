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
    }
}