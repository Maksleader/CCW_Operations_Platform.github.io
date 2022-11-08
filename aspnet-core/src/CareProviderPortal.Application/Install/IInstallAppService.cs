using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.Install.Dto;

namespace CareProviderPortal.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}