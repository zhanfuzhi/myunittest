using System.Web.Mvc;

namespace myproject.Web.Controllers
{
    public class HomeController : myprojectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}