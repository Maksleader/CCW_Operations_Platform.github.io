using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    [DependsOn(typeof(CareProviderPortalCoreSharedModule))]
    public class CareProviderPortalApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalApplicationSharedModule).GetAssembly());
        }
    }
}