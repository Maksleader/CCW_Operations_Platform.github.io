using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Threading.Tasks;

namespace CareProviderPortal.CCW.Equipment
{
    public interface IEquipmentAppService : IApplicationService
    {
        Task<PagedResultDto<EquipmentDto>> GetEquipments(EquipmentInput input);
        
        Task<EquipmentDto> GetEquipmentForEdit(Guid id);
        
        Task CreateEquipment(CreateEditEquipmentDto input);
        
        Task UpdateEquipment(CreateEditEquipmentDto input);
        
        Task DeleteEquipment(EntityDto<Guid> input);
    }
}
