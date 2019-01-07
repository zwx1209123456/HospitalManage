using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    public class SolitaireController : Controller
    {
        // GET: Solitaire
        public ActionResult Index()
        {
            List<string []> w =new List<string[]> { new string[] { "1", "lkjlj", "khll", "ghg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjhjg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjg" } };
        
            ViewBag.y = w;
            return View();
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