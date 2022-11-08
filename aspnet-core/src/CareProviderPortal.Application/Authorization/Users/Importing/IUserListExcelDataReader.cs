using System.Collections.Generic;
using CareProviderPortal.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace CareProviderPortal.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
