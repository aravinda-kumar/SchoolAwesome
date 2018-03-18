using Microsoft.AspNetCore.Antiforgery;
using SchoolAwesome.Controllers;

namespace SchoolAwesome.Web.Host.Controllers
{
    public class AntiForgeryController : SchoolAwesomeControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
