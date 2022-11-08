using Abp;

namespace CareProviderPortal
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="CareProviderPortalDomainServiceBase"/>.
    /// For application services inherit CareProviderPortalAppServiceBase.
    /// </summary>
    public abstract class CareProviderPortalServiceBase : AbpServiceBase
    {
        protected CareProviderPortalServiceBase()
        {
            LocalizationSourceName = CareProviderPortalConsts.LocalizationSourceName;
        }
    }
}