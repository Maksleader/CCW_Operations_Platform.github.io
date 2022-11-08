using System.Threading.Tasks;
using CareProviderPortal.Views;
using Xamarin.Forms;

namespace CareProviderPortal.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
