using CareProviderPortal.Editions.Dto;

namespace CareProviderPortal.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < CareProviderPortalConsts.MinimumUpgradePaymentAmount;
        }
    }
}
