using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ProjectAlex.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ProjectAlexControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}