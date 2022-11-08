using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.Configuration.Tenants.Dto;

namespace CareProviderPortal.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
