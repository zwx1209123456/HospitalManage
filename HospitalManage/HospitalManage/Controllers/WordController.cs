using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            ViewBag.userName = Session["userName"];
            ViewBag.DepartmentName = Session["DepartmentName"];
            ViewBag.DutyName = Session["DutyName"];
            return View();
        }
        //public int Add()
        //{
        //    return View();
        //}
    }
}