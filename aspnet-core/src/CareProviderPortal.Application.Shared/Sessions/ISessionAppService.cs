using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.Sessions.Dto;

namespace CareProviderPortal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
