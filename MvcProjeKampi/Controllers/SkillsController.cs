using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    }
}