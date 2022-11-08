using Microsoft.AspNetCore.Antiforgery;

namespace CareProviderPortal.Web.Controllers
{
    public class AntiForgeryController : CareProviderPortalControllerBase
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
