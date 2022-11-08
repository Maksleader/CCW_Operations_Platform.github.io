using Abp.Auditing;
using CareProviderPortal.Configuration.Dto;

namespace CareProviderPortal.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}