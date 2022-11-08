using System.ComponentModel.DataAnnotations;

namespace CareProviderPortal.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}