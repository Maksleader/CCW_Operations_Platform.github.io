using System.Threading.Tasks;

namespace CareProviderPortal.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}