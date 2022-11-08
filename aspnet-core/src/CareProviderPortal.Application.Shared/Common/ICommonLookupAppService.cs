using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CareProviderPortal.Common.Dto;
using CareProviderPortal.Editions.Dto;

namespace CareProviderPortal.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}