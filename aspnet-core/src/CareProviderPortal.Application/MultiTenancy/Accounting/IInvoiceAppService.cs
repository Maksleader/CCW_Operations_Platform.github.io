using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CareProviderPortal.MultiTenancy.Accounting.Dto;

namespace CareProviderPortal.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
