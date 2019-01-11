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
    /// <summary>
    /// 用户管理
    /// </summary>
    public class UsersController : Controller
    {
        IDepartmentServices idepartmentServices = null;
        IDutyServices idutyServices = null;
        ITierService itierService = null;
        IUsersServices iusersServices = null;
        public UsersController(IUsersServices usersServices, IDepartmentServices departmentServices, IDutyServices dutyServices, ITierService tierService)
        {
            iusersServices = usersServices;
            idepartmentServices = departmentServices;
            idutyServices = dutyServices;
            itierService = tierService;
        }
        [HttpGet]
        // GET: Users
        public ActionResult Show()
        {
           
            return View();
        }
        public JsonResult Shows()
        {
            
            return Json(iusersServices.ShowUsers(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Users users)
        {
            return iusersServices.AddUsers(users);
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public int Delete(int Id)
        {
            return iusersServices.DeleteUsers(Id);
        }

        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public int Update(Users users)
        {
            var result = iusersServices.UpdateUsers(users);
            return result;
        }
        /// <summary>
        /// 科室显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult GetDepartments()
        {
            //return idepartmentServices.GetDepartments();
            return Json(idepartmentServices.GetDepartments(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 职务显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //// GET: Users
        public JsonResult GetDuties()
        {
           //return idepartmentServices.GetDepartments();
          return Json(idutyServices.GetDuties(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 层级显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: Users
        public JsonResult SelectTier()
        {
            //return idepartmentServices.GetDepartments();
            return Json(itierService.SelectTier(), JsonRequestBehavior.AllowGet);
        }
    }
}