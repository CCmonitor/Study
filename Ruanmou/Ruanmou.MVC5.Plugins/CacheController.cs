using System.Web.Mvc;

namespace Ruanmou.MVC5.Plugins
{
    public class CacheController : Controller
    {
        public ActionResult CacheIndex()
        {

            return View("~/views/home/index.cshtml");
        }
    }
}
