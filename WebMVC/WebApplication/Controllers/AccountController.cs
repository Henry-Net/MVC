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

        public ActionResult Register()
        {
            return View();
        }
    }
}