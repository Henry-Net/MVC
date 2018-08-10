using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        /// <summary>
        /// 该方法名必须按一定规范写
        /// 参考 https://blog.csdn.net/yiyelanxin/article/details/73733184
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string currentUrl = HttpContext.Current.Request.Url.ToString().ToLower();
            if (currentUrl.EndsWith("/home/index")||currentUrl.EndsWith("/index"))
            {
                Response.Redirect(currentUrl.Replace(HttpContext.Current.Request.Url.LocalPath, string.Empty));
            }
        }
        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    HttpContext ctx = HttpContext.Current;
        //    Exception ex = ctx.Server.GetLastError();
        //    ctx.Response.Clear();
        //    if (ex != null)
        //    {
        //        RequestContext rc = ((MvcHandler)ctx.CurrentHandler).RequestContext;
        //        rc.RouteData.Values["action"] = "ErrorPage";
        //        rc.RouteData.Values["controller"] = "Home";

        //        IControllerFactory factory = ControllerBuilder.Current.GetControllerFactory();
        //        IController controller = factory.CreateController(rc, "Home");

        //        controller.Execute(rc);
        //        ctx.Server.ClearError();
        //    }
        //}
    }
}
