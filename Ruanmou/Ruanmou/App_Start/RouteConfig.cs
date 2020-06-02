using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ruanmou
{
    /// 路由，映射，按照规则转发
    /// http://localhost:2017/Second/index
    /// 从/Second/index开始匹配
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //忽略路由 正则表达式 {resource}表示变量 只要.axd文件全部忽略
            //{ resource}.axd   表示后缀名为.axd所有资源 如webresource.axd
            //{ *pathInfo}       表示所有路径
            //            axd 是对自C:\Windows\Microsoft.NET\Framework64\v4.0.30319\aspnet_isapi.dll 的隐射。
            //后缀名.axd 就是一个baiashx一样的weweb handler,实现接口IHttpHandler的方法。du
            //这样的好处可以：可以免去繁琐的控件zhi解析过程和页面处dao理过程。
            //MVC的页面生命周期。
            ///.axd是历史原因，最开始都是webform,请求都是。aspx后缀，IIS根据后缀转发请求
            ///MVC出现了，没有后最。IIS6以及更早版本，打了个补丁，把MVC的请求加上个
            ///.axd的后缀，然后这种都转发到网站--新版本的IIS以及不需要了，遇到了就直接忽略，还是走原始流程
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
                  name: "Default",//路由名称 RouteCollection是key-value,key避免重复
                url: "{controller}/{action}/{id}",//正则规则：二个斜线三个变量 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }///默认值 没有id变量 就是UrlParameter.optional 没有action就是index
                                                                                                   ///没有Controller就是home
            );
        }
    }
}
