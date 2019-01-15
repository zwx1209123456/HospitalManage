using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    /// <summary>
    /// 排班规则
    /// </summary>
    public class RuleController : Controller
    {
        IClassesService iclassesService = null;
        IRuleServices iruleServices = null;
        public RuleController(IRuleServices ruleServices, IClassesService classesService)
        {
            iruleServices = ruleServices;
            iclassesService = classesService;
        }
        // GET: Rule
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加排班规则
        /// </summary>
        /// <returns></returns>
        
        public ActionResult Add()
        {
          
            return View();
        }
        [HttpPost]
        public int Add(Arrangerule arrangerule)
        {
            return iruleServices.Add(arrangerule);
        }
        /// <summary>
        /// 显示排班规则
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Show()
        {
            return View();
        }
        public JsonResult Shows()
        {
            return Json(iruleServices.Show(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除排班规则
        /// </summary>
        /// <returns></returns>
        
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public int Delete(string Id)
        {
            return iruleServices.Delete(Convert.ToInt32(Id));
            //return Json(SpecialtyServices.GetSpecialties(Convert.ToInt32(DepartmentID)), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 修改排班规则
        /// </summary>
        /// <returns></returns>
        
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Arrangerule arrangerule)
        {
            return iruleServices.Update(arrangerule);
        }
        /// <summary>
        /// 班次显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult GetClasses()
        {
            //return idepartmentServices.GetDepartments();
            return Json(iclassesService.GetClasses(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        // GET: Users
        public JsonResult Get(string Id)
        {
            //return idepartmentServices.GetDepartments();
            return Json(iruleServices.Get(Convert.ToInt32(Id)), JsonRequestBehavior.AllowGet);
           
        }
      
    }
}