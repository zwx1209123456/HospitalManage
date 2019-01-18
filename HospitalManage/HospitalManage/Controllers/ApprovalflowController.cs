using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class ApprovalflowController : Controller
    {
        IApprovalflowServices iapprovalflowServices = null;
        public ApprovalflowController(IApprovalflowServices approvalflowServices)
        {
            iapprovalflowServices = approvalflowServices;
        }
        // GET: Approvalflow
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
        public int Add(Approvalflow approvalflow)
        {
            return iapprovalflowServices.Add(approvalflow);
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
            return Json(iapprovalflowServices.Show(), JsonRequestBehavior.AllowGet);
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
        public int Update(Approvalflow approvalflow)
        {
            var result = iapprovalflowServices.Update(approvalflow);
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
            return Json(iapprovalflowServices.Get(Id), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public int Delete(int Id)
        {
            return iapprovalflowServices.Delete(Id);
        }
    }
}