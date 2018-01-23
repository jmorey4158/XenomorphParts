using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IVehicleMaker
    {
        int VehicleMakerId { get; }
        string Name { get; }
        string Description { get; }
        long LocationId { get; }
    }
}
