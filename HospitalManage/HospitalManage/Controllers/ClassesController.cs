using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using Models;
    using Newtonsoft.Json;
    using System.Runtime.CompilerServices;
    using IServices;
    using Unity.Attributes;
    public class ClassesController : Controller
    {
        [Unity.Attributes.Dependency]
        public IClassesService ClassesServices { get; set; }
        // GET: Classes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int ClassesAdd(Classes classes)
        {
            var result = ClassesServices.ClassesAdd(classes);
            return result;
        }
        [HttpGet]
        public JsonResult IndexShow()
        {
            ///获得所有用户信息
            var clasees = ClassesServices.GetClasses();
            return Json(clasees.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public int ClassesDelete(int Id)
        {
            var result = ClassesServices.ClassesDelete(Id);
            return result;
        }
        public int ClassesUpdate(Classes classes)
        {
            var result = ClassesServices.ClassesUpdate(classes);
            return result;
        }
    }
}