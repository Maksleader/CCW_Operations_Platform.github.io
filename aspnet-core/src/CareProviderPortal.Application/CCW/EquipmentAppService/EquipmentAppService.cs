using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using CareProviderPortal.Authorization;
using CareProviderPortal.CCW.Equipment;
using CareProviderPortal.CCW.Equipments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace CareProviderPortal.CCW.EquipmentAppService
{
    [AbpAuthorize(AppPermissions.Pages_Equipment)]
    public class EquipmentAppService : CareProviderPortalAppServiceBase, IEquipmentAppService
    {
        private readonly IRepository<Equipments.Equipment, Guid> _equipmentRepository;

        public EquipmentAppService(IRepository<Equipments.Equipment, Guid> equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }

        public async Task<PagedResultDto<EquipmentDto>> RetrieveEquipments(EquipmentInput input)
        {
            var query = _equipmentRepository.GetAll()
                .WhereIf(!input.EquipmentName.IsNullOrWhiteSpace(), 
                    e => e.Name.Contains(input.EquipmentName))
                .WhereIf(input.Division.HasValue, 
                    e => e.Division == input.Division.Value)
                .WhereIf(input.Owner.HasValue, 
                    e => e.Owner == input.Owner.Value)
                .WhereIf(input.Status.HasValue, 
                    e => e.Status == input.Status.Value);

            var totalCount = await query.CountAsync();

            var equipments = await query
                .OrderBy(input.Sorting ?? "Name")
                .PageBy(input)
                .ToListAsync();

            var equipmentDtos = ObjectMapper.Map<System.Collections.Generic.List<EquipmentDto>>(equipments);

            return new PagedResultDto<EquipmentDto>(totalCount, equipmentDtos);
        }

        public async Task<CreateEditEquipmentDto> GetEquipmentForEdit(Guid id)
        {
            var equipment = await _equipmentRepository.GetAsync(id);
            return ObjectMapper.Map<CreateEditEquipmentDto>(equipment);
        }

        [AbpAuthorize(AppPermissions.Pages_Equipment_Create)]
        public async Task CreateEquipment(CreateEditEquipmentDto input)
        {
            var equipment = ObjectMapper.Map<Equipments.Equipment>(input);
            await _equipmentRepository.InsertAsync(equipment);
        }

        [AbpAuthorize(AppPermissions.Pages_Equipment_Edit)]
        public async Task UpdateEquipment(CreateEditEquipmentDto input)
        {
            if (!input.Id.HasValue)
            {
                throw new ArgumentException("Id is required for update operation");
            }

            var equipment = await _equipmentRepository.GetAsync(input.Id.Value);
            ObjectMapper.Map(input, equipment);
            await _equipmentRepository.UpdateAsync(equipment);
        }

        [AbpAuthorize(AppPermissions.Pages_Equipment_Delete)]
        public async Task DeleteEquipment(EntityDto<Guid> input)
        {
            await _equipmentRepository.DeleteAsync(input.Id);
        }
    }
}
