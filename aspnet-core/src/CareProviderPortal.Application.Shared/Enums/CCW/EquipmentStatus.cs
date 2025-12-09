using System;
using System.Collections.Generic;
using System.Text;

namespace CareProviderPortal.Enums.CCW
{
    public enum EquipmentStatus : byte
    {
        InStorage = 1,
        OnSite = 2,
        Removed = 3,
        Broken = 4
    }
}
