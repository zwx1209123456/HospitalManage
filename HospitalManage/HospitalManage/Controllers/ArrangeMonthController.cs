using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IServices;
using Unity.Attributes;

namespace HospitalManage.Controllers
{
    public class ArrangeMonthController : Controller
    {
        [Dependency]
        public IArrangeMonthServices ArrangeMonthServices { get; set; }
        // GET: ArrangeMonth
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetArrangeMonth()
        {
            return Json(ArrangeMonthServices.GetArrangeMonth(), JsonRequestBehavior.AllowGet);
        }
    }
}