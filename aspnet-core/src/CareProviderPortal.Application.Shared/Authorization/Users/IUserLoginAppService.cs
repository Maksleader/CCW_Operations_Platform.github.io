using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CareProviderPortal.Authorization.Users.Dto;

namespace CareProviderPortal.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
