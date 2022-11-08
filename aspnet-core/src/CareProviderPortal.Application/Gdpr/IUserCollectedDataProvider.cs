using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using CareProviderPortal.Dto;

namespace CareProviderPortal.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
