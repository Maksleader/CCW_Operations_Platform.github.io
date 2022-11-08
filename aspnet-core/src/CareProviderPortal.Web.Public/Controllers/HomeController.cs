using Microsoft.AspNetCore.Mvc;
using CareProviderPortal.Web.Controllers;

namespace CareProviderPortal.Web.Public.Controllers
{
    public class HomeController : CareProviderPortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}