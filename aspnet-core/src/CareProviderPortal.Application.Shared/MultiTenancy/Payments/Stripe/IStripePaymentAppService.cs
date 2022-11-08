using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.MultiTenancy.Payments.Dto;
using CareProviderPortal.MultiTenancy.Payments.Stripe.Dto;

namespace CareProviderPortal.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}