using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.Editions.Dto;
using CareProviderPortal.MultiTenancy.Dto;

namespace CareProviderPortal.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}