using Abp.Application.Services;
using CareProviderPortal.Dto;
using CareProviderPortal.Logging.Dto;

namespace CareProviderPortal.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
