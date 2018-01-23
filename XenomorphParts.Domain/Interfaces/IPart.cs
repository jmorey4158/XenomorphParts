using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPart
    {
        long PartId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        decimal WholesalePrice { get; set; }
        decimal RetailPrice { get; set; }
        IVehicleMaker VehicleMaker { get; set; }
        IVehicleModel VehicleModel { get; set; }
        int ModelYear { get; set; }
        string PropulsionType { get; set; }
        int Reserved { get; set; }
        int Available { get; set; }
        int LocatorAvailable { get; set; }
    }
}
