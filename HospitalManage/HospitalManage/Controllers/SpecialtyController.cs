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

        /// <summary>
        /// 添加专业分组
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// 根据科室获取用户
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetUsers(string DepartmentID)
        {
            return Json(SpecialtyServices.GetUsers(Convert.ToInt32( DepartmentID)),JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 显示专业分组
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetSpecialties()
        {
            return Json(SpecialtyServices.GetSpecialties(), JsonRequestBehavior.AllowGet);
        }
    }
}