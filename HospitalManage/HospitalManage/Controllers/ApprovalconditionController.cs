using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class ApprovalconditionController : Controller
    {
        IApprovalconditionServices iapprovalcondition = null;
        public ApprovalconditionController(IApprovalconditionServices approvalcondition)
        {
            iapprovalcondition = approvalcondition;
        }
        // GET: Approvalcondition
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加审批条件
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Approvalcondition approvalcondition)
        {
            return iapprovalcondition.Add(approvalcondition);
        }
        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Shows()
        {
            return Json(iapprovalcondition.Show(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 修改审批条件
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Approvalcondition approvalcondition)
        {
            var result = iapprovalcondition.Update(approvalcondition);
            return result;
        }
        /// <summary>
        /// 获取id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult Get(int Id)
        {
            return Json(iapprovalcondition.Get(Id), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public int Delete(int Id)
        {
            return iapprovalcondition.Delete(Id);
        }
    }
}