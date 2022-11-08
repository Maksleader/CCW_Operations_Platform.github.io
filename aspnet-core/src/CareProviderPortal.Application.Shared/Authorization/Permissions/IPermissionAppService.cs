using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CareProviderPortal.Authorization.Permissions.Dto;

namespace CareProviderPortal.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
