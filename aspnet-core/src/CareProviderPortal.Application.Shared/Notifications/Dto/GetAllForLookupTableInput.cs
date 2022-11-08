using Abp.Application.Services.Dto;

namespace CareProviderPortal.Notifications.Dto
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}