using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Unity.Attributes;
    using IServices;
    using Models;
    using System.Web.Helpers;

    public class TierController : Controller
    {
        [Dependency]
        public ITierService tierService { get; set; }
        // GET: Tier
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddTier(Tier tier)
        {
            tierService.AddTier(tier);
            var list = tierService.SelectTier();
            return Json(list);
        }

        [HttpPost]
        public JsonResult DelTier(int id)
        {
            tierService.DelTier(id);
            var list = tierService.SelectTier();
            return Json(list);
        }

        [HttpGet]
        public JsonResult SelectTier()
        {
            var list = tierService.SelectTier();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateTier(Tier tier)
        {
            tierService.UpdateTier(tier);
            var list = tierService.SelectTier();
            return Json(list);
        }
    }
}