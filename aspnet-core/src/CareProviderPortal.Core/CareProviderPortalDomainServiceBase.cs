using Abp.Domain.Services;

namespace CareProviderPortal
{
    public abstract class CareProviderPortalDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CareProviderPortalDomainServiceBase()
        {
            LocalizationSourceName = CareProviderPortalConsts.LocalizationSourceName;
        }
    }
}
