using System.Collections.Generic;
using CareProviderPortal.Authorization.Users.Dto;
using CareProviderPortal.Dto;

namespace CareProviderPortal.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}