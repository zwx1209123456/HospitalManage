﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using IServices;
    public class ArrangeoperationController : Controller
    {
        IArrangeoperationServices iarrangeoperationServices = null;
        public ArrangeoperationController(IArrangeoperationServices arrangeoperationServices)
        {
            iarrangeoperationServices = arrangeoperationServices;
        }
        /// <summary>
        /// 显示手术申请
        /// </summary>
        /// <returns></returns>
        // GET: Arrangeoperation
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Indexs()
        {
            return Json(iarrangeoperationServices.Show(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加手术申请
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Arrangeoperation arrangeoperation)
        {
            return iarrangeoperationServices.Add(arrangeoperation);
        }
        /// <summary>
        /// 删除手术申请
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public int Delete(int Id)
        {
            return iarrangeoperationServices.Delete(Id);
            //return Json(SpecialtyServices.GetSpecialties(Convert.ToInt32(DepartmentID)), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 修改手术申请
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Arrangeoperation arrangeoperation)
        {
            return iarrangeoperationServices.Update(arrangeoperation);
        }
        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult Get(string Id)
        {
            //return idepartmentServices.GetDepartments();
            return Json(iarrangeoperationServices.Get(Convert.ToInt32(Id)), JsonRequestBehavior.AllowGet);

        }
    }
}