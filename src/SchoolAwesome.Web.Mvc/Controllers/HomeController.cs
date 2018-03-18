using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SchoolAwesome.Controllers;

namespace SchoolAwesome.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SchoolAwesomeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
