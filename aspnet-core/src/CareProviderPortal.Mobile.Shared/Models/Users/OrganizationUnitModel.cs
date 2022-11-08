using Abp.AutoMapper;
using CareProviderPortal.Organizations.Dto;

namespace CareProviderPortal.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}