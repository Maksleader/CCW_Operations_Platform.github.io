using System.Threading.Tasks;
using CareProviderPortal.Sessions.Dto;

namespace CareProviderPortal.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
