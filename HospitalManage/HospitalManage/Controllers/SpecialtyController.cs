using IServices;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;

namespace HospitalManage.Controllers
{
    public class SpecialtyController : Controller
    {
        [Dependency]
        public ISpecialtyServices SpecialtyServices { get; set; }
        // GET: Specialty

        private const int PAGECOUNT = 3;
        /// <summary>
        /// 添加专业分组
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Specialty specialty)
        {
            var result = SpecialtyServices.Add(specialty);
            return result;
        }


        /// <summary>
        /// 根据科室获取用户
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetUsers(string DepartmentID)
        {
            return Json(SpecialtyServices.GetUsers(Convert.ToInt32( DepartmentID)),JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 显示专业分组
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetSpecialties(string SpecialtyName,int Page = 1)
        {
            List<Specialty> specialties = SpecialtyServices.GetSpecialties().ToList();
            PageBox pageBox = new PageBox();
            if (!string.IsNullOrWhiteSpace(SpecialtyName))
            {
                specialties = specialties.Where(r => r.SpecialtyName.Contains(SpecialtyName)).ToList();
            }
            pageBox.CurrentPage = Page;
            pageBox.TotlePage = (specialties.Count / PAGECOUNT) + (specialties.Count % PAGECOUNT == 0 ? 0 : 1);
            pageBox.Data = specialties.Skip((Page - 1) * PAGECOUNT).Take(PAGECOUNT);

            //return pageBox;
            return Json(pageBox, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除专业组
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public int Delete(int Id)
        {
            var result = SpecialtyServices.Delete(Id);
            return result;
        }
        /// <summary>
        /// 修改专业组
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        [HttpPost]
        public int Update(Specialty specialty)
        {
            var result = SpecialtyServices.Update(specialty);
            return result;
        }
        public ActionResult Update()
        {
            return View();
        }
        /// <summary>
        /// 获取单个分组
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetSpecialty(int Id)
        {
            return Json(SpecialtyServices.GetSpecialty(Id), JsonRequestBehavior.AllowGet);
        }
    }
}