using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public int Logins(string userName, string DepartmentName,string DutyName)
        {
            ///存入Session
            Session["userName"] = userName;
            Session["DepartmentName"] = DepartmentName;
            Session["DutyName"] = DutyName;
            return 1;
        }
    }
}