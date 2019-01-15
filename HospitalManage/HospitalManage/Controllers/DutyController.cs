using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using Newtonsoft.Json;
    using System.Runtime.CompilerServices;
    using IServices;
    using Unity.Attributes;
    public class DutyController : Controller
    {
        [Unity.Attributes.Dependency]
        public IDutyServices DutyServices { get; set; }
        // GET: Duty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public int DutyAdd(Duty duty)
        {
            var result = DutyServices.DutyAdd(duty);
            return result;
        }
        [HttpGet]
        public JsonResult IndexShow()
        {
            ///获得所有用户信息
            var dutys = DutyServices.GetDuties();
            return Json(dutys.ToList(),JsonRequestBehavior.AllowGet);          
        }
        [HttpPost]
        public int DutyDelete(int Id)
        {
            var result = DutyServices.DutyDelete(Id);
            return result;
        }
        public int DutyUpdate(Duty duty)
        {
            var result = DutyServices.DutyUpdate(duty);
            return result;
        }
    }
}