using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Models;
    using IServices;
    public class NodeController : Controller
    {
        INodeServices inodeServices = null;
        public NodeController(INodeServices nodeServices)
        {
            inodeServices = nodeServices;
        }
        // GET: Node
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
        public int Add(Node node)
        {
            return inodeServices.Add(node);
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
            return Json(inodeServices.Show(), JsonRequestBehavior.AllowGet);
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
        public int Update(Node node)
        {
            var result = inodeServices.Update(node);
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
            return Json(inodeServices.Get(Id), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除审批条件
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public int Delete(int Id)
        {
            return inodeServices.Delete(Id);
        }
    }
}