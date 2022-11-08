using System.ComponentModel.DataAnnotations;

namespace CareProviderPortal.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}