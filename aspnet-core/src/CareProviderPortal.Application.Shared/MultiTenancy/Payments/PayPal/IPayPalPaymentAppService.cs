using System.Threading.Tasks;
using Abp.Application.Services;
using CareProviderPortal.MultiTenancy.Payments.PayPal.Dto;

namespace CareProviderPortal.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
