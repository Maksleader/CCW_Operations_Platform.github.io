using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    [DependsOn(typeof(CareProviderPortalClientModule), typeof(AbpAutoMapperModule))]
    public class CareProviderPortalXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalXamarinSharedModule).GetAssembly());
        }
    }
}