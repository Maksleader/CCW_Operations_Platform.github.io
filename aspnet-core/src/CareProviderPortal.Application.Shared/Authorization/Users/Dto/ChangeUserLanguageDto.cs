using System.ComponentModel.DataAnnotations;

namespace CareProviderPortal.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
