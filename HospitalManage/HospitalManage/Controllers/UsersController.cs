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
    public class UsersController : Controller
    {
        IUsersServices iusersServices = null;
        public UsersController(IUsersServices usersServices)
        {
            iusersServices = usersServices;
        }
        [HttpGet]
        // GET: Users
        public List<Users> Show()
        {
            return iusersServices.ShowUsers();
        }
        [HttpPost]
        public int Add(Users users)
        {
            return iusersServices.AddUsers(users);
        }
        [HttpPost]
        public int Update(Users users)
        {
            return iusersServices.UpdateUsers(users);
        }
    }
}