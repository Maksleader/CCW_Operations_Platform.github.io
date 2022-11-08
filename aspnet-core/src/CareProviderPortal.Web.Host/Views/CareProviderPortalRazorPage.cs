using Abp.AspNetCore.Mvc.Views;

namespace CareProviderPortal.Web.Views
{
    public abstract class CareProviderPortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CareProviderPortalRazorPage()
        {
            LocalizationSourceName = CareProviderPortalConsts.LocalizationSourceName;
        }
    }
}
