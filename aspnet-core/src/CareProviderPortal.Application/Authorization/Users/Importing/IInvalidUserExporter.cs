using System.Collections.Generic;
using CareProviderPortal.Authorization.Users.Importing.Dto;
using CareProviderPortal.Dto;

namespace CareProviderPortal.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
