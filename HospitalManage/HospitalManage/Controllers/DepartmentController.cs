using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using IServices;
using Unity.Attributes;

namespace HospitalManage.Controllers
{
    /// <summary>
    /// 科室管理控制器
    /// </summary>
    public class DepartmentController : Controller
    {
        /// <summary>
        /// 属性注入
        /// </summary>
        [Dependency]
        public IDepartmentServices DepartmentServices { get; set; }
        //构造函数注入
        //public IDepartmentServices idept=null;
        //public DepartmentController(IDepartmentServices departmentServices)
        //{
        //    idept = departmentServices;
        //}
        //public DepartmentController()
        //{
        //}
        // GET: Department
        /// <summary>
        /// 添加科室
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 显示科室
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetDepartments()
        {
            //var result = DepartmentServices.GetDepartments();
            //return result;
            return Json(DepartmentServices.GetDepartments(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Delete(int Id)
        {
            var result = DepartmentServices.Delete(Id);
            return result;
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public int Update(Department department)
        {
            var result = DepartmentServices.Update(department);
            return result;
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}