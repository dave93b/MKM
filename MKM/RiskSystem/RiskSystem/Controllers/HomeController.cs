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
            return View();
        }

        [HttpGet]
        public ActionResult AddNewSubLevel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewSubLevel(SubLevel subLevel)
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNewElement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewElement(Element element)
        {
            return View();
        }
    }
}