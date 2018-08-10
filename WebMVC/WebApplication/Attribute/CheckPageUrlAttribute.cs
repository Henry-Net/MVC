using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Attribute
{
    /// <summary>
    /// 创建一个特性  在被赋予特性的方法前执行  result 返回一个带key的地址
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class CheckPageUrlAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var key = filterContext.HttpContext.Request.QueryString["UniqueKey"];
            if (key != null)
            {
                var tourOrder = GetTourOrderBySessionKeyNoPrice(key);
                if (!string.IsNullOrEmpty(tourOrder.LastPageUrl))
                {
                    filterContext.Result = new RedirectResult(String.Format("{0}?UniqueKey={1}", tourOrder.LastPageUrl, key));
                }
            }
        }

        /// <summary>
        /// 应该放在BAL层
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Sessions GetTourOrderBySessionKeyNoPrice(string key)
        {
            return (Sessions)HttpContext.Current.Session[key];
        }

    }
    
}