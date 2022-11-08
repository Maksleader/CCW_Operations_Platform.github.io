using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using CareProviderPortal.Configuration;

namespace CareProviderPortal.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(CareProviderPortalTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
