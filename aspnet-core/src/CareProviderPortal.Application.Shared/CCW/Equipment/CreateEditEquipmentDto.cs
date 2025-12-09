using CareProviderPortal.Enums.CCW;
using System;
using System.ComponentModel.DataAnnotations;

namespace CareProviderPortal.CCW.Equipment
{
    public class CreateEditEquipmentDto
    {
        public Guid? Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Brand { get; set; }

        [StringLength(256)]
        public string Model { get; set; }

        [StringLength(256)]
        public string SerialNumber { get; set; }

        [Required]
        public EquipmentDivision Division { get; set; }

        [Required]
        public EquipmentOwner Owner { get; set; }

        [Required]
        public EquipmentStatus Status { get; set; }

        public int LocationId { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
