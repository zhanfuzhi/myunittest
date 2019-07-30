using System.Web.Mvc;

namespace myproject.Web.Controllers
{
    public class AboutController : myprojectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}