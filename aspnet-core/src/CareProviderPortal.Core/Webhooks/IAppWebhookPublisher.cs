using System.Threading.Tasks;
using CareProviderPortal.Authorization.Users;

namespace CareProviderPortal.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
