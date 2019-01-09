using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    public class CaseController : Controller
    {
        /// <summary>
        /// 演示显示页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 顶部页面
        /// </summary>
        /// <returns></returns>
        public ActionResult HeadPage()
        {
            return View();
        }
        /// <summary>
        /// 左侧菜单
        /// </summary>
        /// <returns></returns>
        public ActionResult LeftMenu()
        {
            return View();
        }
        /// <summary>
        /// 首页 主页面
        /// </summary>
        /// <returns></returns>
        public ActionResult HomePage()
        {
            return View();
        }
    }
}