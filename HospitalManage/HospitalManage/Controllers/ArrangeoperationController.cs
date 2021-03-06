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
    public class ArrangeoperationController : Controller
    {
        IArrangeoperationServices iarrangeoperationServices = null;
        IDepartmentServices idepartmentServices = null;
        IOperationServices ioperation = null;
        public ArrangeoperationController(IArrangeoperationServices arrangeoperationServices, IDepartmentServices departmentServices, IOperationServices operation)
        {
            idepartmentServices = departmentServices;
            iarrangeoperationServices = arrangeoperationServices;
            ioperation = operation;
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

        //[HttpGet]
        //public JsonResult Indexs()
        //{
        //    return Json(iarrangeoperationServices.Show(), JsonRequestBehavior.AllowGet);
        //}
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
        public int Update(List<Arrangeoperation> operations,int opSId, int opEId)
        {
            if (opSId != 0&& opSId!=opEId)//防止换台次时，没点击或随意点击了手术间就进入此处
            {
                List<Arrangeoperation> operationToScro = operations.Where(m => m.OperationID == opSId).OrderBy(m => m.Were).ToList();
                if (operationToScro.Count!=0)
                {
                    for (int i = 0; i < operationToScro.Count; i++)
                    {
                        operationToScro[i].Were = i + 1;
                    }
                }
            }
            return iarrangeoperationServices.Update(operations);
        }
        /// <summary>
        /// 手术室改变后，确定台次
        /// </summary>
        /// <param name="operationId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult OpChangeReWere(int operationId,string time)
        {
            var result = iarrangeoperationServices.Show().Where(m => m.OperationID == operationId&&(m.OpeTime-DateTime.Parse(time)).Days==1).ToList();
            if (result.Count != 0)
            {
                int i= result.OrderByDescending(m => m.Were).FirstOrDefault().Were+1;
                return Json(i);
            }
            else
            {
                return Json(1);
            }
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
        [HttpGet]
        public ActionResult Show()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Shows(string opTime)
        {
            //var list = iarrangeoperationServices.Show().Where(m => m.OpeTime == DateTime.Parse(opTime)).ToList();
            var list = iarrangeoperationServices.Show().Where(m => (m.OpeTime - DateTime.Parse(opTime)).Days==1).ToList();
            if (list.Count!=0)
            {              
                return Json(list);
            }
            else
            {
                return Json("");
            }
        }
    }
}