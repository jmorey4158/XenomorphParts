using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IVehicleModel
    {
        long VehicleModelId { get; }
        IVehicleMaker VehicleMaker { get; }
        string Name { get; }
        string Description { get; }
        int BeginYear { get; }
        int EndYear { get; }
    }
}

