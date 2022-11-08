using Abp.AspNetCore.Mvc.ViewComponents;

namespace CareProviderPortal.Web.Public.Views
{
    public abstract class CareProviderPortalViewComponent : AbpViewComponent
    {
        protected CareProviderPortalViewComponent()
        {
            LocalizationSourceName = CareProviderPortalConsts.LocalizationSourceName;
        }
    }
}