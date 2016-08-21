using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        { 
            var db = new  PetaPoco.Database("constrng");
            var tblcompnay = db.Fetch<tblCompay>("SELECT * FROM tblCompay");
            return View();
        }
    }
}