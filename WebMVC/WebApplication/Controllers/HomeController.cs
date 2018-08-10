using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 提供一个紧急新闻的分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult UrgentNews() 
        {
            //......可能有判断条件 或获取model
            //返回一个PartialView分部视图  需要model放在名字后面
            return PartialView("_PartialUrgentNews");
        }
    }
}