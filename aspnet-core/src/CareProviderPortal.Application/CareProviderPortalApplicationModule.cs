using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CareProviderPortal.Authorization;

namespace CareProviderPortal
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(CareProviderPortalApplicationSharedModule),
        typeof(CareProviderPortalCoreModule)
        )]
    public class CareProviderPortalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalApplicationModule).GetAssembly());
        }
    }
}