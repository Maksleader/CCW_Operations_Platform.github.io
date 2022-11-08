using System.Threading.Tasks;
using Abp.Dependency;

namespace CareProviderPortal.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}