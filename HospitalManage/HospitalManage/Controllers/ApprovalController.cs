using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class ApprovalController : Controller
    {
        IApprovalServices iapproval = null;
        public ApprovalController(IApprovalServices approval)
        {
            iapproval = approval;
        }
        // GET: Approval
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加业务
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Approval approval)
        {
            return iapproval.Add(approval);
        }
        /// <summary>
        /// 修改业务表
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Approval approval)
        {
            var result = iapproval.Update(approval);
            return result;
        }
        /// <summary>
        /// 显示业务
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Shows()
        {
            return Json(iapproval.Show(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 获取id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult Get(int Id)
        {
            return Json(iapproval.Get(Id), JsonRequestBehavior.AllowGet);
        }
    }
}