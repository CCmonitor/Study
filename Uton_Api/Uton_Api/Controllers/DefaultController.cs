using System.Web.Http;

namespace Uton_Api.Controllers
{
    //[Route("DefaultOrder")]
    public class DefaultController : ApiController
    {
        /// <summary>
        /// http://localhost:57705/Default/Getuser?name=1111&password=3333
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("Default/Getuser")]
        [HttpGet]
        public string Getuser(string name, string password)
        {
            return name + password;
        }

        /// <summary>
        /// http://localhost:57705/api/Default/getString
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string getString()
        {
            return "Hello";
        }
    }
}
