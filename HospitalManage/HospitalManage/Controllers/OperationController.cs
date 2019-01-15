using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using IServices;
    public class OperationController : Controller
    {
        IOperationServices ioperation = null;
        public OperationController(IOperationServices operation)
        {
            ioperation = operation;
        }
        // GET: Operation
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Indexs()
        {
            return Json(ioperation.ShowOperation(), JsonRequestBehavior.AllowGet);
        }
    }
}