using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Common.Enums
{
    // DO NOT INT ASSOCIATION!!
    public enum ShipmentType
    {
        Complete = 0,
        Partial = 1,
        BackOrder = 2,
        WarehoseToStore = 3,
        StoreToCustomer = 4,
        ReturnFromCustomer = 5,
        ReturnToSupplier = 6,
        WarehouseToCustomer = 7
    }
}
