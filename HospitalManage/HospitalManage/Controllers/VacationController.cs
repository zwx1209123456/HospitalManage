using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class VacationController : Controller
    {
        IVacationServices ivacationServices = null;
        public VacationController(IVacationServices vacationServices)
        {
            ivacationServices = vacationServices;
        }
        // GET: Vacation
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
        public int Add(Vacation vacation)
        {
            return ivacationServices.Add(vacation);
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
            return Json(ivacationServices.Show(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public int Delete(int Id)
        {
            return ivacationServices.Delete(Id);
        }
        /// <summary>
        /// 获取id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult Get(int Id)
        {
            return Json(ivacationServices.Get(Id), JsonRequestBehavior.AllowGet);
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
        public int Update(Vacation vacation)
        {
            var result = ivacationServices.Update(vacation);
            return result;
        }
    }
}