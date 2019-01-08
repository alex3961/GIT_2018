using System.Web.Mvc;

namespace ProjectAlex.Web.Controllers
{
    public class AboutController : ProjectAlexControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}