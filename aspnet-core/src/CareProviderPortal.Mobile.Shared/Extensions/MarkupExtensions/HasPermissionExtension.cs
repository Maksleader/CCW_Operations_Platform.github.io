using System;
using CareProviderPortal.Core;
using CareProviderPortal.Core.Dependency;
using CareProviderPortal.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CareProviderPortal.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}