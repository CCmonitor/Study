using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ruanmou
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );///固定路由，/Home/About--About
            ///URL地址匹配是不区分大小写的
            routes.MapRoute(
                name: "Test",
                url: "Test/{action}/{id}",
                defaults: new { controller = "Second", action = "Index", id = UrlParameter.Optional }
            );///修改控制器

            routes.MapRoute(
                name: "Regex",
                url: "{controller}/{action}_{year}_{month}_{day}/{id}",
                defaults: new { controller = "Second", action = "Index", id = UrlParameter.Optional },
                constraints:new { year=@"\d{4}",month=@"\d{2}",day=@"\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
