using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using CareProviderPortal.Configure;
using CareProviderPortal.Startup;
using CareProviderPortal.Test.Base;

namespace CareProviderPortal.GraphQL.Tests
{
    [DependsOn(
        typeof(CareProviderPortalGraphQLModule),
        typeof(CareProviderPortalTestBaseModule))]
    public class CareProviderPortalGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalGraphQLTestModule).GetAssembly());
        }
    }
}