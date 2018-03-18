using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SchoolAwesome.Controllers;

namespace SchoolAwesome.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SchoolAwesomeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
