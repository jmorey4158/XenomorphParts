using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Common.Enums
{
    // DO NOT INT ASSOCIATION!!
    public enum ShipmentStatus
    {
        OrderReady = 0,
        Packed = 1,
        Shipped = 2,
        Tracking = 3,
        Received = 4,
        Approved = 5,
        Unknown = 6
    }
}
