using _MVC_01.Models;
using System.Web.Mvc;

namespace _MVC_01.Controllers
{
    /// <summary>
    /// Action的三种类型的参数：1.普通参数，2.Model类，3.formCollection
    /// </summary>
    public class DefaultController : Controller
    {
        /// <summary>
        /// 1.普通参数
        /// int类型的age必须传值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public ActionResult F1(string name, int age)
        {
            ///http://localhost:17138/default?id=111&&name=caientao
            ///把括号里面的字符串返回给浏览器
            return Content("name:" + name + "age:" + age);
        }
        /// <summary>
        /// 2.Model类
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public ActionResult Index(IndexModel m)
        {
            ///http://localhost:17138/default?id=111&&name=caientao
            ///把括号里面的字符串返回给浏览器
            return Content(m.Id + m.Name);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult F2Show()
        {
            return View();
        }
        /// <summary>
        /// 3.FormCollection post请求
        /// </summary>
        /// <param name="fc"></param>
        /// <returns></returns>
        public ActionResult F2(FormCollection fc)
        {
            string name = fc["name"];
            string age = fc["age"];
            return Content("name:" + name + "age:" + age);
        }
        /// <summary>
        /// Action的方法不能重载，
        /// 所以一个Controller中不能同时存在这二个Action:
        /// public ActionResultT1(string name);
        /// public ActionResult T1(int age);
        /// 特殊情况：给Action方法上标注[HttpGet],[HttpPost]
        /// </summary>
        /// <returns></returns>
        public ActionResult F3()
        {
            return Content("1111");
        }
        /// <summary>
        /// 特殊情况：给Action方法上标注[HttpGet],[HttpPost]，
        /// 这样当发出Get请求的时候执行标注[HttpGet]的Action方法，
        /// 当发出post请求的时候执行标注[HttpPost]的Action方法。没有标注的，
        /// 常见的应用：标注[HttpGet]的Action展示初始页面，
        /// 标注[HttpPost]的Action处理表单提交,案例：做一个报名页面
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ActionResult F3(string name)
        {
            return Content("名字" + name);
        }
    }
}