using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;

namespace HospitalManage.Controllers
{
    public class SpecialtyController : Controller
    {
        [Dependency]
        public ISpecialtyServices SpecialtyServices { get; set; }
        // GET: Specialty
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Specialty specialty)
        {
            var result = SpecialtyServices.Add(specialty);
            return result;
        }

        [HttpPost]
        public JsonResult GetSpecialties(string DepartmentID)
        {
            return Json(SpecialtyServices.GetSpecialties(Convert.ToInt32( DepartmentID)),JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SelectChange()
        {
            return View();
        }
    }
}