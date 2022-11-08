using System.Threading.Tasks;
using Abp.Webhooks;

namespace CareProviderPortal.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
