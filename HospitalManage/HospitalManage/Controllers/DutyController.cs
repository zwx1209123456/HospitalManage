using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using Models;
    public class DutyController : Controller
    {
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
            return new DutyServices().DutyAdd(duty);
        }
    }
}