using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CareProviderPortal.Web.Public.Views
{
    public abstract class CareProviderPortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CareProviderPortalRazorPage()
        {
            LocalizationSourceName = CareProviderPortalConsts.LocalizationSourceName;
        }
    }
}
