using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using IServices;
    using Models;   
    public class RuleController : Controller
    {

        IRuleServices iruleServices = null;
        public RuleController(IRuleServices ruleServices)
        {
            iruleServices = ruleServices;
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
        [HttpPost]
        public ActionResult Add()
        {
            return View();
        }
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
        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
        public int Delete(int Id)
        {
            return iruleServices.Delete(Id);
        }
        /// <summary>
        /// 修改排班规则
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Update()
        {
            return View();
        }
        public int Update(Arrangerule arrangerule)
        {
            return iruleServices.Update(arrangerule);
        }
    }
}