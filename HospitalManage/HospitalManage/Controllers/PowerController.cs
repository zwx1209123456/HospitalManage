using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using Models;
using IServices;

namespace HospitalManage.Controllers
{
    public class PowerController : Controller
    {
        [Dependency]
        
        public IPowerServices PowerServices { get; set; }
        // GET: Power
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetPowers()
        {
            return Json(PowerServices.GetPowers(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Power power)
        {
            var result = PowerServices.Add(power);
            return result;
        }
        [HttpPost]
        public int Delete(int Id)
        {
            var result = PowerServices.Delete(Id);
            return result;
        }


        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Power power)
        {
            var result = PowerServices.Update(power);
            return result;
        }
        [HttpGet]
        public JsonResult GetPower(int Id)
        {
            return Json(PowerServices.GetPower(Id), JsonRequestBehavior.AllowGet);
        }
    }
}