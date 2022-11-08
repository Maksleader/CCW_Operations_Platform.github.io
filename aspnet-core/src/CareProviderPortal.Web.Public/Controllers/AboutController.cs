using Microsoft.AspNetCore.Mvc;
using CareProviderPortal.Web.Controllers;

namespace CareProviderPortal.Web.Public.Controllers
{
    public class AboutController : CareProviderPortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}