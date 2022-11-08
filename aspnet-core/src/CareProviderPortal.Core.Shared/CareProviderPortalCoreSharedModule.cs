using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    public class CareProviderPortalCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalCoreSharedModule).GetAssembly());
        }
    }
}