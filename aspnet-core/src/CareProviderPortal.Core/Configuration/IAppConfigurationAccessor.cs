using Microsoft.Extensions.Configuration;

namespace CareProviderPortal.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
