using System.Threading.Tasks;
using CareProviderPortal.Security.Recaptcha;

namespace CareProviderPortal.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
