using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: UserManagement
        public ActionResult Index()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult Index(string txtusername, string txtpass)
        {

            if (Login(txtusername, txtpass)) {
                Session["Logged_in"] = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "UserManagement");
            }
            
        }

        public bool Login(string username, string pass)
        {
            return DataServices.Services.LoginService.Instance.LoginAuth(username, pass);
        }


    }
}