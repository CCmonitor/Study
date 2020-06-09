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
    /// 
    /// 因为一个web项目可以非常大，非常复杂。多人合作开发，命名就成维提了。Area可以把项目
    /// 拆分开，方便团队合作，演变到后面可以做成插件式开发
    /// 
    /// mvcApplication--Application_Statrt--AreaRegistration.RegisterAllAreas()--
    /// 其实就是把SystemAreaRegistration给注册下--添加URL地址规则--请求来了就匹配
    /// （Area在普通的之前）
    /// 
    /// 众所周知，MVC请求的最后是反射调用的Controller--action,信息是来自于
    /// url+route,路由匹配时，只能找到action和controller,其实还有个步骤，扫描+存储，
    /// 在bin文件夹里面找controller的子类，然后把命名空间一类名称+全部方法都存起来
    /// 
    /// 1控制器类可以出现在MVC项目之外，唯一的规则就是继承自Controller
    /// 2Area也可以独立开来，规则就是必须继承AreaRegistration
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