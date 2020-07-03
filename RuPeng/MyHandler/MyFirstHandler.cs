using System.Web;
using System.Web.SessionState;

namespace MyHandler
{
    /// <summary>
    /// 目的：实现一个简单的自定义HttpHandler容器
    /// </summary>
    public class MyFirstHandler : IHttpHandler, IRequiresSessionState
    {
        #region IHttpHandler 成员

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h1><b>Hello HttpHandler</b></h1>");
            context.Session["Test"] = "测试HttpHandler容器中调用Session";
            context.Response.Write(context.Session["Test"]);
        }

        #endregion
    }
}