using Abp.AspNetCore.Mvc.Authorization;
using CareProviderPortal.Authorization;
using CareProviderPortal.Storage;
using Abp.BackgroundJobs;

namespace CareProviderPortal.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}