using Abp.Dependency;

namespace CareProviderPortal.Web.Xss
{
    public interface IHtmlSanitizer: ITransientDependency
    {
        string Sanitize(string html);
    }
}