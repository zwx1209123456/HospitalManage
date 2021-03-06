﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Services;
    using IServices;
    using Models;
    public class ToArrOperationController : Controller
    {
        IArrangeoperationServices iarrangeoperationServices = null;
        IDepartmentServices idepartmentServices = null;
        IOperationServices ioperation = null;
        public ToArrOperationController(IArrangeoperationServices arrangeoperationServices, IDepartmentServices departmentServices, IOperationServices operation)
        {
            idepartmentServices = departmentServices;
            iarrangeoperationServices = arrangeoperationServices;
            ioperation = operation;
        }
     
       
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
        public int Update(List<Arrangeoperation> operations)
        {
            return iarrangeoperationServices.Update(operations);
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
        /// <summary>
        /// 科室显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult GetDepartments()
        {
            return Json(idepartmentServices.GetDepartments(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 手术间
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult ShowOperation()
        {
            return Json(ioperation.ShowOperation(), JsonRequestBehavior.AllowGet);
        }
    }
}