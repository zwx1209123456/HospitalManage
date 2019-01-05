using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using IServices;
using Services;
using Unity.Attributes;

namespace HospitalManage.Controllers
{
    public class DepartmentController : Controller
    {
        [Dependency]
        public IDepartmentServices DepartmentServices { get; set; }

        //    public IDepartmentServices idept=null;
        //    public DepartmentController(IDepartmentServices departmentServices)
        //{
        //    idept = departmentServices;
        //}
        //public DepartmentController()
        //{

        //}
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Add(Department department)
        {
            //IDepartmentServices idept1 = idept;
            var result = DepartmentServices.Add(department);
            return result;
        }
        public ActionResult Add()
        {         
            return View();
        }
    }
}