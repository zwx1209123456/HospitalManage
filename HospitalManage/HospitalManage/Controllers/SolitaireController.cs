using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    public class SolitaireController : Controller
    {
        [Unity.Attributes.Dependency]
        public IClassesService ClassesServices { get; set; }
        // GET: Solitaire
        public ActionResult Index()
        {
            List<string []> w =new List<string[]> { new string[] { "1", "lkjlj", "khll", "ghg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjhjg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjg" } };
        
            ViewBag.y = w;
            return View();
        }
        [HttpGet]
        public JsonResult ClassesList()
        {
            ///获得所有班次信息
            var clasees = ClassesServices.GetClasses();
            return Json(clasees.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddChains()
        {
            return View();
        }

        public ActionResult UodateChains()
        {
            return View();
        }

        public ActionResult AddMember()
        {
            return View();
        }
    }
}