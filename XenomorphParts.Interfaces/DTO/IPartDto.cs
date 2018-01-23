using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IPartDto
    {
        long Id { get; }
        string Name { get; }
        string Description { get; }
        decimal WholesalePrice { get; }
        decimal RetailPrice { get; }
        string ManufacturerId { get; }
        long VehicleModelId { get; }
        int Reserved { get; }
        int Available { get; }
        int LocatorAvailable { get; }
    }
}
