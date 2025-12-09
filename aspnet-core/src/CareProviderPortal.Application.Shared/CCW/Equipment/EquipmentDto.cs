using Abp.Application.Services.Dto;
using CareProviderPortal.Enums.CCW;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareProviderPortal.CCW.Equipment
{
    public class EquipmentDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string BrandAndModel { get; set; }

        public EquipmentDivision Division { get; set; }

        public EquipmentOwner Owner { get; set; }

        public EquipmentStatus Status { get; set; }

        public string CurrentLocation { get; set; }
    }
}
