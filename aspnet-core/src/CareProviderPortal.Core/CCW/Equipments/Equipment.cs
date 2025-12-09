using Abp.Domain.Entities.Auditing;
using CareProviderPortal.Enums.CCW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareProviderPortal.CCW.Equipments
{
    public class Equipment : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string SerialNumber { get; set; }

        public EquipmentDivision Division { get; set; }

        public EquipmentOwner Owner { get; set; }

        public EquipmentStatus Status { get; set; }

        public int LocationId { get; set; }

        public string Description { get; set; }
    }
}
