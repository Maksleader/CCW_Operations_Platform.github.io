using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.Configuration.Host.Dto;

namespace CareProviderPortal.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
