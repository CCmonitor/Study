using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ruanmou.Controllers
{
    /// <summary>
    /// 1.Route的使用和扩展，Area
    /// 2.Razor语法，前后端语法混编
    /// 3.Html扩展控件，后端封装前端
    /// 4.模板页Layout,局部页PartialView
    /// 5.IOC和MVC的结合，工厂的创建和Bussiness初始化
    /// 
    /// MVCApplicaiton--Applicaiton_start--RegisterRoutes--RouteCollectiont添加规则
    /// 请求进到网站--X?--请求地址被路由按顺序匹配--遇到一个吻合的结束--就到对应的控制器 和Action
    /// </summary>
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            return View();
        }
    }
}