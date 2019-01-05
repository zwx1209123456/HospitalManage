using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManage.Controllers
{
    using Unity.Attributes;
    using IServices;
    using Models;

    public class TierController : Controller
    {
        [Dependency]
        public ITierService tierService { get; set; }
        // GET: Tier
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public List<Tier> AddTier(Tier tier)
        {
            tierService.AddTier(tier);
            var list = tierService.SelectTier();
            return list;
        }

        [HttpPost]
        public List<Tier> DelTier(int id)
        {
            tierService.DelTier(id);
            var list = tierService.SelectTier();
            return list;
        }

        [HttpGet]
        public List<Tier> SelectTier()
        {
            var list = tierService.SelectTier();
            return list;
        }

        [HttpPost]
        public List<Tier> UpdateTier(Tier tier)
        {
            tierService.UpdateTier(tier);
            var list = tierService.SelectTier();
            return list;
        }
    }
}