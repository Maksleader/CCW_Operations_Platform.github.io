using System.Collections.Generic;
using MvvmHelpers;
using CareProviderPortal.Models.NavigationMenu;

namespace CareProviderPortal.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}