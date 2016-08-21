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
            if (DataServices.Services.LoginService.Instance.LoginAuth(txtusername, txtpass)) {
                Session["Logged_in"] = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid Username or Password!";
                return View();
                //return RedirectToAction("Index", "UserManagement");
            }         
        }



    }
}