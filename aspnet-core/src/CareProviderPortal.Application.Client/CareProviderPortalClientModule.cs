using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CareProviderPortal
{
    public class CareProviderPortalClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CareProviderPortalClientModule).GetAssembly());
        }
    }
}
