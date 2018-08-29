using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.DAL;
using WebApplication.ModelView;


namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            HttpFileCollectionBase i = (HttpFileCollectionBase)Request.Files;
            HttpPostedFileBase ii = i[0];
            string aa = new commons().CheckImage(ii);
            return View();
        }
        
        public ActionResult Login()
        {
            ViewBag.loginstate = "登录前.....";
            List<AdminLog> mod = new AccountDAL().GetAllAdminLog();
            return View(mod);
        }

        [HttpPost]
        public ActionResult Login(FormCollection formcollection)
        {
            string Name = formcollection["exampleInputName"];
            string Email = formcollection["exampleInputEmail"];
            ViewBag.loginstate = Name+Email+"登录后.....";
            return View();
        }
        //public JsonResult Login()
        //{ 
        //    List<AdminLog> mod = new AccountDAL().GetAllAdminLog();
        //    return Json(mod);
        //}

        public ActionResult Register()
        {
            return View();
        }
    }
}