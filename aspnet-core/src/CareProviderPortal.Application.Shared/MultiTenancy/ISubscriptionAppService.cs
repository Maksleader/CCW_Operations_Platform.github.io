using System.Threading.Tasks;
using Abp.Application.Services;

namespace CareProviderPortal.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
