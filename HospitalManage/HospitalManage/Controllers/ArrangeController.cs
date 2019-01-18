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
    public class ArrangeController : Controller
    {
        //[Unity.Attributes.Dependency]
        //public IArrangeService ArrangeServices { get; set; }
        // GET: Arrange
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        //[HttpPost]
        //public int ArrangeAdd(Arrange arrange)
        //{
        //    var result = ArrangeServices.ArrangeAdd(arrange);
        //    return result;
        //}
        //[HttpGet]
        //public JsonResult IndexShow()
        //{
        //    ///获得所有用户信息
        //    var arrange = ArrangeServices.GetArranges();
        //    return Json(arrange.ToList(), JsonRequestBehavior.AllowGet);
        //}
        //[HttpPost]
        //public int ArrangeDelete(int Id)
        //{
        //    var result = ArrangeServices.ArrangeDelete(Id);
        //    return result;
        //}
        //public int ArrangeUpdate(Arrange arrange)
        //{
        //    var result = ArrangeServices.ArrangeUpdate(arrange);
        //    return result;
        //}
    }
}
