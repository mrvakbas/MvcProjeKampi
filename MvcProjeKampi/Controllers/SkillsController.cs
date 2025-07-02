using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class SkillsController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillDal());
        public ActionResult Index()
        {
            var skill = sm.GetList();
            return View(skill);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            sm.SkillAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = sm.GetByID(id);
            return View(skill);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill p)
        {
            sm.SkillUpdate(p);
            return RedirectToAction("Index");
        }
    }
}