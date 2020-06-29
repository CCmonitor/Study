using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ruanmou.Controllers
{
    /// <summary>
    /// 1 IOC和MVC的结合，工厂的创建和Bussiness初始化
    /// 2 WCF搜索引擎的封装调用和AOP的整合
    /// 3 HTTP请求的本质，各种ActionResult扩展计划
    /// 
    /// 完成ef6引入和数据访问
    /// </summary>
    public class ThirdController : Controller
    {
        // GET: Third
        public ActionResult Index()
        {
            IUserService service = new IUserService();
            return View();
        }
    }
}