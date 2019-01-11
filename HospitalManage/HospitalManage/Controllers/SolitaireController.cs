﻿using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    public class SolitaireController : Controller
    {
        [Unity.Attributes.Dependency]
        public IClassesService ClassesServices { get; set; }
        [Unity.Attributes.Dependency]
        public ISolitaireService solitaireService { get; set; }
        [Unity.Attributes.Dependency]
        public IChainsGroupService chainsGroupService { get; set; }
        [Unity.Attributes.Dependency]
        public IUsersServices usersServices { get; set; }
        static int index = 0;
        // GET: Solitaire
        public ActionResult Index()
        {
            List<string []> w =new List<string[]> { new string[] { "1", "lkjlj", "khll", "ghg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjhjg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjg" } };
        
            ViewBag.y = w;
            return View();
        }
        /// <summary>
        /// 班次
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult ClassesList()
        {
            ///获得所有班次信息
            var clasees = ClassesServices.GetClasses();
            return Json(clasees.ToList(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 接龙小组
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult ChainsGroupList()
        {
            
            var clasees = chainsGroupService.SelectChainsGroup();
            return Json(clasees.ToList(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>

        public List<Users> UsersList()
        {

            //var users =   Json(usersServices.ShowUsers(), JsonRequestBehavior.AllowGet);
            //return users;
            var users = usersServices.ShowUsers().ToList();
            return users;
        }
        public ActionResult AddChains()
        {
            ViewBag.ids = 0;
            string  ids= Request.QueryString["ids"];//获取传过来的值
            if (ids!=null)
            {
                ViewBag.ids = ids;
            }
            ViewBag.index = index;
            return View();
        }
        /// <summary>
        /// 添加接龙组
        /// </summary>
        /// <param name="solitaire"></param>
        /// <param name="chainsGroups"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddChains(Solitaire solitaire, ChainsGroup[] chainsGroups)
        {
            int j = chainsGroupService.AddChainsGroup(chainsGroups.ToList());
            int i = solitaireService.AddSolitaire(solitaire);
            return Json("");
        }

        public ActionResult UodateChains()
        {
            return View();
        }

        public ActionResult AddMember(int id)
        {
            index = id;
            return View(UsersList());
        }
    }
}