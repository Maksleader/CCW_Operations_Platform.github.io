using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    [DependsOn(typeof(CareProviderPortalXamarinSharedModule))]
    public class CareProviderPortalXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalXamarinAndroidModule).GetAssembly());
        }
    }
}