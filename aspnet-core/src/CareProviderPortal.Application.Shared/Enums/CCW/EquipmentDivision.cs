using System;
using System.Collections.Generic;
using System.Text;

namespace CareProviderPortal.Enums.CCW
{
    [Flags]
    public enum EquipmentDivision : byte
    {
        None = 0,
        Cleaning = 1 << 0,
        Waste = 1 << 1,
        Catering = 1 << 2,
        FB = 1 << 3,
        AdminAndSupplyChain = 1 << 4,
        Others = 1 << 5
    }
}
