using CommHelps;
using IServices;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace HospitalManage.Controllers
{
    using Services;
    using IServices;
    using Models;
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
            //List<string []> w =new List<string[]> { new string[] { "1", "lkjlj", "khll", "ghg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjhjg" }, new string[] { "jkh", "lkjlj", "khll", "ugjjg" } };
        
            //ViewBag.y = w;
            return View();
        }
        /// <summary>
        /// 接龙显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult IndexShow()
        {
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                List<SoChains> list = conn.Query<SoChains>("up_ChainsTable", null).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
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
            //ViewBag.ids = 0;
            //string  ids= Request.QueryString["ids"];//获取传过来的值
            //if (ids!=null)
            //{
            //    ViewBag.ids = ids;
            //}
            
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
            var ids = "";
            Solitaire solitaireIf = solitaireService.SelectSolitaire().Where(m => m.SolitaireClassID == solitaire.SolitaireClassID).FirstOrDefault();
            if (solitaireIf != null)
            {
                return Json("");
            }
            List<ChainsGroup> groupListToAdd = new List<ChainsGroup>();
            foreach (var item in chainsGroups)
            {
                if (item.GropCrew!=null)
                {
                    groupListToAdd.Add(item);
                }
            }

            int j = chainsGroupService.AddChainsGroup(groupListToAdd);
            List<ChainsGroup> chainsGroupList= chainsGroupService.SelectChainsGroup().Where(m => m.ClassesId == solitaire.SolitaireClassID).ToList();
            foreach (var item in chainsGroupList)
            {
                ids += item.Id+",";
            }
            solitaire.ChainsGroupIds = ids.Substring(0,ids.Length-1);
            Solitaire solitaireModel = solitaireService.SelectSolitaire().LastOrDefault();
            if (solitaireModel!=null)
            {
                solitaire.SoSortNumber = solitaireModel.SoSortNumber + 1;
            }
            else
            {
                solitaire.SoSortNumber = 1;
            }
            int i = solitaireService.AddSolitaire(solitaire);
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                List<SoChains> list = conn.Query<SoChains>("up_ChainsTable", null).ToList();
                return Json(list);
            }
            
        }
        static List<SoChains> list = new List<SoChains>();
        public ActionResult UodateChains(string classesName)
        {
            //string chainsClasses = Request.QueryString["classesName"].Trim();
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                list = conn.Query<SoChains>("up_ChainsTable", null).Where(m=>m.ClassesName== classesName).ToList();
                //ViewBag.list = Json(list);
                return View();
            }
        }
        /// <summary>
        /// 修改反填
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult getUodateChains()
        {
            return Json(list,JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 修改接龙
        /// </summary>
        /// <param name="solitaire"></param>
        /// <param name="chainsGroups"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UodateChains(Solitaire solitaire, ChainsGroup[] chainsGroups)
        {
            var ids = "";
            List<ChainsGroup> chainsGroupsToAdd = new List<ChainsGroup>();
            List<ChainsGroup> chainsGroupsToUpdate = new List<ChainsGroup>();
            List<ChainsGroup> chainsGroupsToDel = new List<ChainsGroup>();
            foreach (var item in chainsGroups)
            {
                if (item.Id==0)
                {
                    if (item.GropCrew!=null)
                    {
                        chainsGroupsToAdd.Add(item);
                    }                             
                }
                else
                {
                    if (item.GropCrew !=null)
                    {
                        chainsGroupsToUpdate.Add(item);
                    }
                    else
                    {
                        chainsGroupsToDel.Add(item);
                    }
                }
            }
           
            int i = 0;
            if (chainsGroupsToUpdate.Count != 0)
            {
                
                for (i = 0; i < chainsGroupsToUpdate.Count; i++)
                {
                    chainsGroupsToUpdate[i].SortNumber = i + 1;
                }
                int updateResult = chainsGroupService.UpdateChainsGroup(chainsGroupsToUpdate);
            }
            if (chainsGroupsToDel.Count != 0)
            {
                int updateResult = chainsGroupService.DelChainsGroup(chainsGroupsToDel);
            }
            int j = 0;
            if (chainsGroupsToAdd.Count != 0)
            {
                ChainsGroup  chainsGroup = chainsGroupService.SelectChainsGroup().Where(m => m.ClassesId == solitaire.SolitaireClassID).LastOrDefault();
                for (j = 0; j < chainsGroupsToAdd.Count; j++)
                {
                    chainsGroupsToAdd[j].SortNumber = chainsGroup.SortNumber + j+1;
                }
                int addResult = chainsGroupService.AddChainsGroup(chainsGroupsToAdd);
            }
            List<ChainsGroup> chainsGroupList = chainsGroupService.SelectChainsGroup().Where(m => m.ClassesId == solitaire.SolitaireClassID).ToList();
            foreach (var item in chainsGroupList)
            {
                ids += item.Id + ",";
            }
            solitaire.ChainsGroupIds = ids.Substring(0, ids.Length - 1);
            int result = solitaireService.UpdateSolitaire(solitaire);
            using (MySqlConnection conn = DapperHelper.Instance().GetConnection())
            {
                List<SoChains> list = conn.Query<SoChains>("up_ChainsTable", null).ToList();
                return Json(list);
            }
        }
        /// <summary>
        /// 添加组员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult AddMember(int id)
        {
            index = id;
            ViewBag.index = index;
            return View(UsersList());
        }
        [HttpPost]
        public void DelChains(int classesId)
        {
        
            int i = 0;
            int delSoResult = solitaireService.DelSolitaire(classesId);
            List<ChainsGroup> chainsGroupsToDel = chainsGroupService.SelectChainsGroup().Where(m => m.ClassesId == classesId).ToList();
       
            int delChResult = chainsGroupService.DelChainsGroup(chainsGroupsToDel);
            List<Solitaire> list = solitaireService.SelectSolitaire().ToList();
            for (i = 0; i < list.Count; i++)
            {
                list[i].SoSortNumber = i + 1;
                int updateResult = solitaireService.UpdateSolitaire(list[i]);
            }
           
        }
    }
}