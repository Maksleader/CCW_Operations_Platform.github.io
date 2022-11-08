using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal.Startup
{
    [DependsOn(typeof(CareProviderPortalCoreModule))]
    public class CareProviderPortalGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}