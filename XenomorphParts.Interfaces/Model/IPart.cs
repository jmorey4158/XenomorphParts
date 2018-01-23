using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IPart
    {
        long Id { get; }
        string Name { get; }
        string Description { get; }
        decimal WholesalePrice { get; }
        decimal RetailPrice { get; }
        IEntity Manufacturer { get; }
        IVehicleModel VehicleModel { get; }
        int ModelYear { get; }
        int Reserved { get; }
        int Available { get; }
        int LocatorAvailable { get; }
    }
}
