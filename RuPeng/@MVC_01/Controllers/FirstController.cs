using _MVC_01.Models;
using System.Web.Mvc;

namespace _MVC_01.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            var indexmodel = new IndexModel()
            {
                Id = 111,
                Name = "name"
            };
            return View(indexmodel);
        }
    }
}