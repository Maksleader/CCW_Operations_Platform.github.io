using Abp.Application.Services.Dto;
using CareProviderPortal.Enums.CCW;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareProviderPortal.CCW.Equipment
{
    public class EquipmentInput : PagedAndSortedResultRequestDto
    {
        public string EquipmentName { get; set; }

        public EquipmentDivision? Division { get; set; }

        public EquipmentOwner? Owner { get; set; }

        public EquipmentStatus? Status { get; set; }
    }
}
