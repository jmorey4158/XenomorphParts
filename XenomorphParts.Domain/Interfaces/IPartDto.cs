using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPartDto
    {
        long PartId { get; }
        string Name { get; }
        string Description { get; }
        decimal WholesalePrice { get; }
        decimal RetailPrice { get; }
        string VehicleMaker { get; }
        string VehicleModel { get; }
        string PropulsionType { get; }
        int ModelYear { get; }
        int Reserved { get; }
        int Available { get; }
        int LocatorAvailable { get; }
    }
}
