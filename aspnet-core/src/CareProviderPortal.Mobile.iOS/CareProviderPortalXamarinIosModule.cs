using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    [DependsOn(typeof(CareProviderPortalXamarinSharedModule))]
    public class CareProviderPortalXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalXamarinIosModule).GetAssembly());
        }
    }
}